using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Ex
{
    /* Modifica el programa anterior para crear nuestro propio tipo de excepción derivada de Exception. 
     * Esta será lanzada en caso de introducir un valor no válido como parámetro. La excepción se llamará ParametroNoValidoException. 
     * Le definiremos 3 constructures: 
     * 
     * 1. Vacío. 
     * 2. Pasándole el mensaje de error. 
     * 3. Pasándole el mensaje de error y un parámetro con la Excepción. 
     * 
     * Deberemos lanzar esta excepción en lugar de la escogida en el punto anterior. Intentar compilar el programa y 
     * observar los errores que aparecen. ¿Por qué ocurre esto? Añadir los elementos necesarios al código para que compile y probarlo.*/
    class Program
    {
        public static double LogaritmoNumero(string datos)
        {

            Console.WriteLine("Numero:");
            double numero = double.Parse(datos);
            if (numero <= 0)
            {
                throw new ParametroNoValidoException("Has introducido un numero negativo o 0", ArgumentException("",""));
            }


            double logaritmoNumero = Math.Log(numero);
            return logaritmoNumero;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(LogaritmoNumero(args[0]));

            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ParametroNoValidoException p)
            {
                Console.WriteLine(p.Message);
                if(p.InnerException != null)
                throw p.InnerException;
            }
           
        }
    }
}
