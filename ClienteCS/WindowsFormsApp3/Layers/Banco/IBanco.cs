using System.Data;
using System.Data.SqlClient;

namespace ClienteCS.Layers.Dados
{
    interface IBanco
    { 
        //Usar para Inserts, Updates e Remove
        void ExecutarComando(string comando);
        //Usar para select
        DataTable ExecutarSelect(string comando);

    }
}
