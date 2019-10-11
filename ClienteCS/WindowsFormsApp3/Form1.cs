using System;
using ClienteCS.Model;
using System.Windows.Forms;
using ClienteCS.Layers.Controller;
using System.Collections.Generic;

namespace ClienteCS
{
    public partial class Form1 : Form
    {

        private cCliente ClienteController;

        public Form1()
        {
            InitializeComponent();
            ClienteController = new cCliente();
        }

        private void btnTesteCon_Click(object sender, EventArgs e)
        {       
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<mCliente> ListaTabela;
            Filtros filtros;
            mCliente mCliente;
            try
            {
                filtros = new Filtros();
                mCliente = new mCliente();
                ListaTabela = ClienteController.Consulta(mCliente, filtros);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
