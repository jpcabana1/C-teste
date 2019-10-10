using System.Data;
using ClienteCS.Layers.Dados;
using System.Data.SqlClient;
using System;

namespace ClienteCS.Layers.Banco
{
    class SQLite : IBanco
    {
        public void ExecutarComando(string comando)
        {
            throw new NotImplementedException();
        }

        public DataTable ExecutarSelect(string comando)
        {
            throw new NotImplementedException();
        }
    }
}
