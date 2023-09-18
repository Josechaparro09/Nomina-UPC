using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Interface1<T>
    {
        string Save(T profesor);
        List<T> GetAll();
        double CalcularSalario(T profesor);
    }
}
