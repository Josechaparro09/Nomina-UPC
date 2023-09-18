using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VistaUI : Form
    {
        ServicioCatedratico sCate = new ServicioCatedratico();
        ServicioOcasionales sOca = new ServicioOcasionales();
        public VistaUI()
        {
            
            InitializeComponent();
            ListarCate();
            ListarOca();
            CalcularNominas();
        }
        void ListarCate()
        {
            tbPCate.Rows.Clear();
            var lista = sCate.GetAll();
            if (lista!=null)
            {
                foreach (var prof in lista)
                {
                    tbPCate.Rows.Add(prof.Identificacion, prof.Nombres + " " + prof.Apellidos, prof.Correo, prof.Telefono, prof.Posgrado, prof.Semillero, prof.NumHoras, prof.ValorHoras, prof.Nomina);
                }
            }
            //tbPCate.DataSource = lista;
            
        }
        void CalcularNominas()
        {
            var nomina = sCate.CalcularNomina();
            nomina = sOca.CalcularNomina();
            lblNomina.Text = nomina.ToString();
        }
        void ListarOca()
        {
            tbPOca.Rows.Clear();
            var lista = sOca.GetAll();
            //tbPCate.DataSource = lista;
            if (lista != null)
            {
                foreach (var prof in lista)
                {
                    tbPOca.Rows.Add(prof.Identificacion, prof.Nombres + " " + prof.Apellidos, prof.Correo, prof.Telefono, prof.Posgrado, prof.Semillero, prof.Time, prof.Nomina);
                }
            }
            
        }

        private void tbPCate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VistaUI_Load(object sender, EventArgs e)
        {

        }
    }
}
