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
            if (Verifica() != 0)
            {
                MessageBox.Show("Os campos com * precisam ser preenchidos.");
            }
            else
            {

                Conn.hostDB = textBox1.Text;
                Conn.Database = textBox2.Text;
                Conn.userDB = textBox3.Text;
                Conn.passwdDB = textBox4.Text;
                Conn.createStringConnection();

                try
                {
                                       
                    Conn.Conectar();
                    
                    System.Configuration.Configuration config =
                            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    AppSettingsSection appSetSec = config.AppSettings;
                    config.AppSettings.Settings["hostDB"].Value = textBox1.Text;
                    config.AppSettings.Settings["database"].Value = textBox2.Text;
                    config.AppSettings.Settings["userDB"].Value = textBox3.Text;
                    config.AppSettings.Settings["passwordDB"].Value = textBox4.Text;
                    label6.Text = "Conectado";
                    config.Save();
                    //config.AppSettings.Settings[
                // Atualiza a seção do appString também
                 ConfigurationManager.RefreshSection("appSettings");

                    MessageBox.Show("Configuração Salva");

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível conectar");
                }
                               
                
            }
        }
        int Verifica()
        {
            int erros=0;
            if (textBox1.Text == string.Empty)
            {
                label1.Text = label1.Text + " *";
                label1.ForeColor = Color.Red;
                erros++;
            }
            return erros;
            
        }
    }
}
