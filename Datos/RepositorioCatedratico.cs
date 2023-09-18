using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCatedratico : Archivo
    {

        public RepositorioCatedratico(string ruta) : base(ruta)
        {

        }


        public Catedratico Mappeador(String linea)
        {
            var catedraticos = new Catedratico();
            string[] aux = linea.Split(';');
            catedraticos.Identificacion = int.Parse(aux[0]);
            catedraticos.Nombres = aux[1];
            catedraticos.Apellidos = aux[2];
            catedraticos.Correo = aux[3];
            catedraticos.Telefono = int.Parse(aux[4]);
            catedraticos.Posgrado = aux[5];
            catedraticos.Semillero = aux[6];
            catedraticos.NumHoras = int.Parse(aux[7]);
            catedraticos.ValorHoras = double.Parse(aux[8]);
            catedraticos.Nomina = double.Parse(aux[9]);


            return catedraticos;
        }

        public List<Catedratico> ConsultarTodos()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Catedratico> catedraticos = new List<Catedratico>();
                while (!sr.EndOfStream)
                {
                    catedraticos.Add(Mappeador(sr.ReadLine()));
                }
                sr.Close();
                return catedraticos;
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
                foreach (var c in lista)
                {
                    nomina += c.Nomina;
                }
            }
            return nomina;
        }

    }
}
