namespace ClienteCS.Model
{
    class mCliente
    {
        public int CodCliente { get; set; }
        public string RazSocial { get; set; }

        public mCliente(int codCliente, string razSocial)
        {
            CodCliente = codCliente;
            RazSocial = razSocial;
        }
    }
}
