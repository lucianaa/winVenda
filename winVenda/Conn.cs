using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Resources;
using System.Globalization;
using winVenda.Properties;
using System.Reflection;

namespace winVenda
{
    /// <summary>
    /// Classe responsável pela conexão com o banco de dados
    /// </summary>
    public class Conn
    {
        public static MySqlConnection mConn;
        //buscar das variaveis de programa
        static string connectionstring = "server=localhost;database=poo;" +
            "uid=root; pwd=''";

        public static void Conectar()
        {
            try
            {
                mConn = new MySqlConnection(connectionstring);
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



    }
}
