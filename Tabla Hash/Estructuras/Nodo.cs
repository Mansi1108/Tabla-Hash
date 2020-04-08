using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tabla_Hash.Estructuras
{
    public class Nodo<T> where T : IComparable<T>, IFormattable
    {
        public T Value { get; set; }

    }
}
