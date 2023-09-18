using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioOcasionales : Interface1<Ocasional>
    {
        RepositorioOcasional repositorioOcasional = new RepositorioOcasional("ocacionales.txt");
        List<Ocasional> ocasionals;
        public List<Ocasional> GetAll()
        {
            return repositorioOcasional.ConsultarTodos();

        }

        public string Save(Ocasional profesor)
        {
            try
                {
                    if (profesor == null) { return $"Error al guardar el contacto ..."; }

                var respuesta = repositorioOcasional.Guardar(profesor);

                return $"Guardado correctamente";

            }
            catch (Exception)
            {
                return $"No se guardó";
            }
        }
        public double CalcularSalario(Ocasional profesor)
        {
            double salarioBase = 0;
            switch (profesor.Time)
            {
                case "Auxiliar de tiempo completo":
                    salarioBase = 2645000;
                    break;
                case "Auxiliar de medio tiempo":
                    salarioBase = 1509000;
                    break;
                case "Asistente de tiempo completo":
                    salarioBase = 3125000;
                    break;
                case "Asistente de medio tiempo":
                    salarioBase = 1749000;
                    break;
                case "Asociado de tiempo completo":
                    salarioBase = 3606000;
                    break;
                case "Asociado de medio tiempo":
                    salarioBase = 1990000;
                    break;
                case "Titular de tiempo completo":
                    salarioBase = 3918000;
                    break;
                case "Titular de medio tiempo":
                    salarioBase = 2146000;
                    break;
            }
            double salarioconPosgrado = salarioBase;
            switch (profesor.Posgrado)
            {
                case "Especializacion":
                    salarioconPosgrado *= 0.10;
                    break;
                case "Maestria":
                    salarioconPosgrado *= 0.45;
                    break;
                case "Doctorado":
                    salarioconPosgrado *= 0.90;
                    break;
                case "Postdoctorado":
                    salarioconPosgrado *= 0;
                    break;
            }
            double salarioSemillero = salarioBase;
            switch (profesor.Semillero)
            {
                case "A1":
                    salarioSemillero *= 0.56;
                    break;
                case "A":
                    salarioSemillero *= 0.47;
                    break;
                case "B":
                    salarioSemillero *= 0.42;
                    break;
                case "C":
                    salarioSemillero *= 0.38;
                    break;
                case "Reconocido por colciencias":
                    salarioSemillero *= 0.33;
                    break;
                case "Semillero":
                    salarioSemillero *= 0.19;
                    break;
            }
            double salud = salarioBase;
            salud *= 0.04;
            double pension = salarioBase;
            pension *= 0.04;
            double salarioTotalOcasional = +salarioBase + salarioconPosgrado + salarioSemillero - salud - pension;
            profesor.Nomina = salarioTotalOcasional;
            return profesor.Nomina;
        }
        public double CalcularNomina()
        {
            return repositorioOcasional.CalcularNomina();
        }
    }
}
