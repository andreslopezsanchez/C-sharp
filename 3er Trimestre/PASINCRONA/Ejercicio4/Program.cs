using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio4
{
    /**/

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

        static Timer CreaTemporizadorReloj()
        {
            return new Timer() { AutoReset = true, Enabled = true };

        }
        class FlagTaskCancelled
        {
            public bool IsCancelled { get; set; }
        }
        static Task LeeVocalesAsync(FlagTaskCancelled finalizaLectura)
        {
            return Task.Factory.StartNew(() =>
             {
                 Dictionary<char, int> vocalesEncontradas = new Dictionary<char, int>();                

                 using (FileStream archivo = new FileStream("quijote_reducido.txt", FileMode.Open, FileAccess.Read))
                 {
                     using (BinaryReader adaptador = new BinaryReader(archivo, Encoding.UTF8))
                     {   
                             IEnumerable<char> texto = adaptador.ReadChars((int)archivo.Length).Where(c => "AEIOU".Contains(char.ToUpper(c)));
                            
                             Console.WriteLine("\n\n\nVocales contabilizadas hasta el momento...");

                            double contadorPorcentaje = 0;
                             foreach (var v in texto)
                             {
                                double porcentaje = (contadorPorcentaje / texto.ToArray().Length)*100;   
                             
                                if (!finalizaLectura.IsCancelled)
                                {
                                    if (vocalesEncontradas.ContainsKey(char.ToUpper(v)))
                                    {
                                        SituaYDibuja(0, 5, vocalesEncontradas.OrderBy(par => par.Key)
                                                                              .Aggregate("", (s, x) => s += $"La vocal {char.ToUpper(x.Key)} aparece {x.Value} veces.\n"),
                                                      ConsoleColor.Black, ConsoleColor.White);
                                     
                                     if (!finalizaLectura.IsCancelled)
                                     {
                                         SituaYDibuja((int)Math.Round(porcentaje)+5, 3, " ", ConsoleColor.White, ConsoleColor.White);
                                         SituaYDibuja( 5, 3, $"{Math.Round(porcentaje)}%", ConsoleColor.White, ConsoleColor.Black);
                                     }

                                     contadorPorcentaje++;


                                     vocalesEncontradas[char.ToUpper(v)] += 1;
                                    }
                                    else
                                        vocalesEncontradas.Add(char.ToUpper(v), 0);

                                    System.Threading.Thread.Sleep(2);
                                }
                             }                         
                     }
                 }
             });
        }

        static void Main(string[] args)
        {            
            Timer temporizador = CreaTemporizadorReloj();
            FlagTaskCancelled finalizaLectura = new FlagTaskCancelled() { IsCancelled = false };
            Task t = LeeVocalesAsync(finalizaLectura);
            Console.WriteLine("Pulsa Control + C para interrumpir el proceso.");
         

            temporizador.Elapsed += (s, e) => {
                temporizador.Interval = 100;
                SituaYDibuja(0, 2, $"{e.SignalTime} ", ConsoleColor.Black, ConsoleColor.White);
            };            

            Console.CancelKeyPress += (s, e) =>
            {
                finalizaLectura.IsCancelled = true;
                e.Cancel = true;             
            };

                 

            t.Wait();
            SituaYDibuja(0, 10, "", ConsoleColor.White, ConsoleColor.Black);
            Console.WriteLine("Acabado correctamente");
           
        }        
    }
}
