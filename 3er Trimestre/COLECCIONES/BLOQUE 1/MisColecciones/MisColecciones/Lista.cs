using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisColecciones
{
    public class Lista<T> : IDisposable, ICloneable, IComparable<Lista<T>>, IEnumerable<T> where T : IComparable<T>, ICloneable
    {
        private Nodo<T> first;
        private Nodo<T> last;
        private int elements;

        public int Elements
        {
            get
            {
                return elements;
            }

            set
            {
                elements = value;
            }
        }

        public Lista()
        {
            first = null;
            last = null;
            elements = 0;
        }

        public Nodo<T> this[int posicionNodo]
        {
            get
            {
                int contador = 0;
                Nodo<T> nodoADevolver = null;

                for (Nodo<T> it = first; it != null; it = it.Next)
                {
                    if (contador == posicionNodo)
                    {
                        nodoADevolver = it;
                    }
                    contador++;
                }
                if (nodoADevolver != null)
                {
                    return nodoADevolver;
                }
                else
                {
                    throw new Exception("El numero de nodo buscado no existe");
                }
            }
        }


        public void InsertaAlFinal(T dato)
        {
            if (first == null)
            {
                first = new Nodo<T>(dato, null, null);
                last = first;
            }
            else
            {
                Nodo<T> lastAux = new Nodo<T>(dato, null, last);
                last.Next = lastAux;
                last = lastAux;
            }
            elements++;
        }
        public void InsertaAlPrincipio(T dato)
        {
            if (first == null)
            {
                first = new Nodo<T>(dato, null, null);
                last = first;
            }
            else
            {
                Nodo<T> firstAux = new Nodo<T>(dato, first, null);
                first.Prev = firstAux;
                first = firstAux;
            }
            elements++;
        }
        public void InsertaAntes(int posicionNodo, T dato)
        {
            InsertaAntes(this[posicionNodo - 1], dato);
        }
        public void InsertaDespues(int posicionNodo, T dato)
        {
            InsertaDespues(this[posicionNodo - 1], dato);

            
        }
        public void InsertaAntes(Nodo<T> nEncontrado, T dato)
        {
            if (nEncontrado == first)
            {
                InsertaAlPrincipio(dato);
            }
            else
            {
                Nodo<T> nAux = new Nodo<T>(dato, nEncontrado, nEncontrado.Prev);

                nEncontrado.Prev.Next = nAux;
                nEncontrado.Prev = nAux;
                elements++;
            }

           
        }
        public void InsertaDespues(Nodo<T> nEncontrado, T dato)
        {

            if (nEncontrado == last)
            {
                InsertaAlFinal(dato);
            }
            else
            {
                Nodo<T> nAux = new Nodo<T>(dato, nEncontrado.Next, nEncontrado);

                nEncontrado.Next.Prev = nAux;
                nEncontrado.Next = nAux;
                elements++;
            }

            
        }

        public bool EstaOrdenada()
        {
            bool ordenada = true;

            if (elements >= 2)
            {
                for (Nodo<T> itThis = first;
                     itThis != null;
                     itThis = itThis.Next)
                {
                    if (itThis.Next != null)
                    {
                        if (itThis.Dato.CompareTo(itThis.Next.Dato) > 0)
                        {
                            ordenada = false;
                            break;
                        }
                    }
                }
            }

            return ordenada;
        }

        public void InsertaOrdenado(T dato)
        {
            if (!EstaOrdenada())
                throw new Exception("Lista no ordenada");
            else
            {
                Console.WriteLine("insertando...");
                for (Nodo<T> it = first; it != null; it = it.Next)
                {
                    if (it.Dato.CompareTo(dato) > 0)
                    {
                        InsertaAntes(it, dato);
                        break;
                    }
                    else if (last.Dato.CompareTo(dato) < 0)
                    {
                        InsertaAlFinal(dato);
                    }
                }
            }
        }

        public void Borra(int posicionNodo)
        {
            Borra(this[posicionNodo - 1]);
        }
        public void Borra(Nodo<T> nodoEncontrado)
        {
            if (nodoEncontrado == first)
            {

                nodoEncontrado.Next.Prev = null;
                nodoEncontrado.Next = first;

            }

            else if (nodoEncontrado == last)
                nodoEncontrado.Prev.Next = null;


            else
            {
                nodoEncontrado.Prev.Next = nodoEncontrado.Next;
                nodoEncontrado.Next.Prev = nodoEncontrado.Prev;
            }

            nodoEncontrado.Dispose();

            elements--;
        }
        public void BorraAlFinal()
        {
            Borra(elements - 1);
        }
        public void BorraAlPrincipio()
        {
            const int PRINCIPIO_LISTA = 1;
            Borra(PRINCIPIO_LISTA);
        }

        public bool Busca(T dato, out Nodo<T> nodoConDato)
        {

            if (first == null)
                throw new Exception("No puedes Buscar en una lista vacía");

            bool encontrado = false;
            nodoConDato = null;

            for (Nodo<T> it = first; it != null; it = it.Next)
            {
                if (dato.CompareTo(it.Dato) == 0)
                {
                    encontrado = true;
                    nodoConDato = it;
                    break;
                }
            }

            return encontrado;
        }
        public object Clone()
        {
            Lista<T> lCopy = new Lista<T>();

            for (Nodo<T> it = first; it != null; it = it.Next)
            {
                    lCopy.InsertaAlFinal((T)it.Dato.Clone());
            }

            return lCopy;
        }
        public void Dispose()
        {
            for (Nodo<T> it = first; it != null; it = it.Next)
            {
                it.Dispose();
            }
            elements = 0;
        }
        public int CompareTo(Lista<T> other)
        {
            int comprobacion = 0;

            for (Nodo<T> iThis = first, iOther = other.first;
                 iThis != null && iOther != null;
                 iThis = iThis.Next, iOther = iOther.Next)
            {
                comprobacion = iThis.Dato.CompareTo(iOther.Dato);
                if (comprobacion != 0)
                {
                    break;
                }
                    
            }

            if (comprobacion == 0)
            {
                if (elements > other.elements)
                {
                    comprobacion = 1;
                }                    
                else if (elements < other.elements)
                {
                    comprobacion = -1;
                }
                    
            }

            return comprobacion;
        }

        public override string ToString()
        {
            string texto = "NULL <-->";
            int posicion = 1;

            for (Nodo<T> it = first; it != null; it = it.Next)
            {
                texto += $" P:{posicion} [{it.Dato}] <-->";
                posicion++;
            }

            texto += "NULL";
            return texto;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new EnumeratorList(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class EnumeratorList : IEnumerator<T>
        {
            Nodo<T> it;
            Lista<T> lista;

            public EnumeratorList(Lista<T> lista)
            {
                it = null;
                this.lista = lista;
            }

            public T Current
            {
                get
                {
                    return it.Dato;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
                it = null;
                lista = null;
            }

            public bool MoveNext()
            {
                bool meMuevo;

                if (lista.first == null)
                {
                    meMuevo = false;
                }
                else if (it == null)
                {
                    it = lista.first;
                    meMuevo = true;
                }
                else if (it.Next != null)
                {
                    it = it.Next;
                    meMuevo = true;
                }
                else
                {
                    meMuevo = false;
                }

                return meMuevo;
            }

            public void Reset()
            {
                it = null;
            }
        }
    }
}
