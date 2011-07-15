using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace winVenda
{
    class Fornecedor
    {
        private string nome;
        private string endereco;
        private string telefone;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public void Salvar()
        {
            //Prevenção a sql injection
            string sql = "INSERT INTO fornecedor VALUES(null, @nome, @endereco, @telefone);";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            // adiciona-se o parametro, indicando o nome e o tipo
            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            // atribui-se o respectivo valor
            commS.Parameters["@nome"].Value = nome;
            commS.Parameters.Add("@endereco", MySqlDbType.VarChar);
            commS.Parameters["@endereco"].Value = endereco;
            commS.Parameters.Add("@telefone", MySqlDbType.VarChar);
            commS.Parameters["@telefone"].Value = telefone;

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
