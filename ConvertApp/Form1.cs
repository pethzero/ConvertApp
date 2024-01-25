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
    public partial class Form1 : Form
    {
        // Declare a global variable
        private string dataconvert;

        public Form1()
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
            openFileDialog.Filter = "MP4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
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
                string mp4FilePath = dataconvert;
                string mp3FilePath = $"Convert_{Path.GetFileNameWithoutExtension(mp4FilePath)}.mp3";

                try
                {
                    using (var reader = new MediaFoundationReader(mp4FilePath))
                    {
                        WaveFileWriter.CreateWaveFile(mp3FilePath, reader);
                    }

                    MessageBox.Show("Conversion successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during conversion: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select an MP4 file before converting.");
            }

        }
    }
}
