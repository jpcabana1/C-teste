using ClienteCS.Layers.Dados;
using ClienteCS.Model;
using System;
using System.Collections.Generic;

namespace ClienteCS.Layers.Controller
{
    class cCliente
    {
        RepoCliente ObjDados;

        public cCliente()
        {
            ObjDados = new RepoCliente();
        }

        public List<mCliente> Consulta(mCliente p_obj, Filtros objFiltro)
        {
            try
            {
                return ObjDados.Consulta(p_obj, objFiltro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
