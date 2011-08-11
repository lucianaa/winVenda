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
    public partial class ProdutoVenda : Form
    {
        public Produto prod = new Produto();
        string nome_produto;
        ArrayList arr = new ArrayList();
        public ProdutoVenda()
        {
            InitializeComponent();
        }

        public ProdutoVenda(string nome)
        {
            nome_produto = nome;
            
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            Produto cl = new Produto();
            //Faz a chamada ao método listar da classe cliente
            arr = cl.listar(nome_produto);
            //atribui o resultado dà propriedade DataSource da dataGridView
            dataGridView1.DataSource = arr;
            //adicionar botao no grid
            DataGridViewButtonColumn dgBtnCol = new DataGridViewButtonColumn();
            dgBtnCol.Name = "Quantidade";
            dgBtnCol.UseColumnTextForButtonValue = true;
            dgBtnCol.Text = "Adicionar Quant";
            

            dataGridView1.Columns.Add(dgBtnCol);

            //adicionar checkbox
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            //check.Name = "Selecionar";
            check.HeaderText = "Selecionar";
            dataGridView1.Columns.Add(check);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

        }

        private void ProdutoVenda_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ultima coluna com o checkbox
            if (e.ColumnIndex == (dataGridView1.Columns.Count - 1))
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    int indice = dataGridView1.CurrentRow.Index;
                    prod = ((Produto)arr[indice]);
                    this.Close();
                }
            }
            //penultima coluna com o botao
            if (e.ColumnIndex == (dataGridView1.Columns.Count - 2))
            {

               Quant q =  new Quant();
               q.ShowDialog();
               double valor = q.quant;
                //adicionar ao arraylist
               int indice = dataGridView1.CurrentRow.Index;
               ((Produto)arr[indice]).Quantidade = valor;
                //mostrar a quantidade
               dataGridView1.Columns[3].Visible = true;
                  //check.CellTemplate.Value = valor.ToString();
               

            }

        }
    }
}
