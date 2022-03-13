using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLS
{
    public partial class EditTestMethod : Form
    {
        private List<string> Guestion_list = new List<string> { "" };
        private int ind = 0;

        public EditTestMethod(int mode = 0, Test test = null)
        {
            InitializeComponent();

            if (mode == 1)
            {
                Guestion_list = test.Guestion_list;
                tbTitle.Text = test.title;
            }
        }

        private void refresh()
        {
            lblNum.Text = Convert.ToString(ind + 1);
            rtbQuestion.Text = Guestion_list[ind];
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = new Test(tbTitle.Text, Guestion_list);
            Close();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransferObject.method = null;
            Close();
        }

        private void butRight_Click(object sender, EventArgs e)
        {
            if (ind + 1 < Guestion_list.Count)
                ind++;
            refresh();
        }

        private void butLeft_Click(object sender, EventArgs e)
        {
            if (ind > 0)
                ind--;
            refresh();
        }

        private void rtbQuestion_TextChanged(object sender, EventArgs e)
        {
            Guestion_list[ind] = rtbQuestion.Text;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Guestion_list.Add("");
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (Guestion_list.Count > 1)
            {
                Guestion_list.RemoveAt(ind);
                ind = 0;
                refresh();
            }
        }

        private void EditTestMethod_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
