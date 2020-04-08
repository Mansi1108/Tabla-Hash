using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tabla_Hash.Estructuras
{
    public class Nodo<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public T Key { get; set; }
    }
}
