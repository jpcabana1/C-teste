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

        public RepoCliente()
        {
            FBanco = new FacBanco();
            Dados = FBanco.GerarBanco("SQLserver");
        }

        public List<mCliente> Consulta(mCliente mCliente, Filtros ObjFiltros)
        {
            List<mCliente> retorno;
            string comando;

            try
            {
                comando = "SELECT TOP 10 * FROM TBCLI";

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

        public List<mCliente> MontaRetorno(DataSet dataSet)
        {
            List<mCliente> ret;
            mCliente aux;
            try
            {
                ret = new List<mCliente>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count-1; i++)
                {
                    aux = new mCliente
                    {
                        CodCliente = Convert.ToInt32(dataSet.Tables[0].Rows[i]["CODCLIENTE"]),
                        RazSocial = dataSet.Tables[0].Rows[i]["RAZSOCIAL"].ToString()
                    };
                    ret.Add(aux);
                    aux = null;
                }

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
