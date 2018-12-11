using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_B2_C
{
   
    class ColaVinculada<T> : IEnumerable<T>
    {
     
        private LinkedList<T> lista;
         
        public bool Vacia
        {
            get
            {
                return lista.First == null;
            }
        }
        public int Elementos
        {
            get
            {
                return lista.Count;
            }
        }

        public ColaVinculada()
        {
            
            lista = new LinkedList<T>();
            
        }
        public ColaVinculada(IEnumerable<T> coleccion)
        {
            lista = new LinkedList<T>(coleccion);
          
        }
        
        public void Encola(T dato)
        {       
            lista.AddLast(dato);           
        }
        public T Desencola()
        {
            T datoDesencolado;
            if (!Vacia)
            {
                datoDesencolado= lista.First.Value;
                lista.RemoveFirst();                
            }
            else
                throw new Exception("La cola esta vacía");            

            return datoDesencolado;
        }
        public T Peek()
        {
            T puntero;
            if(!Vacia)
               puntero = lista.First.Value;
            else
                throw new Exception("La cola esta vacía");

            return puntero;                
        }        

        public IEnumerator<T> GetEnumerator()
        {
            return new EnumeratorPila(lista);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class EnumeratorPila : IEnumerator<T>
        {
            LinkedListNode<T> nodoIterador;
            LinkedList<T> lista;
           

            public EnumeratorPila(LinkedList<T> lista)
            {
                this.lista = lista;  
            }
            public T Current
            {
                get
                {
                    return nodoIterador.Value;
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
                lista = null;
                nodoIterador = null;
            }

            public bool MoveNext()
            {

                bool seMueve;
                if (lista.Last!=null)
                {
                    if (nodoIterador==null)
                    {
                        nodoIterador = lista.First;
                        seMueve = true;
                    }
                    else
                    {
                        if (nodoIterador.Next != null)
                        {
                            nodoIterador = nodoIterador.Next;
                            seMueve = true;
                        }
                        else
                            seMueve = false;
                    }                    
                }
                else
                {
                    seMueve = false;
                }

                return seMueve;
            }
            public void Reset()
            {
               nodoIterador=null;
            }
        }
    }
}
