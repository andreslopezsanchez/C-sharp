using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisColecciones
{
    public class Nodo<T> : IDisposable where T : IComparable<T>, ICloneable
    {
       private T dato;
       private Nodo<T> next;
       private Nodo<T> prev;

        public Nodo(T dato, Nodo<T> next, Nodo<T> prev)
        {
            this.dato = dato;
            this.next = next;
            this.prev = prev;
        }

        public T Dato
        {
            get
            {
                return dato;
            }

            set
            {
                dato = value;
            }
        }

        public Nodo<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Nodo<T> Prev
        {
            get
            {
                return prev;
            }

            set
            {
                prev = value;
            }
        }

        public void Dispose()
        {
            dato = default(T);
            next = null;
            prev = null;

            GC.Collect();
        }
      
        public override string ToString()
        {
            return $"{Dato}";
        }

    }
}
