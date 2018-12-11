using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4RO
{
    /*  • Intenta construir dos clases: La clase Euro y la clase Peseta 
     *    (la peseta era la antigua moneda oficial de España antes de ser reemplazada por el Euro). 
     *    
     *  • Tienes que hacer que los objetos de estas clases se puedan sumar, restar, comparar (operador == y ¡=), 
     *    incrementar y decrementar con total normalidad como si fueran tipos numéricos, teniendo presente que 
     *    1 Euro + 166.386 pesetas = 2 euros. 
     *    
     *  • Además, tienen que ser compatibles entre sí y también con el tipo double.*/
    class Program
    {
        static void Main(string[] args)
        {
            Pesetas p = new Pesetas(8);
            Pesetas p2 = new Pesetas(10);
            Euros e = new Euros(7);
            Euros e2 = new Euros(14);
            

            Console.WriteLine($"{e.Moneda_Euro}e + {p.Moneda_Peseta}p = {(e + p).Moneda_Euro}e");
            Console.WriteLine($"{p.Moneda_Peseta}p + {e.Moneda_Euro}e = {(p + e).Moneda_Euro}e");
            Console.WriteLine($"{e.Moneda_Euro}e + {p.Moneda_Peseta}p = {((Pesetas)e + p).Moneda_Peseta}p");
            Console.WriteLine($"{p.Moneda_Peseta}p + {p2.Moneda_Peseta}p = {(p + p2).Moneda_Peseta}p");
            Console.WriteLine($"{e.Moneda_Euro}e + {e2.Moneda_Euro}e = {(e + e2).Moneda_Euro}e");
            Console.WriteLine("\n\n");
            Console.WriteLine($"{e.Moneda_Euro}e - {p.Moneda_Peseta}p = {(e - p).Moneda_Euro}e");
            Console.WriteLine($"{p.Moneda_Peseta}p - {e.Moneda_Euro}e = {(p - e).Moneda_Euro}e");
            Console.WriteLine($"{e.Moneda_Euro}e - {p.Moneda_Peseta}p = {((Pesetas)e - p).Moneda_Peseta}p");
            Console.WriteLine($"{p.Moneda_Peseta}p - {p2.Moneda_Peseta}p = {(p - p2).Moneda_Peseta}p");
            Console.WriteLine($"{e.Moneda_Euro}e - {e2.Moneda_Euro}e = {(e - e2).Moneda_Euro}e");
            Console.WriteLine("\n\n");
            if (e==e2)
            {
                Console.WriteLine($"{e.Moneda_Euro}e y {e2.Moneda_Euro}e son iguales");
            }
            else
            {
                Console.WriteLine($"{e.Moneda_Euro}e y {e2.Moneda_Euro}e no son iguales");
            }
            if (p == p2)
            {
                Console.WriteLine($"{p.Moneda_Peseta}p y {p2.Moneda_Peseta}p son iguales");
            }
            else
            {
                Console.WriteLine($"{p.Moneda_Peseta}p y {p2.Moneda_Peseta}p no son iguales");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine($"Preincrementando {e.Moneda_Euro}e........{(++e).Moneda_Euro}");
            Console.WriteLine($"Postincrementando {e2.Moneda_Euro}e........{(e2++).Moneda_Euro}");
            Console.WriteLine($"Preincrementando {p.Moneda_Peseta}p........{(++p).Moneda_Peseta}");
            Console.WriteLine($"Postincrementando {p2.Moneda_Peseta}p........{(p2++).Moneda_Peseta}");


        }
    }
}
