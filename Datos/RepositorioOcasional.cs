using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioOcasional : Archivo
    {

        public RepositorioOcasional(string ruta) : base(ruta)
        {

        }


        public Ocasional Mappeador(String linea)
        {
            var ocasional = new Ocasional();
            string[] aux = linea.Split(';');
            ocasional.Identificacion = int.Parse(aux[0]);
            ocasional.Nombres = aux[1];
            ocasional.Apellidos = aux[2];
            ocasional.Correo = aux[3];
            ocasional.Telefono = int.Parse(aux[4]);
            ocasional.Posgrado = aux[5];
            ocasional.Semillero = aux[6];
            ocasional.Time = aux[7];
            ocasional.Nomina = double.Parse(aux[8]);

            return ocasional;
        }

        public List<Ocasional> ConsultarTodos()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Ocasional> ocasionales = new List<Ocasional>();
                while (!sr.EndOfStream)
                {
                    ocasionales.Add(Mappeador(sr.ReadLine()));
                }
                sr.Close();
                return ocasionales;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public double CalcularNomina()
        {
            var lista = ConsultarTodos();
            double nomina = 0;
            if (lista!=null)
            {
                foreach (var ocasional in lista)
                {
                    nomina += ocasional.Nomina;
                }
            }
            return nomina;
        }
    }
}
