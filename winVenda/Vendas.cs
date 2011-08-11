using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace winVenda
{
    public partial class Vendas : Form
    {
        ArrayList arr = new ArrayList();
        double total = 0;
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
           ClientesCadastrados cl = new ClientesCadastrados(true);
           cl.ShowDialog();
           txtCliente.Text = cl.ClienteSelecionado.Nome; 
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ProdutoVenda pr = new ProdutoVenda(txtProduto.Text);
            pr.ShowDialog();
            
            if (pr.prod.Codigo != 0)
            {
                arr.Add(pr.prod);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = arr;
                //codigo
                dataGridView1.Columns[0].Visible = false;
                //descricao
                dataGridView1.Columns[2].Visible = false;
                total = total + pr.prod.Preco * pr.prod.Quantidade;
                txtTotal.Text = total.ToString();
            }
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = arr;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { 
            }

        }
    }
}
