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
        private static int size = 10;
        List<T>[] TH = new List<T>[size];
        string s;

        protected override Nodo<T> Delete()
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
        
        static int HashingF(List<T> [] values, string llave)
        {
            int total = 0;
            char[] c;
            c = llave.ToCharArray();
            for (int i = 0; i <= c.GetUpperBound(0); i++)
                total += (int)c[i];

            return total % values.GetUpperBound(0);
        }
    }
}
