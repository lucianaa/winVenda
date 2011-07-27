using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winVenda
{
    public partial class Login : Form
    {
        public  bool LoginOK{ get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Fazer a consulta no banco de dados e verificar se o usuário e senha estão corretos.
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {

                LoginOK = true;
                //MessageBox.Show(");
                this.Close();
            }
            else
            {
                lblStatus.Text = "Usuário e senha incorretos.";
                LoginOK = false;
            }
        }
    }
}
