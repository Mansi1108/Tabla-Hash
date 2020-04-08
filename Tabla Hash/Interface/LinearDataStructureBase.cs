using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Tabla_Hash.Estructuras;

namespace Tabla_Hash.Interface
{
    public abstract class LinearDataStructureBase<T> where T : IComparable<T>
    {
        protected abstract Nodo<T> Insert(Nodo<T> nodo);
        protected abstract void Delete(Nodo<T> nodo);
        protected abstract Nodo<T> Get(Nodo<T> nodo);
    }
}
