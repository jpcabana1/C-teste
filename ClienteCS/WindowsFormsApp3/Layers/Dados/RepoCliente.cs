using System.Collections.Generic;
using ClienteCS.Model;
using System;
using ClienteCS.Layers.Banco;
using System.Data;
using System.Linq;

namespace ClienteCS.Layers.Dados
{
    class RepoCliente : ICliente
    {
        IBanco Dados;
        FacBanco FBanco;

        public RepoCliente(string banco)
        {
            FBanco = new FacBanco();
            Dados = FBanco.GerarBanco(banco);
        }

        public List<mCliente> Consulta(mCliente mCliente, Filtros ObjFiltros)
        {
            List<mCliente> retorno;
            string comando;

            try
            {
                comando = "SELECT * FROM TBLCI";

                retorno =  MontaRetorno(Dados.ExecutarSelect(comando));

                return retorno;
            }
            catch (Exception ex)
            {     
                throw ex;
            }
        }

        public void Insert(mCliente mCliente)
        {
            throw new System.NotImplementedException();
        }

        public List<mCliente> MontaRetorno(DataTable dataTable)
        {
            List<mCliente> ret;

            try
            {
                ret = new List<mCliente>();

                return ret;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Remove(mCliente mCliente)
        {
            throw new System.NotImplementedException();
        }
        public void Update(mCliente mCliente)
        {
            throw new System.NotImplementedException();
        }
    }
}
