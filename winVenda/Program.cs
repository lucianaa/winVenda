using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            //Verificar se existe banco de dados
            
            Conn.Conectar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
        }
    }
}
