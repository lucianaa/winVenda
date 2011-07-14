using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
namespace winVenda
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Verificar se existe banco de dados
            //if (System.Configuration.ConfigurationManager.AppSettings["serverDB"] == null)
            //    new FormConfig().ShowDialog();
            //else
            Conn.Conectar();
            Application.Run(new TelaPrincipal());
            Conn.Close();
        }
    }
}
