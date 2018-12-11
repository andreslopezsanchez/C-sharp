using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        /*Se nos pide implementar usando POO y herencia las siguientes entidades: 
         * La clase Local: 
         *      • Con los campos ciudad, calle, numero plantas y dimensiones. 
         *      • Con la operación GetNumeroPlantas para poder acceder al atributo numeroPlantas. 
         *      • Con la operación Mostrar que visualizará por la consola los datos de un local. 
         * La clase LocalComercial que heredará de Local. 
         *      • Con los campos razon social y numero licencia. 
         *      • Con la operación Mostrar que visualizará por la consola los datos de un local comercial. 
         * La clase Cine que heredará de LocalComercial. 
         *      • Con el campo aforo sala. 
         *      • Con la operación Mostrar que visualizará por la consola los datos de un cine. 
         *      
         * Deberemos crear un programa principal ejemplo que cree un array de 3 cines, lo inicialice y me lo muestre por pantalla con un foreach*/
        static void Main(string[] args)
        {

            Cine[] cines= new Cine[3];

            Local.Dimensiones dimCine0;
                dimCine0.alto_m = 10;
                dimCine0.ancho_m = 23;
                dimCine0.profundo_m = 2;

            Local.Dimensiones dimCine1;
                dimCine1.alto_m = 10;
                dimCine1.ancho_m = 23;
                dimCine1.profundo_m = 2;

            Local.Dimensiones dimCine2;
                dimCine2.alto_m = 10;
                dimCine2.ancho_m = 23;
                dimCine2.profundo_m = 2;
            

            cines[0] = new Cine("Alicante", "benalua", 5,dimCine0 , "158648G",1234, 150);
            cines[1] = new Cine("Valencia", "garachu", 2, dimCine1, "2134T", 5678, 200);
            cines[2] = new Cine("Castellon", "federul", 0, dimCine2, "85423R", 01698, 50);

            int i = 1;
            foreach (Cine cine in cines)
            {
                
                Console.WriteLine($"CINE Nº {i++}");
                cine.MostrarInformacion();
              
            }
        }
    }
}
