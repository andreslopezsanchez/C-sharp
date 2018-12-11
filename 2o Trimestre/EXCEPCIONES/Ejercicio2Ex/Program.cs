using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Ex
{
    /* Partiendo del ejercicio anterior, ahora vamos a tratar las excepciones del método logaritmo. 
     * La función de las BCL que calcula el logaritmo, comprueba si el valor introducido es menor 
     * o igual que 0, ya que para estos valores la función logaritmo no está definida. Se pide: 
     * 
     * 1. Busca entre las excepciones la más adecuada para lanzar en este caso, 
     *    que indique que a un método se le ha pasado un argumento ilegal. 
     *    
     * 2. Una vez elegida la excepción adecuada, añadir código (en el método logaritmo) 
     *    para que en el caso de haber introducido un parámetro incorrecto se lance dicha excepción. 
     *    
     * 3. Probar el programa para comprobar el efecto que tiene el lanzamiento de la excepción. 
     * 
     * 4. Captura la excepción en el Main*/
    class Program
    {
        public static double LogaritmoNumero(string datos)
        {

            Console.WriteLine("Numero:");
            double numero = double.Parse(datos);
            if (numero <=0)
            {
                throw new IndexOutOfRangeException("Has introducido un numero negativo o 0");
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
            catch (IndexOutOfRangeException r)
            {
                Console.WriteLine(r.Message);
            }
        }
    }
}
