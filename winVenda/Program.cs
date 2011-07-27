using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
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

            //Verificar se o banco de dados já foi configurado
            //Arquivo separado para configuração não é método seguro
            //É necessário fazer um tratamento de exceção mais cuidadoso.
            if (!File.Exists("config.xml"))
            {
                new FormConfig().ShowDialog();
            }
            else
            {
                Conn.recuperaConn("config.xml");
                Conn.Conectar();

            }
            if (FormConfig.OK == true || File.Exists("config.xml"))
            {
                //Login 
                Login log = new Login();
                log.ShowDialog();
                if (log.LoginOK == true)
                {
                    
                    //Conn.Conectar();
                    Application.Run(new TelaPrincipal());
                    Conn.Close();
                }
                else Application.Exit();
            }
        }

    }
}
