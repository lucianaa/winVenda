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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ClientesCadastrados().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Sobre().ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            new CadastroProduto().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ProdutoCadastrados().ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            new Vendas().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
