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
using NAudio.Lame;

namespace ConvertApp
{
    public partial class FormApp : Form
    {
        // Declare a global variable
        private string dataconvert;
        private SystemConvert converter;

        public FormApp()
        {
            InitializeComponent();
            AppInit();

            // Create an instance of SystemConvert
            converter = new SystemConvert(this);
        }

        private void AppInit()
        {
            cbxConvert.SelectedIndex = 0;
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

                    converter.ProcessConvertMusic(dataconvert, cbxConvert.SelectedItem.ToString());

                    // Display a MessageBox with "Conversion successful!" message and OK button
                    var result = MessageBox.Show("ทำการแปลงข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK);
                    // Check if the user clicked the OK button
                    if (result == DialogResult.OK)
                    {
                        // Update the progress bar to 0
                        txtFilePath.Text = "";
                        dataconvert = "";
                        converter.UpdateProgressBar(0);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // ปิดแอปพลิเคชันหรือฟอร์ม
        }


    }
}
