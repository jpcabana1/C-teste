using ClienteCS.Layers.Dados;

namespace ClienteCS.Layers.Banco
{
    class FacBanco
    {

        public IBanco GerarBanco(string TipoBanco)
        {
            switch (TipoBanco)
            {
                case "SQLserver":
                    return new SQLserver();
                default:
                    break;
            }
            return null;
        }
    }
}
