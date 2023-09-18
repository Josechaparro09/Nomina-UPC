using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ocasional : Profesor
    {

        public string Time { get; set; }
        public override string ToString()
        {
            return $"{Identificacion};{Nombres};{Apellidos};{Correo};{Telefono}" +
                $";{Posgrado};{Semillero};{Time};{Nomina}";
        }
    }
}
