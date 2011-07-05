using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Incluir a referência manualmente
using System.Configuration;

namespace winVenda
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                //Testar a conexão antes de salvar
                try
                {
                                       
                    Conn.Conectar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível conectar");
                }
                if (Conn.mConn.State == ConnectionState.Open)
                {
                    System.Configuration.Configuration config =
                        ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    AppSettingsSection appSetSec = config.AppSettings;
                    appSetSec.Settings["hostDB"].Value = textBox1.Text;
                    appSetSec.Settings["userDB"].Value = textBox2.Text;
                    appSetSec.Settings["passwdDB"].Value = textBox3.Text;
                    appSetSec.Settings["database"].Value = textBox4.Text;
                    MessageBox.Show("Configuração Salva");
                    this.Close();
                }
                
               
                
            }
        }
    }
}
