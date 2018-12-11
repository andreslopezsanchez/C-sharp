using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
 
    /*  Partiendo de la siguiente declaración de estructura:

        struct Temperaturas
        {
            public string Provincia;
            public short TemperaturaMaxima;
            public short TemperaturaMinima;
        }

        Escribe un programa con los métodos necesarios para definir una tabla de N provincias e introducir los datos por teclado de nombre, temperatura máxima y mínima.
        Se deberá crear un método que visualice los nombres de las provincias con temperatura máxima superior a la media de las temperaturas máximas y el nombre 
        de las provincias con temperatura mínima inferior a la media de las temperaturas mínimas.*/

    class Ejercicio4

    {

        public struct Temperaturas
        {
            public string Provincia;
            public short TemperaturaMaxima;
            public short TemperaturaMinima;
        }

        static Temperaturas[] PedirDatosEIntroducirlos()
        {

            Console.Write("¿De cuantas provincias quieres hacer la tabla?: ");
            int numeroProvincias = int.Parse(Console.ReadLine());

            Temperaturas[] temperaturas = new Temperaturas[numeroProvincias];

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine($"Provincia nº{i + 1}");

                Console.Write("Dime el nombre de la provincia: ");
                temperaturas[i].Provincia = Console.ReadLine();
                Console.Write("Su temperatura máxima: ");
                temperaturas[i].TemperaturaMaxima = short.Parse(Console.ReadLine());
                Console.Write("Su temperatura mínima: ");
                temperaturas[i].TemperaturaMinima = short.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            return temperaturas;
        }

        public static void SumaMaximosYMinimos(Temperaturas[] temperaturas, out short sumaMaximos, out short sumaMinimos)
        {

            sumaMaximos = 0;
            sumaMinimos = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                sumaMaximos += temperaturas[i].TemperaturaMaxima;
                sumaMinimos += temperaturas[i].TemperaturaMinima;
            }
            Console.WriteLine($"Suma de las temperaturas maximas:{sumaMaximos} ");
            Console.WriteLine($"Suma de las temperaturas minimas:{sumaMinimos} ");
            Console.WriteLine();
        }

        static void MostrarProvinciasFueraDeLaMedia(Temperaturas[] temperaturas, short sumaMax, short sumaMin)
        {
            float mediaMaxima = sumaMax / temperaturas.Length;
            float mediaMinima = sumaMin / temperaturas.Length;
            Console.WriteLine("Provincias con temperaturas más altas que la media:");
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i].TemperaturaMaxima > mediaMaxima)
                {
                    Console.WriteLine(temperaturas[i].Provincia);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Provincias con temperaturas más bajas que la media:");
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i].TemperaturaMinima < mediaMinima)
                {
                    Console.WriteLine(temperaturas[i].Provincia);
                }
            }
        }

        static void Main()
        {
            short sumaMaximos;
            short sumaMinimos;

            Temperaturas[] provincias = PedirDatosEIntroducirlos();
            SumaMaximosYMinimos(provincias, out sumaMaximos, out sumaMinimos);
            MostrarProvinciasFueraDeLaMedia(provincias, sumaMaximos, sumaMinimos);
        }
    }
}
