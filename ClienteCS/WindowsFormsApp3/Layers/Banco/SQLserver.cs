using ClienteCS.Layers.Dados;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClienteCS.Layers.Banco
{
    class SQLserver : IBanco
    {
        public void ExecutarComando(string comando)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecutarSelect(string comando)
        {
            string Server = "Server = '192.168.159.200,1433';";
            string InitialCatalog = "Initial Catalog = 'security_recife2';";
            //string IntegratedSecurity = "Integrated Security = true;";
            string UserID = "User ID = 'adapta';";
            string Password = "Password = 'safaribaiao'";
            SqlConnection Connection;
            SqlCommand Command;
            SqlDataAdapter Adapter;
            DataSet Retorno;
            string con;
            try
            {
              
                Command = new SqlCommand();
                
                con = Server + InitialCatalog + UserID + Password;
                Connection = new SqlConnection(con);
                Connection.Open();
                        
                Adapter = new SqlDataAdapter(comando, Connection);

                Retorno = new DataSet();
                Adapter.Fill(Retorno);

                return Retorno;
            }
            catch (Exception ex)
            {               
                throw ex;
            }
        }
    }
}
