using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3RO
{
    /* • Crea la clase Centímetros y la clase Metros. Ambas poseerán un campo double. 
     *   Redefine los operadores - y + que  permitan desde ambas clases sumar o restar centímetros con metros. 
     *   
     * • También debes redefinir los operadores explícitos Metros y double que permitan el cambio de tipo de 
     *   forma CAST, para ello utiliza la palabra explicit. 
     *   
     * • Haz lo mismo para la clase Centimetros. 
     *   
     * • Implementa el programa necesario para probar todos los operadores.*/
    class Program
    {
        static void Main(string[] args)
        {
            Centimetros cm = new Centimetros(8);
            Metros m = new Metros(7);
            Metros m2 = new Metros(14);
            Centimetros cm2 = new Centimetros(10);

            Console.WriteLine($"{m.Long_m}m + {cm.Long_cm}cm = {(m + cm).Long_m}m");
            Console.WriteLine($"{cm.Long_cm}cm + {m.Long_m}m = {(cm + m).Long_m}m");
            Console.WriteLine($"{m.Long_m}m + {cm.Long_cm}cm = {((Centimetros)m + cm).Long_cm}cm");
            Console.WriteLine($"{cm.Long_cm}cm + {cm2.Long_cm}cm = {(cm + cm2).Long_cm}cm");
            Console.WriteLine($"{m.Long_m}m + {m2.Long_m}m = {(m + m2).Long_m}m");
            Console.WriteLine("\n\n");
            Console.WriteLine($"{m.Long_m}m - {cm.Long_cm}cm = {(m - cm).Long_m}m");
            Console.WriteLine($"{cm.Long_cm}cm - {m.Long_m}m = {(cm - m).Long_m}m");
            Console.WriteLine($"{m.Long_m}m - {cm.Long_cm}cm = {((Centimetros)m - cm).Long_cm}cm");
            Console.WriteLine($"{cm.Long_cm}cm - {cm2.Long_cm}cm = {(cm - cm2).Long_cm}cm");
            Console.WriteLine($"{m.Long_m}m - {m2.Long_m}m = {(m - m2).Long_m}m");
        }
    }
}
