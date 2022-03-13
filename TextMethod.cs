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
    public partial class TextMethod : Form
    {
        public TextMethod(int mode = 0, string _Title = BASIC_STR, string _Text = BASIC_STR)
        {
            InitializeComponent();

            if (mode != 0)
            {
                Text = "Текстовая форма";
                tbTitle.Text = _Title;
                rtbText.Text = _Text;
            }

            if (mode == 2)
            {
                tbTitle.ReadOnly = true;
                rtbText.ReadOnly = true;
                butCancel.Hide();
                butOk.Hide();
            }
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = new Text(tbTitle.Text, rtbText.Text);
            Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = null;
            Close();
        }
    }
}
