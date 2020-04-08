using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Tabla_Hash.Interface;
using System.Collections;


namespace Tabla_Hash.Estructuras
{
    public class Tabla<T> : LinearDataStructureBase<T> where T : IComparable<T>, IFormattable
    {
        protected override void Delete(T Value)
        {
            throw new NotImplementedException();
        }

        protected override T Get()
        {
            throw new NotImplementedException();
        }

        protected override void Insert(T Value)
        {
            throw new NotImplementedException();
        }
    }
}
