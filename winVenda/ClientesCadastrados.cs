using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace winVenda
{
    public partial class ClientesCadastrados : Form
    {

        ArrayList arr = new ArrayList();
        bool abrirvendas = false;
        public Cliente ClienteSelecionado;
        public ClientesCadastrados()
        {
            InitializeComponent();
        }

        public ClientesCadastrados(bool vendas)
        {
            //btnNovo.Visible = true;
            abrirvendas = vendas;
            InitializeComponent();
        }

        private void ClientesCadastrados_Load(object sender, EventArgs e)
        {
            CarregaGrid();
       
         }
        private void CarregaGrid()
        {
            Cliente cl = new Cliente();
            //Faz a chamada ao método listar da classe cliente
            arr = cl.listar();
            //atribui o resultado dà propriedade DataSource da dataGridView
            dataGridView1.DataSource = arr; 

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            if (abrirvendas == true)
            {
                ClienteSelecionado = (Cliente)arr[indice];
 
            }
            else
            {
                new CadastroCliente((Cliente)arr[indice]).ShowDialog();

            } 
            this.Close();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            //Sobrecarga do método listar para buscar pelo nome
            arr = cl.listar(txtNome.Text);
            //atribui o resultado dà propriedade DataSource da dataGridView
            dataGridView1.DataSource = arr;
            if (arr.Count == 0) 
                MessageBox.Show("Nenhum registro foi encontrado");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
            CarregaGrid();
        }




    }
}
