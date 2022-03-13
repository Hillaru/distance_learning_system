using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DLS.CONSTANTS;

namespace DLS
{
    public partial class PictureMethod : Form
    {
        private string PicturePath;

        public PictureMethod(int mode = 0, string _PicturePath = BASIC_STR, string _Title = BASIC_STR)
        {           
            InitializeComponent();

            if (mode != 0)
            {
                if (_PicturePath != BASIC_STR)
                {
                    PicturePath = _PicturePath;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(PicturePath);
                    }
                    catch
                    {
                        pictureBox1.Image = Image.FromFile(ERROR_IMAGE);                       
                    }                   
                }

                if (_Title != BASIC_STR)
                {
                    lblTitle.Text = _Title;
                    tbTitle.Text = _Title;
                }
            }

            if (mode == 2)
            {
                butCancel.Hide();
                butImgload.Hide();
                butOK.Hide();
                tbTitle.Hide();
            }
        }

        private void butImgload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Image Load";
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(PicturePath);
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(ERROR_IMAGE);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            PicturePath = openFileDialog1.FileName;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = tbTitle.Text;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = null;
            Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = new Picture(lblTitle.Text, PicturePath);
            Close();
        }
    }
}
