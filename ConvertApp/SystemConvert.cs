using System;
using System.IO;
using System.Threading.Tasks;

using NAudio.Wave;
using NAudio.Lame;
using ImageMagick;
using System.Windows.Forms;

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
        }


        public void ProcessConvertMusic(string mp4FilePath, string selectedFormat)
        {
            string outputExtension = selectedFormat.ToLower().Trim();
            string outputFilePath = $"{Path.GetFileNameWithoutExtension(mp4FilePath)}.{outputExtension}";


            using (var reader = new MediaFoundationReader(mp4FilePath))
            {
               int bufferSize = 4096;
               // int bufferSize = 8192;
                byte[] buffer = new byte[bufferSize];
                long totalBytes = reader.Length;
                long bytesRead = 0;


                //var format = new WaveFormat(reader.WaveFormat.SampleRate, 16, 1); // ตั้งค่า sample rate เป็นเดิม (reader.WaveFormat.SampleRate)
                var format = reader.WaveFormat; // {16 bit PCM: 44100Hz 2 channels}  // Standard
                var bitRate = 256; //128 kbps ,192 kbps,256 kbps

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
                            UpdateProgressBar(FApp.progressBar, progress);
                        }
                    }
                }
                else
                {
                    // ใช้ WaveFileWriter สำหรับรูปแบบอื่น ๆ
                    //format = new WaveFormat();
                    // format = new WaveFormat(44100, 16, 2);
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
                            UpdateProgressBar(FApp.progressBarImage, progress);
                        }
                    }
                }
            }

            UpdateProgressBar(FApp.progressBar, 100);

            FApp.btnBrowse.Enabled = true;
            FApp.btnConvert.Enabled = true;
        }



        public void UpdateProgressBar(ProgressBar barname, int progress)
        {
            if (barname.InvokeRequired)
            {
                // If called from a different thread, invoke on the UI thread
                // barname.Invoke(new Action<int>(UpdateProgressBar), progress);
                barname.Invoke((MethodInvoker)delegate { barname.Value = progress; });
            }
            else
            {
                // Update the progress bar value
                barname.Value = progress;
            }
        }


        public void ConvertImage(string ImageFilePath, string selectedFormat)
        {
            bool data_status = true;
            string outputExtension = selectedFormat.ToLower().Trim();
            string outputFilePath = $"{Path.GetFileNameWithoutExtension(ImageFilePath)}.{outputExtension}";

            using (MagickImage image = new MagickImage(ImageFilePath))
            {

                // กำหนด event handler สำหรับตรวจสอบ progress
                image.Progress += (sender, eventArgs) =>
                {
                    try
                    {
                        // คำนวณ percentage จากขนาดข้อมูลที่เขียนแล้วเทียบกับขนาดที่ควรจะเขียนทั้งหมด
                        double percentage = (double)eventArgs.Progress / 100;
                        FApp.progressBarImage.Value = (int)(percentage * 100);
                        //Console.WriteLine("Writing: {0}%", percentage);
                        data_status = true;
                    }
                    catch
                    {
                        data_status = false;
                    }
                };

                if (data_status == true)
                {
                    // เขียนภาพออกไปยังไฟล์
                    image.Write(outputFilePath);
                    FApp.progressBarImage.Value = 100;
                }

            }
            MessageBox.Show("Conversion Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void HighRes(string inputFilePath,int level)
        {

            string level_name = "44_1kHz";
    

            int sampleRate = 44100;
            int bitDepth = 16;
            int channels = 2;

          
            switch (level)
            {
                case 1:
                    sampleRate = 96000;
                    bitDepth = 24;
                    channels = 2;
                    level_name = "96kHz";
                    break;
                case 2:
                    sampleRate = 192000;
                    bitDepth = 24;
                    channels = 2;
                    level_name = "192kHz";
                    break;
                default:
                    break;
            }

            string outputFilePath = $"{Path.GetFileNameWithoutExtension(inputFilePath)}_{level_name}.{"wav"}";
            Console.WriteLine(outputFilePath);
            using (var mp3Reader = new Mp3FileReader(inputFilePath))
            {
                // สร้าง WaveFormat สำหรับ hi-res
                var desiredFormat = new WaveFormat(sampleRate, bitDepth, channels); // 96kHz sample rate, 24-bit depth, stereo

                // แปลง MP3 เป็นรูปแบบ hi-res
                using (var resampler = new MediaFoundationResampler(mp3Reader, desiredFormat))
                {
                    WaveFileWriter.CreateWaveFile(outputFilePath, resampler);
                }
                MessageBox.Show("Hihg Res Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
