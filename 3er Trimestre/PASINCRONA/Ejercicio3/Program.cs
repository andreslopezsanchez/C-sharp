using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio3
{
    /* Crea una aplicación que lea un fichero que podrás encontrar junto a este enunciado 
     * y que se llama quijote_reducido.txt. 
     * 
     * En el programa principal (Main) deberás crear un Task (usando una función o expresión 
     * Lambda) que lea carácter a carácter el fichero y que añada en un diccionario la cantidad 
     * de cada una de las vocales que contiene usando como clave el carácter con la vocal 
     * pasado a mayúscula. 
     * 
     * La tarea no recibirá nada y retornará dicho diccionario con las apariciones de cada vocal. 
     * 
     * Una vez lse ance la tarea, el programa principal se quedará en bucle cuya condicion 
     * de salida sea la comprobación de la tarea y mostrará cada segundo la fecha y la hora 
     * en la esquina superior izquierda. 
     * 
     * Al finalizar la cuenta y por tanto salir del bucle, se mostrará el diccionario ordenado 
     * por clave. (Usa la función OrderBy). 
     * 
     * Nota: Si la cuenta la realiza muy rápido puedes meter una pausa de 2 o 3 mili segundos 
     * entre cada vocal leída.
     * 
     *  Ejemplo posible de salida:......*/

    class Program 
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        static void SituaYDibuja(
                      int col, int fila,
                      string texto,
                      ConsoleColor colorFondo,
                      ConsoleColor colorLetra)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(col, fila);
            Console.BackgroundColor = colorFondo;
            Console.ForegroundColor = colorLetra;
            Console.Write(texto); Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Task<Dictionary<char, int>> t = Task.Factory.StartNew(() =>
            {
                Dictionary<char, int> vocalesEncontradas = new Dictionary<char, int>();

                using (FileStream archivo = new FileStream("quijote_reducido.txt", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader adaptador = new BinaryReader(archivo, Encoding.UTF8))
                    {
                        IEnumerable<char> texto = adaptador.ReadChars((int)archivo.Length).Where(c => "AEIOU".Contains(char.ToUpper(c)));                        
                        foreach (var v in texto)
                        {
                            if (vocalesEncontradas.ContainsKey(char.ToUpper(v)))
                                vocalesEncontradas[char.ToUpper(v)] += 1;
                            else
                                vocalesEncontradas.Add(char.ToUpper(v), 1);
                            System.Threading.Thread.Sleep(2);
                        }
                    }
                }
                return vocalesEncontradas;
            });
            
         
            while (!t.IsCompleted)
            {
                SituaYDibuja(0, 0, $"{DateTime.Now}", ConsoleColor.Black, ConsoleColor.White);
                System.Threading.Thread.Sleep(1000); 
            }
                      
            Console.WriteLine("\n\nFinalizada cuenta de letras...");

            string txt = t.Result.OrderBy(par => par.Key)
                                 .Aggregate("", (s, x) => s += $"La vocal {char.ToUpper(x.Key)} aparece {x.Value} veces.\n");
            Console.WriteLine(txt);
        }

    
    }
}
