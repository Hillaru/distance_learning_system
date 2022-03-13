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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm(bool mode = false)
        {
            InitializeComponent();

            if (mode) 
            {
                this.Text = "Редактирование курса";
                butCreate.Text = "Переименовать";
            }
        }

        private string title = BASIC_STR;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            title = textBox1.Text;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransferObject.course = null;
            Close();
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            DataTransferObject.course = new Course(title, DLSdata.User.name);

            Close();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
