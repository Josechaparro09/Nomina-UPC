using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {

        protected string ruta = "nomina.txt";

        public Archivo(string ruta)
        {
            this.ruta = ruta;
        }

        public Archivo()
        {

        }

        public string Guardar(Profesor profesor)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(profesor.ToString());
                sw.Close();

                return $"Profesor registrado con el nombre de {profesor.Nombres}";
            }
            catch (Exception ex)
            {

                return $"Error al registrar la informacion";
            }


        }
    }
}
