using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /*• Vamos realizar un programa que detecte mediante eventos la modificación del 
     *  nombre de un archivo en un determinado directorio. 
     *  
     *• Para ello, vamos a utilizar la clase FileSystemWatcher que tiene un evento Renamed 
     *  que es desencadenado al cambiar el nombre de un archivo. 
     *  
     *• Deberemos suscribir a este evento un método estático que me diga por consola si ha 
     *  sido modificado un archivo, el nombre anterior y el nuevo nombre. 
     *  
     *Nota: Para que nuestro objeto FileSystemWatcher desencadene los eventos deberemos establecer 
     *      la propiedad EnableRaisingEvents a true.*/

    //TIEMPO 1a parte:38' 05''. INACABADO
    // No entendía como usarlo


    class Program
    {

        static void Main(string[] args)
        {
            FileSystemWatcher publicador = new FileSystemWatcher();
            char s = Path.DirectorySeparatorChar;
            
            publicador.Path = $"C:{s}prueba1"; 
            publicador.EnableRaisingEvents = true;                     

            publicador.Renamed += Aviso;
            System.Threading.Thread.Sleep(9000);
        }


        private static void Aviso(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Se ha sobreescrito!");
        }

    }
}
