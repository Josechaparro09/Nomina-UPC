using Entidades;
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
    public partial class GeneradorUI : Form
    {
        ServicioCatedratico servicioCatedratico = new ServicioCatedratico();
        ServicioOcasionales ServicioOcasionales = new ServicioOcasionales();
        public GeneradorUI()
        {
            InitializeComponent();
        }
        bool IsEmpty()
        {
            if (txtNCate.Text==""|| txthMax.Text==""||txtHMin.Text==""||txtNOca.Text==""||nudMax.Value==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        void GenerarProfesores(int numOcasionales, int numCatedraticos)
        {
            var gen = new Generador();
            for (int i = 0; i < numOcasionales; i++)
            {
                var oc = new Ocasional();

                oc.Identificacion = gen.GenerarCedula();
                oc.Nombres = gen.GenerarNombre();
                oc.Apellidos = gen.GenerarApellido();
                oc.Correo = gen.GenerarCorreo(oc.Nombres, oc.Apellidos);
                oc.Telefono = gen.GenerarTelefono();
                oc.Posgrado = gen.GenerarPostgrado();
                oc.Semillero = gen.GenerarSemillero();
                oc.Time = gen.GenerarTiempo();

                var mensaje3 = ServicioOcasionales.CalcularSalario(oc);
                var mensaje1 = ServicioOcasionales.Save(oc);
            }
            for (int i = 0; i < numCatedraticos; i++)
            {
                int hMin = (int)nudMin.Value, hMax = (int)nudMax.Value ;
                double vMin = double.Parse(txtHMin.Text), vMax = double.Parse(txthMax.Text);
                var cate = new Catedratico();
                cate.Identificacion = gen.GenerarCedula();
                cate.Nombres = gen.GenerarNombre();
                cate.Apellidos = gen.GenerarApellido();
                cate.Correo = gen.GenerarCorreo(cate.Nombres, cate.Apellidos);
                cate.Telefono = gen.GenerarTelefono();
                cate.Posgrado = gen.GenerarPostgrado();
                cate.Semillero = gen.GenerarSemillero();

                cate.NumHoras = gen.GenerarRango(hMin, hMax);
                cate.ValorHoras = gen.GenerarRango((int)vMin, (int)vMax);

                var mensaje2 = servicioCatedratico.CalcularSalario(cate);
                var mensaje = servicioCatedratico.Save(cate);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Verifique que los campos no esten vacios");
            }
            else
            {
                GenerarProfesores(int.Parse(txtNOca.Text), int.Parse(txtNCate.Text));
                MessageBox.Show("Profesores generados correctamente");
            }
            var fVista = new VistaUI();
            fVista.ShowDialog();
        }
    }
}
