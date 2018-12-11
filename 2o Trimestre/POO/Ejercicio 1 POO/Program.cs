using System;
using System.Diagnostics;

namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {


            Escritor escritor1 = new Escritor();
            escritor1.SetNombre("Andres");
            escritor1.SetAlias("xexu");
            escritor1.SetNacimiento(new DateTime(1993, 12, 3));
            escritor1.SetMuerte(new DateTime(2001, 3, 12));

            Console.WriteLine($"Escritor:{escritor1.GetNombre()}\n" +
                              $"Alias:{escritor1.GetAlias()}\n" +
                              $"Nacimiento:{escritor1.GetNacimiento().ToShortDateString()}\n" +
                              $"Muerte:{escritor1.GetMuerte().ToShortDateString()}\n" +
                              $"Años Fallecidos:{escritor1.GetAñosFallecidos(escritor1.GetMuerte())}\n");

            Escritor escritor2 = new Escritor("Rodrigo", "el poeta", new DateTime(1988, 1, 23), new DateTime(2015, 6, 30));

            Console.WriteLine($"Escritor:{escritor2.GetNombre()}\n" +
                              $"Alias:{escritor2.GetAlias()}\n" +
                              $"Nacimiento:{escritor2.GetNacimiento().ToShortDateString()}\n" +
                              $"Muerte:{escritor2.GetMuerte().ToShortDateString()}\n" +
                              $"Años Fallecidos:{escritor2.GetAñosFallecidos(escritor2.GetMuerte())}\n");

            Escritor escritor3 = new Escritor(escritor1);
        
            escritor3.SetAlias("el del bombo");
            escritor3.SetNacimiento(new DateTime(1978, 11, 5));
    

            Console.WriteLine($"Escritor:{escritor3.GetNombre()}\n" +
                           $"Alias:{escritor3.GetAlias()}\n" +
                           $"Nacimiento:{escritor3.GetNacimiento().ToShortDateString()}\n" +
                           $"Muerte:{escritor3.GetMuerte().ToShortDateString()}\n" +
                           $"Años Fallecidos:{escritor3.GetAñosFallecidos(escritor3.GetMuerte())}\n");

            Libro libro1 = new Libro();
            libro1.SetEscritor(escritor1);
            

            Libro libro2 = new Libro();
            libro2.SetEscritor(escritor2);

            Libro libro3 = new Libro();
            libro3.SetEscritor(escritor3);

        }
    }
}
