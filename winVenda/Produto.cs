using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System;
using System.Globalization;

namespace winVenda
{
    public class Produto
    {
        private int codigo;
        //Tipo string definido na pág 11
        private string nome;
        private string descricao;
        private double quantidade;
        private double preco;

        //Definição de propriedades na pág. 47
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }

        }
        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }

        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }

        }

        public ArrayList listar(string _n)
      {
            ArrayList arr = new ArrayList();
            //Técnica para evitar SQL Injection
            //Ideal é separar classe de banco de dados do modelo
            string sql = "SELECT * FROM Produtos where nome like " +
                "@nome";
            MySqlCommand commS = new MySqlCommand
                (sql, Conn.mConn);
            // adiciona-se o parametro, indicando o nome e o tipo
            commS.Parameters.Add("@nome", MySqlDbType.VarChar);

            // atribui-se o respectivo valor
            commS.Parameters["@nome"].Value = _n;
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    Produto p = new Produto();
                    p.Nome = dt.Rows[i][1].ToString();
                    p.Codigo = int.Parse(dt.Rows[i][0].ToString());
                    p.descricao = dt.Rows[i][2].ToString();
                    //p.quantidade = double.Parse(dt.Rows[i][3].ToString());
                    //Armazenará a quantidade de produto selecionada pelo user
                    p.quantidade = 0;
                    p.Preco = double.Parse(dt.Rows[i][4].ToString());
                    arr.Add(p);
                    i++;
                }
            }
            return arr;
        }
        public void Salvar()
        {
            //Formatar numero decimal e salvar corretamente no BD
            NumberFormatInfo numberFormat = new NumberFormatInfo();
            numberFormat.NumberGroupSeparator = ".";

            string sql = "INSERT INTO produtos VALUES( null,'" + 
                nome + "','" + 
                descricao + "'," + quantidade.ToString(numberFormat) +
                    "," + preco.ToString(numberFormat) + ")";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            //Tratamento de exceção
            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
