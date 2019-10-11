using ClienteCS.Model;
using System.Collections.Generic;
using System.Data;

namespace ClienteCS.Layers.Dados
{
    interface ICliente
    {
        void Insert(mCliente mCliente);
        void Update(mCliente mCliente);
        void Remove(mCliente mCliente);
        List<mCliente> Consulta(mCliente mCliente, Filtros ObjFiltros);
        List<mCliente> MontaRetorno(DataSet dataTable);
    }
}
