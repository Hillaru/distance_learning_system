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
    public partial class VideoMethod : Form
    {
        public VideoMethod(int mode = 0, string title  = BASIC_STR, string link = BASIC_STR, double duration = 0)
        {
            InitializeComponent();

            if (mode != 0)
            {
                lblLink.Text = link;
                tbLink.Text = link;
                tbTitle.Text = title;

                tbDuration.Text = Convert.ToString(duration);
            }

            if (mode == 2)
            {
                tbDuration.ReadOnly = true;
                tbLink.Hide();
                butCancel.Hide();
                butSave.Hide();
                tbTitle.ReadOnly = true;
            }
        }

        private string oldText = "0";

        private void tbDuration_TextChanged(object sender, EventArgs e)
        {
            string text = tbDuration.Text;
            double i = 0;
            if (!double.TryParse(text, out i) || text.Length > 5)
                tbDuration.Text = oldText;
            else
                oldText = tbDuration.Text;

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTransferObject.method = new Video(tbTitle.Text, lblLink.Text, Convert.ToDouble(tbDuration.Text));
                Close();
            }
            catch {
                DataTransferObject.method = null;
            }
            
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = null;
            Close();
        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {
            lblLink.Text = tbLink.Text;
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblLink.Text);
        }
    }
}
