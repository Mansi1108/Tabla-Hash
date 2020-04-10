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
        List<T>[] TH = new List<T>[10];

        
        protected override void Delete(Nodo<T> nodo)
        {
            int i = HashingF(nodo.Value.ToString());
            foreach (var item in TH[i])
            {
                if (item.CompareTo(nodo.Value) == 0)
                {
                    TH[i].Remove(item);
                }
            }
        }

        protected override T Get()
        {
            throw new NotImplementedException();
        }

        protected override void Insert(T value)
        {
            int i = HashingF(value.ToString());
            if (TH[i] == null)
            {
                TH[i] = new List<T>();
            }
            TH[i].Add(value);

            T S;
            int code;
            for (int k = 0; k < 5; k++)
            {
                S = TH[k];
                code = HashingF(value);

                // Storing keys at their hashcode's index 
                values[hashCode] = str;
            }
        }
        
        static int HashingF(string llave)
        {
            int total = 0;
            char[] c;
            c = llave.ToCharArray();
            for (int i = 0; i <= c.Length; i++)
                total += (int)c[i];

            return total % 11;
        }
    }
}
