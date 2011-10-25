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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto pr = new Produto();
            pr.Nome = txtNome.Text;
            pr.Descricao = txtDescricao.Text;
            pr.Quantidade = double.Parse(txtEstoque.Text);
            pr.Preco = double.Parse(txtPreco.Text);
            pr.Salvar();
            MessageBox.Show("Dados salvos com sucesso");
        }
    }
}
