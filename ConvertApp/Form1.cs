using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;

namespace ConvertApp
{
    public partial class FormApp : Form
    {
        // Declare a global variable
        private string dataconvert;


        public FormApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Open File Dialog to select .mp4 file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 files (*.mp4)|*.mp4";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected file path to TextBox
                string fileName = Path.GetFileName(openFileDialog.FileName);
                txtFilePath.Text = fileName;
                btnConvert.Enabled = true; // Enable Convert button

                // Assign the file path to the global variable
                dataconvert = openFileDialog.FileName;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataconvert))
            {
                try
                {
                    btnBrowse.Enabled = false;
                    btnConvert.Enabled = false;
                    ConvertMp4ToMp3(dataconvert);
                    // Display a MessageBox with "Conversion successful!" message and OK button
                    var result = MessageBox.Show("ทำการแปลงข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK);
                    // Check if the user clicked the OK button
                    if (result == DialogResult.OK)
                    {
                        // Update the progress bar to 0
                        txtFilePath.Text = "";
                        dataconvert = "";
                        UpdateProgressBar(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"พบข้อผิดพลาด: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือก MP4 ก่อนแปลงไฟล์");
            }

        }
   
        private void ConvertMp4ToMp3(string mp4FilePath)
        {
            string mp3FilePath = $"{Path.GetFileNameWithoutExtension(mp4FilePath)}.mp3";

            using (var reader = new MediaFoundationReader(mp4FilePath))
            {
                // UPDATELOADING
                int bufferSize = 4096;
                byte[] buffer = new byte[bufferSize];
                long totalBytes = reader.Length;
                long bytesRead = 0;

                using (var writer = new WaveFileWriter(mp3FilePath, reader.WaveFormat))
                {
                    int read;
                    while ((read = reader.Read(buffer, 0, bufferSize)) > 0)
                    {
                        writer.Write(buffer, 0, read);
                        bytesRead += read;

                        // Calculate the progress percentage
                        int progress = (int)((double)bytesRead / totalBytes * 100);

                        // Update the progress bar and label
                        UpdateProgressBar(progress);
                        //UpdateLabel(progress);

                        // Add a small delay to avoid UI freezing
                        //System.Threading.Thread.Sleep(2);
                    }
                }
            }

            // Reset the progress bar and label to 100% after completion
            UpdateProgressBar(100);
           // UpdateLabel(100);


            btnBrowse.Enabled = true;
            btnConvert.Enabled = true;
        }


        private void UpdateProgressBar(int progress)
        {
            if (progressBar.InvokeRequired)
            {
                // If called from a different thread, invoke on the UI thread
                progressBar.Invoke(new Action<int>(UpdateProgressBar), progress);
            }
            else
            {
                // Update the progress bar value
                progressBar.Value = progress;
            }
        }

        private void UpdateLabel(int progress)
        {
            if (lblProcess.InvokeRequired)
            {
                // If called from a different thread, invoke on the UI thread
                lblProcess.Invoke(new Action<int>(UpdateLabel), progress);
            }
            else
            {
                // Update the label text
                lblProcess.Text = $"Loading: {progress}%";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dataconvert))
            {
                try
                {
                    txtFilePath.Text = "";
                    dataconvert = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }



    }
}
