using System;
using System.Windows.Forms;
using System.IO;
using static DLS.CONSTANTS;
using System.Xml.Serialization;


namespace DLS
{
    public partial class Authorize : Form
    {
        private string login = BASIC_STR, password = BASIC_STR;

        public Authorize()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            login = tbLogin.Text;
            password = tbPassword.Text;

            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");          

            DLSdata.User = DLSdata.Find_Person(login, password);

            if (DLSdata.User == null)
            {
                MessageBox.Show("Пользователя с такими данными не существует","ОШИБКА");
                return;
            }

            MessageBox.Show($"Вы вошли в систему как {DLSdata.User.name}", "Вход выполнен");

            GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");
            Close();
                       
        }

        private void Authorize_Load(object sender, EventArgs e)
        {
            DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");
            DLSdata.User = new student();
            GenericXmlSerializer.WriteObject(DLSdata, "DLSdata.xml");     
        }

    }
}
