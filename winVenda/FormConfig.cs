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
using System.Xml;
using System.IO;

namespace winVenda
{
    public partial class FormConfig : Form
    {
        public static bool OK = false;

        public FormConfig()
        {
            InitializeComponent();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            XmlTextWriter myXmlTextWriter = new XmlTextWriter ("config.xml",System.Text.Encoding.UTF8);
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


                    myXmlTextWriter.WriteStartElement("conectionstring");
                    myXmlTextWriter.WriteAttributeString("hostDB", textBox1.Text);
                    myXmlTextWriter.WriteAttributeString("database", textBox2.Text);
                    myXmlTextWriter.WriteAttributeString("userDB", textBox3.Text);
                    myXmlTextWriter.WriteAttributeString("passwordDB", textBox4.Text);
                    myXmlTextWriter.WriteEndElement();

                    //label6.Text = "Conectado";


                    Conn.ExecuteNonQueryFile("sql.sql");
                    myXmlTextWriter.Flush();
                    myXmlTextWriter.Close();
                    MessageBox.Show("Configuração Salva");
                    OK = true;
                    this.Close();

                }
                    
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível conectar. " + ex.Message);
                    myXmlTextWriter.Close();
                    File.Delete("config.xml");

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
