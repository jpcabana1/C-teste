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

        public DataTable ExecutarSelect(string comando)
        {
            string DataSource = "Data Source=192.168.159.200,1433;";
            string InitialCatalog = "Initial Catalog=security_recife2;";
            string IntegratedSecurity = "Integrated Security = true;";
            string UserID = "User ID=adapta;";
            string Password = "Password=safaribaiao";
            SqlConnection Connection;
            SqlCommand Command;
            SqlDataAdapter Adapter;
            DataTable Retorno;

            try
            {

                Connection = new SqlConnection();
                Command = new SqlCommand();
                
                Connection.ConnectionString = DataSource + InitialCatalog + IntegratedSecurity + UserID + Password;
                Command.Connection = Connection;
                Command.CommandText = comando;
                Retorno = new DataTable();
                Adapter = new SqlDataAdapter(Command);
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
