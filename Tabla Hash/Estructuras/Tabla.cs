using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Tabla_Hash.Interface;
using System.Collections;


namespace Tabla_Hash.Estructuras
{
    public class Tabla<T> : LinearDataStructureBase<T> where T : IComparable<T>
    {
        private Nodo<T> key = new Nodo<T>();

        public void Add(T value)
        {
            
        }


        protected override void  Delete(Nodo<T> nodo)
        {
            
        }

        protected override Nodo<T> Get(Nodo<T> nodo)
        {
            throw new NotImplementedException();
        }
        protected override Nodo<T> Insert(Nodo<T> nodo)
        {
            throw new NotImplementedException();
        }
    }
}
