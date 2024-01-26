using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.Lame;

namespace ConvertApp
{
    internal class SystemConvert
    {
        private readonly FormApp FApp;

        public SystemConvert(FormApp formApp)
        {
            FApp = formApp;
        }

        public void Test()
        {
            // Do something with the inputData and access UI elements in _formApp
            FApp.txtFilePath.Text = "wow";
            //Console.WriteLine(inputData);
        }


        public void ProcessConvertMusic(string mp4FilePath, string selectedFormat)
        {
            string outputExtension = selectedFormat.ToLower().Trim();
            string outputFilePath = $"{Path.GetFileNameWithoutExtension(mp4FilePath)}.{outputExtension}";


            using (var reader = new MediaFoundationReader(mp4FilePath))
            {
                //int bufferSize = 4096;
                int bufferSize = 8192;
                byte[] buffer = new byte[bufferSize];
                long totalBytes = reader.Length;
                long bytesRead = 0;

                var format = reader.WaveFormat;
                //var format = reader.WaveFormat; // Standard
                //var format = new WaveFormat(reader.WaveFormat.SampleRate, 16, 1); // ตั้งค่า sample rate เป็นเดิม (reader.WaveFormat.SampleRate)

                var bitRate = 192;

                // ตรวจสอบว่าเลือกรูปแบบ MP3 หรือไม่
                if (outputExtension == "mp3")
                {
                    // ใช้ LameMP3FileWriter สำหรับ MP3
                    using (var writer = new LameMP3FileWriter(outputFilePath, format, bitRate))
                    {
                        int read;
                        while ((read = reader.Read(buffer, 0, bufferSize)) > 0)
                        {
                            writer.Write(buffer, 0, read);
                            bytesRead += read;

                            // Calculate the progress percentage
                            int progress = (int)((double)bytesRead / totalBytes * 100);

                            // Update the progress bar 
                            UpdateProgressBar(progress);
                        }
                    }
                }
                else
                {
                    // ใช้ WaveFileWriter สำหรับรูปแบบอื่น ๆ
                    format = new WaveFormat(44100, 16, 2);
                    using (var writer = new WaveFileWriter(outputFilePath, format))
                    {
                        int read;
                        while ((read = reader.Read(buffer, 0, bufferSize)) > 0)
                        {
                            writer.Write(buffer, 0, read);
                            bytesRead += read;

                            // Calculate the progress percentage
                            int progress = (int)((double)bytesRead / totalBytes * 100);

                            // Update the progress bar 
                            UpdateProgressBar(progress);
                        }
                    }
                }
            }

            UpdateProgressBar(100);

            FApp.btnBrowse.Enabled = true;
            FApp.btnConvert.Enabled = true;
        }

        public void UpdateProgressBar(int progress)
        {
            if (FApp.progressBar.InvokeRequired)
            {
                // If called from a different thread, invoke on the UI thread
                FApp.progressBar.Invoke(new Action<int>(UpdateProgressBar), progress);
            }
            else
            {
                // Update the progress bar value
                FApp.progressBar.Value = progress;
            }
        }
    }
}
