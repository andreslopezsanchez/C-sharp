using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisColecciones;

namespace Ejercicio2_B1_C
/*  Deberás crear un programa principal que te permita probar la lista a través de la clase
    Fecha (puedes reutilizar el código de ejercicios anteriores), que estará en un fichero
    llamado Fecha.cs.

    Con este programa podremos gestionar fechas que estarán contenidas en la lista.
    Hay que tener en cuenta que la clase Fecha heredará de los interfaces ya definidos en C#
    como son: IComparable<T> e IClonable la implementación de estos interfaces será la
    que utilicemos dentro de la lista para insertar un dato ordenado, buscar un dato y Clonar
    una lista.
*/
{

    class Fecha: IComparable<Fecha>, ICloneable
    {
        private uint year;
        private uint mes;
        private uint dia;


        public Fecha(uint dia, uint mes, uint year)
        {
            this.year = year;
            this.mes = mes;
            this.dia = dia;
        }

        public object Clone()
        {
            return new Fecha(this.dia, this.mes, this.year);
        }

        public int CompareTo(Fecha other)
        {
            if (year > other.year)
            {
                return 1;
            }
            else if (year < other.year)
            {
                return -1;
            }
            else
            {
                if (mes > other.mes)
                {
                    return 1;
                }
                else if (mes < other.mes)
                {
                    return -1;
                }
                else
                {
                    if (dia > other.dia)
                    {
                        return 1;
                    }                        
                    else if (dia < other.dia)
                    {
                        return -1;
                    }                        
                    else
                    {
                        return 0;
                    }
                        
                }
            }

        }

        public override string ToString()
        {
            return $"{dia}/{mes}/{year}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Lista<Fecha> lista = new Lista<Fecha>();
                Lista<Fecha> lista2 = new Lista<Fecha>();

                Fecha f1 = new Fecha(3, 12, 1993);
                Fecha f2 = new Fecha(3, 5, 1988);
                Fecha f3 = new Fecha(3, 6, 1988);
                Nodo<Fecha> nodoFecha = new Nodo<Fecha>(f1, null, null);

                #region Inserta
                Console.WriteLine("\nInsertando...");
                lista.InsertaAlPrincipio(f1);
                Console.WriteLine(lista);

                lista.InsertaAlFinal(f2);
                Console.WriteLine(lista);

                lista.InsertaAntes(2, new Fecha(4, 7, 1990));
                Console.WriteLine(lista);

                lista.InsertaDespues(3, new Fecha(3, 12, 1960));
                Console.WriteLine(lista);

                #endregion

                #region Borra
                //Console.WriteLine("\nBorrando...");
                //lista.BorraAlPrincipio();
                //Console.WriteLine(lista);

                //lista.Borra(2);
                //Console.WriteLine(lista);

                //lista.BorraAlFinal();
                //Console.WriteLine(lista);

                #endregion

                #region Clonar Lista en profundidad

                Console.WriteLine("\nClonando...");
                lista2 = (Lista<Fecha>)lista.Clone();
                Console.WriteLine(lista2);

                #endregion

                #region Comparando Listas 

                Console.WriteLine("\nComparando Listas...");

                if (lista.CompareTo(lista2) > 0)
                {
                    Console.WriteLine($"{lista} \nes mayor que \n{lista2}");
                }
                else if (lista.CompareTo(lista2) < 0)
                    Console.WriteLine($"{lista} \nes menor que \n{lista2}");
                else
                    Console.WriteLine($"son iguales");
                #endregion

                #region Buscando Fecha

                //Console.WriteLine("\nBuscando Fecha...");
                //if (lista.Busca(f3, out nodoFecha))
                //    Console.WriteLine("lo hemos encontrado");
                //else
                //    Console.WriteLine("no lo hemos encontrado");

                #endregion

                #region EstaOrdenada e InsertaOrdenado

                Console.WriteLine("\nEsta ordenada la lista?...");
                if (lista.EstaOrdenada())
                    Console.WriteLine("esta ordenada");
                else
                    Console.WriteLine("no esta ordenada");

                Console.WriteLine("\nInsertando fecha ordenada...");
                lista.InsertaOrdenado(new Fecha(2, 6, 1991));
                Console.WriteLine(lista);

                #endregion

                #region Comparando Fechas

                //Console.WriteLine("\nComparando Fechas...");
                //if (f1.CompareTo(f2) > 0)
                //    Console.WriteLine($"{f1} es mayor que {f2}");
                //else if (f1.CompareTo(f2) < 0)
                //    Console.WriteLine($"{f1} es menor que {f2}");
                //else
                //    Console.WriteLine($"son iguales");

                #endregion

                #region Clonando Fechas 
                Console.WriteLine("\nClonando Fechas...");
                Fecha f4 = (Fecha)f3.Clone();
                Console.WriteLine($"{f3} ---> {f4}");
                #endregion

                #region Recorre Lista (Foreach)

                //Console.WriteLine("\nRecorriendo Lista y mostrando Fechas...");
                //foreach (Fecha i in lista)
                //{
                //    Console.WriteLine(i);
                //}

                #endregion
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
