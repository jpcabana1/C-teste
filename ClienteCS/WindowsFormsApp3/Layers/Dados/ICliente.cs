using System.Data;

namespace ClienteCS.Layers.Dados
{
    interface ICliente
    {
        void Conectar();
        void Desconectar();
        void Executar(string comando);
        DataSet Executar();
    }
}
