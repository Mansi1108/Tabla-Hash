using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Tabla_Hash.Estructuras;

namespace Tabla_Hash.Interface
{
    public abstract class LinearDataStructureBase<T> where T : IComparable<T>, IFormattable
    {
        protected abstract void Insert(T Value);
        protected abstract void Delete(Nodo<T> nodo);
        protected abstract T Get();
    }
}
