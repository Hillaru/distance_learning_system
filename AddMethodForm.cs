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
    public partial class AddMethodForm : Form
    {
        public AddMethodForm()
        {
            InitializeComponent();
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            DataTransferObject.str = comboBox1.Text;
            Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransferObject.str = BASIC_STR;
            Close();
        }
    }
}
