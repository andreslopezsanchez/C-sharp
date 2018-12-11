using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2IN
{
    /* • Utilizando las clases de Libro y Autor que hiciste en ejercicios anteriores. 
     *   Vamos a modificarlas de forma que ahora cada autor poseerá un array de libros 
     *   donde se guardará la información de estos. 
     *   
     * • Para eso modifica los constructores, crea un indizador para el array libros, 
     *   crea las propiedades necesarias, sobreescribe el método ToString para que te 
     *   devuelva toda la información de un autor como cadena y, por último, crea un 
     *   método en la clase program que te permita usar el indizador para meter la información de los libros de un autor.*/

    class Program
    {

        public static void RellenarLibros(Escritor escritor)
        {

            Console.WriteLine($"Dime que {escritor.CantidadLibros} libros tiene {escritor.Nombre}");

            for (int i = 0; i < escritor.CantidadLibros; i++)
            {
                Console.WriteLine($"Dime su titulo del libro {i+1}:");
                string titulo = Console.ReadLine();
                Console.WriteLine("Dime su fecha de publicacion:");
                Console.Write("año:");
                int year = int.Parse(Console.ReadLine());
                Console.Write("mes:");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("dia:");
                int dia = int.Parse(Console.ReadLine());
                Console.WriteLine();

                DateTime fecha = new DateTime(year, mes, dia);
                escritor[i] = new Libro(titulo, fecha, escritor);
               
            }
        }


        public static void BuscarLibro(Escritor escritor)
        {
            Console.WriteLine("De los libros que acabas de introducir dime cual quieres buscar:");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion<=escritor.CantidadLibros)
            {
                Console.WriteLine($"{escritor[posicion - 1]}\n");
            }
            else
            {
                throw new Exception("NO TIENE TANTOS LIBROS!");
            }
            
          
        }

        static void Main(string[] args)
        {
            try
            {
                Escritor andres = new Escritor("andres", "el toro", new DateTime(1993, 12, 3), new DateTime(2100, 3, 4), 2);

                RellenarLibros(andres);
                Console.Clear();
                BuscarLibro(andres);
               

                Console.WriteLine($"INFORMACION DEL ESCRITOR: \n{andres}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
