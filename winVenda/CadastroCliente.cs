using System;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace winVenda
{
    public partial class CadastroCliente : Form
    {
        int Codigo;
        Cliente cl = new Cliente();
        //Construtor padrão
        public CadastroCliente()
        {
            InitializeComponent();
        }

        //Construtor para a edição
        //editar
        public CadastroCliente(Cliente cli)
        {
            InitializeComponent();

            Codigo = cli.Codigo;
            txtNome.Text = cli.Nome;
            txtEndereco.Text = cli.Endereco;
            txtTelefone.Text = cli.Telefone;
            btnApagar.Enabled = true;
        }


        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            cl.Nome = txtNome.Text;
            cl.Endereco = txtEndereco.Text;
            cl.Telefone = txtTelefone.Text;
            if (Codigo == 0)
            {
                try
                {
                    cl.Salvar();
                    MessageBox.Show("Dados salvos com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel salvar. " + ex.Message);
                }
                    
                limpar();
            }
            else
            {
                cl.Editar(Codigo);
                MessageBox.Show("Dados alterados com sucesso");
                this.Close();
            }
            //Limpar a tela           
 
        }
        
        private void limpar()
        {

            txtNome.Text = null;
            txtEndereco.Text = null;
            txtTelefone.Text = null;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (Codigo != 0)
            {
                new Cliente().Deletar(Codigo);
                MessageBox.Show("Registro apagado com sucesso.");
                this.Close();
            }


        }
    }
}
