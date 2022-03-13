using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLS;
using System.IO;
using static DLS.CONSTANTS;

static class Program
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        Application.Run(new Authorize());

        DLSdata DLSdata = GenericXmlSerializer.ReadObject<DLSdata>("DLSdata.xml");

        if (DLSdata.Find_Person(DLSdata.User.name) != null)
            Application.Run(new MainWindow());
        
    }
}