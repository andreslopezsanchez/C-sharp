using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_B4_C
/*
     Utilizando la clase genérica Dictionary<Tkey, Tvalue> definida en en
    System.Collections.Generic, implementa un sencillo programa de consola que pida
    nombres por teclado hasta que introduzcamos la cadena "fin".
    
    En ese momento mostraremos los nombres introducidos y cuantas veces se ha
    introducido cada uno. Puedes guardar los nombres como clave en el diccionario y el
    número de veces que se ha introducido como valor.
    
    Recorre el diccionario 2 veces. Una con un foreach para las claves y otra con un foreach
    para el diccionario obteniendo pares clave valor con la siguiente clase
    KeyValuePair<Tkey, Tvalue>
*/
{
    class Program //tiempo tardado: 38' 30''
    {
        public static void IntroducirNombre(string nombre,  Dictionary<string, int> nombres)
        {            
            int contadorNombre;
            if (nombre.ToLower() != "fin")
            {
                if (nombres.Count==0)
                {
                    contadorNombre = 1;
                    nombres.Add(nombre, contadorNombre);
                }
                else
                {
                    foreach (var valor in nombres)
                    {
                        if (valor.Key == nombre)
                        {
                            contadorNombre = valor.Value + 1;
                            nombres.Remove(nombre);
                            nombres.Add(nombre, contadorNombre);
                            break;
                        }
                        else
                        {
                            contadorNombre = 1;
                            nombres.Add(nombre, contadorNombre);
                            break;
                        }
                    }
                }             
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> nombres = new Dictionary<string, int>();
            string nombreIntroducido="";

            do
            {
                Console.WriteLine("dime un nombre");
                nombreIntroducido = Console.ReadLine();
                IntroducirNombre(nombreIntroducido,  nombres);
            } while (nombreIntroducido.ToLower()!="fin");
            
            foreach (var valor in nombres)
            {
                Console.WriteLine($"Nombre:{valor.Key} Repetido:{valor.Value}");
            }
        }
    }
}
