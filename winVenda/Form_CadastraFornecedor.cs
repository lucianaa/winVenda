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
    public partial class Form_CadastraFornecedor : Form
    {
        public Form_CadastraFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor objf = new Fornecedor();

            objf.Nome = txtNome.Text;
            objf.Endereco = txtEndereco.Text;
            objf.Telefone = txtTelefone.Text;

            //Conn banco = new Conn(objf);
            try
            {
                objf.Salvar();
                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível salvar" + e.Message);
            }

        }
    }
}
