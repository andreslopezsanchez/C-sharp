using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_B3_C
/*
        1. Implementa un método llamado BorraEnteros que reciba como parámetros una
        lista de enteros (que deberás crear previamente) y un número entero.
        Lo que hará será modificar la lista borrando los números que coincidan con el
        entero indicado.

        2. Implementa una función llamada Mezcla que reciba como parámetro dos listas de
        enteros (ya ordenadas), y devuelva como resultado otra lista donde se unan las
        dos anteriores, pero con los números también en orden.

        3. Implementa un método llamado ImprimeInverso que reciba como parámetros una
        lista de Personas y una posición (entero), e imprima por pantalla en orden inverso
        los nombres de las Personas de la lista desde esa posición hasta el principio.
        Utiliza una de las clases persona de otros ejercicios, o constrúyela nueva.

        4. Implementa una función llamada SumaRecursiva que reciba como parámetro un
        lista de enteros y la sume recursivamente, devolviendo el resultado final.

        5. Implementa un procedimiento llamado OrdenaCadenas que reciba como
        parámetro una lista de strings y la modifique ordenándola alfabéticamente.
*/
{

    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"{Nombre} ";
        }
    }

    class Program
    {
        public static void BorraEnteros(List<int>lista, int numeroABorrar)
        {
            
            while(lista.Contains(numeroABorrar))
            {
                lista.Remove(numeroABorrar);
            }
        }

        public static List<int> Mezcla(List<int> lista1, List<int> lista2)
        {
            List<int> listaOrdenada = new List<int>();
            listaOrdenada.AddRange(lista1);
            listaOrdenada.AddRange(lista2);
            listaOrdenada.Sort();
            
            return listaOrdenada;
        } 

        public static void ImprimeInverso(List<Persona> listaPersonas, int posicion)
        {

            if (posicion == 0)
            {
                Console.WriteLine(listaPersonas[posicion]);
            }
            else
            {
                Console.WriteLine(listaPersonas[posicion]);
                posicion--;
                ImprimeInverso(listaPersonas, posicion);
            }

           
        }

        public static int SumaRecursiva(List<int> lista)
        {
            int suma;
            int rec;

            if (lista.Count == 0)
            {
                suma = 0;
            }

            if (lista.Count > 1)
            {                
                rec = lista[lista.Count - 1];
                lista.RemoveAt(lista.Count - 1);
                suma = rec + SumaRecursiva(lista);
                lista.Add(rec);
            }
            else 
            {
                suma = lista[lista.Count - 1];   
            }
            

            return suma;
        }

        public static void OrdenaCadenas(List<string> lista)
        {
            lista.Sort();
        }

        static void Main(string[] args)
        {
            #region BorraEnteros

            //int numeroABorrar = 8;
            //List<int> lista = new List<int>();
            //lista.Add(1);
            //lista.Add(2);
            //lista.Add(8);
            //lista.Add(3);
            //lista.Add(8);
            //lista.Add(8);
            //lista.Add(4);

            //Console.WriteLine("Lista:");
            //foreach (int dato in lista)
            //{
            //    Console.WriteLine(dato);
            //}

            //Console.WriteLine($"Borrando el elemento {numeroABorrar}:");
            //BorraEnteros(lista, numeroABorrar);

            //foreach (int dato in lista)
            //{
            //    Console.WriteLine(dato);
            //}

            #endregion

            #region Mezcla
            //List<int> lista2 = new List<int>();
            //lista2.Add(1);
            //lista2.Add(3);
            //lista2.Add(5);
            //lista2.Add(7);
            //Console.WriteLine("Lista2:");
            //foreach (int dato in lista2)
            //{
            //    Console.WriteLine(dato);
            //}
            //Console.WriteLine("Lista ordenada:");
            //List<int> lista3 = Mezcla(lista, lista2);
            //foreach (int dato in lista3)
            //{
            //    Console.WriteLine(dato);
            //}
            #endregion

            #region ImprimeInverso
            //List<Persona> listaPersonas = new List<Persona>();
            //listaPersonas.Add(new Persona("Mario", 22));
            //listaPersonas.Add(new Persona("Pedro", 34));
            //listaPersonas.Add(new Persona("Vanesa", 17));
            //listaPersonas.Add(new Persona("Jose", 22));        

            //ImprimeInverso(listaPersonas, 2);
            #endregion

            #region SumaRecursiva
            List<int> listaRecursiva = new List<int>();
            listaRecursiva.Add(1);
            listaRecursiva.Add(3);
            listaRecursiva.Add(5);
            listaRecursiva.Add(7);

            foreach (int dato in listaRecursiva)
            {
                Console.WriteLine(dato);
            }
            Console.WriteLine($"Suma Recursiva = {SumaRecursiva(listaRecursiva)}");

            foreach (int dato in listaRecursiva)
            {
                Console.WriteLine(dato);
            }
            #endregion

            #region OrdenaCadenas
            //List<string> listaCadenas = new List<string>();
            //listaCadenas.Add("Lugo");
            //listaCadenas.Add("Toledo");
            //listaCadenas.Add("Andalucia");
            //listaCadenas.Add("Sevilla");
            //listaCadenas.Add("Alicante");

            //Console.WriteLine("Original:");
            //foreach (string dato in listaCadenas)
            //{
            //    Console.WriteLine(dato);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Ordenada:");
            //OrdenaCadenas(listaCadenas);
            //foreach (string dato in listaCadenas)
            //{
            //    Console.WriteLine(dato);
            //}
            #endregion
        }
    }
}
