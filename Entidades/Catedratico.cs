using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Catedratico : Profesor
    {

        public int NumHoras { get; set; }
        public double ValorHoras { get; set; }

        public override string ToString()
        {
            return $"{Identificacion};{Nombres};{Apellidos};{Correo};{Telefono}" +
                $";{Posgrado};{Semillero};{NumHoras};{ValorHoras};{Nomina}";
        }

    }
}
