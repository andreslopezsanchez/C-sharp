using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Ex
{
    /* Vamos a crear un programa que abra un archivo en modo lectura y lo lea carácter a carácter para mostrarlo por pantalla. 
     * Deberás controlar las excepciones que pueden saltar si el directorio en el que se encuentra el archivo no existe o este 
     * no se ha creado con antelación. 
     * 
     * Añade un método más para modificar un archivo y, además de las anteriores, también deberás 
     * controlar la excepción que se lanza cuando se intenta modificar y el acceso no está autorizado. */
    class Program
    {

        public static void ModificarArchivo(string ruta)
        {

            Console.WriteLine("Modifica lo que quieras:");
            string texto = Console.ReadLine();
            FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            StreamWriter adaptadorEscribir = new StreamWriter(archivo);
            try
            {
                adaptadorEscribir.Write(texto.ToCharArray());
            }
            finally
            {
                if(adaptadorEscribir!=null)
                    adaptadorEscribir.Close();
            }
        }

        public static string LeerArchivoCaracterACaracter(string ruta)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader adaptadorLeer = new StreamReader(archivo, Encoding.UTF8);
            StringBuilder texto = new StringBuilder();

            try
            {
                while (!adaptadorLeer.EndOfStream)
                {
                    texto.Append(Convert.ToChar(adaptadorLeer.Read()));
                }
            }
            finally
            {
                if(adaptadorLeer!=null)
                    adaptadorLeer.Close();
            }
            return texto.ToString();
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dime la ruta del archivo");
                string ruta = Console.ReadLine();

                Console.WriteLine(LeerArchivoCaracterACaracter(ruta));

                ModificarArchivo(ruta);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("La ruta no existe");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("No estas autorizado");
            }
           
        }
    }
}
