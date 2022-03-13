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
    public partial class TestMethod : Form
    {
        private Test test = new Test();
        private int ind = 0;

        public TestMethod(Test _test = null)
        {
            InitializeComponent();

            if (_test == null) Close();
            test = _test;
            Text = test.title + "(Тест)";
            progressBar1.Maximum = test.Guestion_list.Count;

            refresh();
        }

        private void refresh()
        {
            rtbQuestion.Text = test.Guestion_list[ind];
            lblNum.Text = Convert.ToString(ind + 1);
            progressBar1.Value = ind + 1;
        }

        private void butAnswer_Click(object sender, EventArgs e)
        {
            ind++;
            if (ind >= test.Guestion_list.Count)
            {
                MessageBox.Show("Тест выполнен!", "Уведомление");
                Close();
            }
            else
            refresh();
        }
    }
}
