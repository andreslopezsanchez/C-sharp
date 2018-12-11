using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_B2_C
{
    /*  Implementa el TAD PilaVinculada<T> como envoltorio (wrapper) del tipo de las BCL
    LinkedList<T>.

    El tipo debe implementar los métodos:
        • PilaVinculada<T>()
        • PilaVinculada<T>(IEnumerable coleccion)
        • void Apila(T dato)
        • T Desapila()
        • T Peek()  
        • bool Vacía { get; }   
        • int Elementos { get; }
        • Implemente el interfaz IEnumerable<T>
            
 */
    class PilaVinculada<T> : IEnumerable<T>
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

        public PilaVinculada()
        {
            
            lista = new LinkedList<T>();
            
        }
        public PilaVinculada(IEnumerable<T> coleccion)
        {
            lista = new LinkedList<T>(coleccion);
          
        }
        
        public void Apila(T dato)
        {       
            lista.AddLast(dato);           
        }
        public T Desapila()
        {
            T datoDesapilado;
            if (!Vacia)
            {
                datoDesapilado = lista.Last.Value;
                lista.RemoveLast();
                
            }
            else
                throw new Exception("La pila esta vacía");            

            return datoDesapilado;
        }
        public T Peek()
        {
            T puntero;
            if(!Vacia)
               puntero = lista.Last.Value;
            else
                throw new Exception("La pila esta vacía");

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
                        nodoIterador = lista.Last;
                        seMueve = true;
                    }
                    else
                    {
                        if (nodoIterador.Previous != null)
                        {
                            nodoIterador = nodoIterador.Previous;
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
