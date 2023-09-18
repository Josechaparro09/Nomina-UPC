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
    public partial class frRegistro : Form
    {
        ServicioCatedratico servicioCatedratico = new ServicioCatedratico();
        ServicioOcasionales ServicioOcasionales = new ServicioOcasionales();
        public frRegistro()
        {
            
            InitializeComponent();
            cbOcasional.Enabled = false;
            txtHora.Enabled = false;
            txtValor.Enabled = false;
            txtId.MaxLength = 10;
            txtPhone.MaxLength = 10;

            cbPosgrado.Items.Add("Especializacion");
            cbPosgrado.Items.Add("Maestria");
            cbPosgrado.Items.Add("Doctorado");
            cbPosgrado.Items.Add("Postdoctorado");

            cbSemillero.Items.Add("A1");
            cbSemillero.Items.Add("B");
            cbSemillero.Items.Add("C");
            cbSemillero.Items.Add("Reconocidos por Colciencias");
            cbSemillero.Items.Add("Semillero");
        }
        void GenerarProfesores(int numOcasionales , int numCatedraticos)
        {
            var gen = new Generador();
            for (int i = 0; i < numOcasionales; i++)
            {
                var oc = new Ocasional();

                oc.Identificacion = gen.GenerarCedula();
                oc.Nombres = gen.GenerarNombre();
                oc.Apellidos = gen.GenerarApellido();
                oc.Correo = gen.GenerarCorreo(oc.Nombres , oc.Apellidos);
                oc.Telefono = gen.GenerarTelefono();
                oc.Posgrado = gen.GenerarPostgrado();
                oc.Semillero = gen.GenerarSemillero();
                oc.Time = gen.GenerarTiempo();

                var mensaje1 = ServicioOcasionales.Save(oc);
                var mensaje3 = ServicioOcasionales.CalcularSalario(oc);
            }
            for (int i = 0; i < numCatedraticos; i++)
            {
                int hMin=0, hMax=0;
                double vMin = 0 , vMax = 0;
                var cate = new Catedratico();
                cate.Identificacion = gen.GenerarCedula();
                cate.Nombres = gen.GenerarNombre() ;
                cate.Apellidos = gen.GenerarApellido();
                cate.Correo = gen.GenerarCorreo(cate.Nombres,cate.Apellidos);
                cate.Telefono = gen.GenerarTelefono();
                cate.Posgrado = gen.GenerarPostgrado();
                cate.Semillero = gen.GenerarSemillero();

                cate.NumHoras = gen.GenerarRango(hMin,hMax);
                cate.ValorHoras = gen.GenerarRango((int)vMin,(int) vMax);

                var mensaje2 = servicioCatedratico.CalcularSalario(cate);
                var mensaje = servicioCatedratico.Save(cate);

            }
        }
        void Guardar()
        {
            if (txtId.Text == "" || txtName.Text == "" || txtLName.Text == "" || txtEmail.Text == "" || txtPhone.Text == ""
                || cbPosgrado.Text == "" || cbSemillero.Text == "" || rdOcasional.Checked == false && rdCatedraticos.Checked == false)
            {
                MessageBox.Show("FALTAN DATOS POR COMPLETAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    Profesor profesor = new Profesor();
                    profesor.Identificacion = int.Parse(txtId.Text);
                    profesor.Nombres = txtName.Text;
                    profesor.Apellidos = txtLName.Text;
                    profesor.Correo = txtEmail.Text;
                    profesor.Telefono = int.Parse(txtPhone.Text);
                    profesor.Posgrado = cbPosgrado.SelectedItem.ToString();
                    profesor.Semillero = cbSemillero.SelectedItem.ToString();


                    if (rdOcasional.Checked == true)
                    {
                        Ocasional ocasionales = new Ocasional();

                        ocasionales.Identificacion = profesor.Identificacion;
                        ocasionales.Nombres = profesor.Nombres;
                        ocasionales.Apellidos = profesor.Apellidos;
                        ocasionales.Correo = profesor.Correo;
                        ocasionales.Telefono = profesor.Telefono;
                        ocasionales.Posgrado = profesor.Posgrado;
                        ocasionales.Semillero = profesor.Semillero;
                        ocasionales.Time = cbOcasional.SelectedItem.ToString();

                        var mensaje3 = ServicioOcasionales.CalcularSalario(ocasionales);
                        var mensaje1 = ServicioOcasionales.Save(ocasionales);
                        
                        MessageBox.Show(mensaje1.ToUpper(), "Regristro Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(mensaje3.ToString(), "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Catedratico catedraticos = new Catedratico();
                        

                        catedraticos.Identificacion = profesor.Identificacion;
                        catedraticos.Nombres = profesor.Nombres;
                        catedraticos.Apellidos = profesor.Apellidos;
                        catedraticos.Correo = profesor.Correo;
                        catedraticos.Telefono = profesor.Telefono;
                        catedraticos.Posgrado = profesor.Posgrado;
                        catedraticos.Semillero = profesor.Semillero;

                        catedraticos.NumHoras = int.Parse(txtHora.Text);
                        catedraticos.ValorHoras = double.Parse(txtValor.Text);

                        var mensaje2 = servicioCatedratico.CalcularSalario(catedraticos);
                        var mensaje = servicioCatedratico.Save(catedraticos);
                        
                        MessageBox.Show(mensaje.ToUpper(), "Regristro Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(mensaje2.ToString(), "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtHora.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtName.Text = string.Empty;
            txtLName.Text = string.Empty;
            cbOcasional.SelectedIndex = -1;
            cbPosgrado.SelectedIndex = -1;
            cbSemillero.SelectedIndex = -1;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
            btnCalcular.Enabled = true;
            LimpiarCampos();
            
        }

        private void rdOcasional_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOcasional.Checked == true)
            {
                cbOcasional.Enabled = true;
                cbOcasional.Items.Add("Auxiliar de tiempo completo");
                cbOcasional.Items.Add("Auxiliar de medio tiempo");
                cbOcasional.Items.Add("Asistente de tiempo completo");
                cbOcasional.Items.Add("Asistente de medio tiempo");
                cbOcasional.Items.Add("Asociacion de tiempo completo");
                cbOcasional.Items.Add("Asociacion de medio tiempo");
                cbOcasional.Items.Add("Titular de tiempo completo");
                cbOcasional.Items.Add("Titular de medio tiempo");
            }
            else
            {
                cbOcasional.Enabled = false;
                cbOcasional.SelectedIndex = -1;
            }
            
        }

        private void rdCatedraticos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCatedraticos.Checked == true)
            {
                txtHora.Enabled = true; txtValor.Enabled = true;
            }
            else
            {
                txtHora.Enabled = false; txtValor.Enabled = false;
                txtHora.Clear(); txtValor.Clear();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fNominas = new VistaUI();
            fNominas.Show();
        }

        private void cbOcasional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
