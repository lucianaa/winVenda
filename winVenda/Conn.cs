using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace winVenda
{
    /// <summary>
    /// Classe responsável pela conexão com o banco de dados
    /// </summary>
    public class Conn
    {
        public static MySqlConnection mConn;
        //buscar das variaveis de programa
        static string connectionstring = "";
        MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();
  
        public String hostDB { get; set; }

        public String userDB { get; set; }

        public String passwdDB { get; set; }

        public String Database { get; set; }


        public static void Conectar()
        {
            try
            {

                mConn = new MySqlConnection(connectionstring);
                mConn.Open();
                
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public static void ExecuteNonQuery(MySqlCommand commS)
        {
            try
            {
                mConn.Open();

            }
            catch (Exception e)
            {
                throw e;
            }
            if (mConn.State == ConnectionState.Open)
            {
                /*Representa uma instrução SQL a ser executada
                 * Neste caso, o construtor recebe como parâmetro o comando SQL 
                 * e a conexão
                 */

                //Executa a SQL no banco de dados
                try
                {
                    int i = commS.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;

                }
            }

            //Fecha a conexão
            mConn.Close();
        }

        public static MySqlDataReader ExecuteQuery(MySqlCommand commS)
        {
            MySqlDataReader mReader = null;

            try
            {
                mConn.Open();

            }
            catch (Exception e)
            {
                throw e;
            }
            if (mConn.State == ConnectionState.Open)
            {

                //Executa a SQL no banco de dados
                try
                {
                    mReader = commS.ExecuteReader();

                    return mReader;

                }
                catch (MySqlException e)
                {
                    throw e;

                }

            }
            return mReader;


        }

        /// <summary>
        /// Cria uma string de conexão e retorna-o
        /// </summary>
        /// <returns>string</returns>

        public string createStringConnection()
        {
            
            myCSB.Server = this.hostDB;
            myCSB.UserID = this.userDB;
            myCSB.Password = this.passwdDB;
            myCSB.Database = this.Database;
            connectionstring = myCSB.ConnectionString;
            return myCSB.ConnectionString;

        }



    }
}
