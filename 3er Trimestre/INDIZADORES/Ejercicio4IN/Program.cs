using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4IN
{
    class Program
    {
        /* • Necesitamos una clase para almacenar los datos de una factura. 
         * 
         * • Datos factura: Nombre del cliente, teléfono, dirección, población, 
         *   provincia, código postal, NIF o CIF y porcentaje de IVA. 
         *   
         * • Por otra parte, tienes que tener presente que en una misma factura puede 
         *   haber una o varias líneas de detalle. 
         *   
         * • Datos línea de detalle: Cantidad, descripción, precio unitario e importe. 
         * 
         * • Usa un indizador para acceder a cada una de estas líneas de detalle. 
         * 
         * • La clase factura, además, debe ofrecer propiedades que devuelvan la base imponible, 
         *   la cuota de IVA y el total a pagar. 
         *   
         * • Escribid también un método principal cliente de esta clase que demuestre que funciona correctamente. 
         * 
         * • Supongo que ya habrás deducido que para que la clase Factura cumpla los requisitos 
         *   que te pido tendrás que construir también una clase Detalle. Pues bien, te propongo 
         *   también que sobrecargues el operador + para que puedas sumar objetos de la clase Detalle 
         *   a objetos de la clase Factura. 
         *   
         * • Ojo, en este caso solamente queremos hacer posible la suma Factura + Detalle, nada más*/


            /*priavte int[]v
             * public int this[int i] -- indizador
             * 
             * private void añande(int n)
             * 
             * if(v==null)
             * v=new int(1)
             * v[0]=n
             * 
             * else
             * array.resize(ref v, vlength +1)
             v[v.lenght-1]=n*/

        static void Main(string[] args)
        {
            Detalle d = new Detalle(3, "pimientos", 30.2, 50.7);
            Factura f = new Factura(
                            "Antonio",965102030,"Doctor sapena", 
                            "Alicante", "Alicante", 03013, 
                            "48675755G",21, d);

            f += new Detalle(4, "alcachoficas", 30.2, 10.7);
            f += new Detalle(2, "patatas", 4.2, 10.7);

            Console.WriteLine(
                            $"Base imponible:{f.BaseImponible()}" +
                            $"\nCuota de iva:{f.PorcentajeIVA}" +
                            $"\nTotal a pagar:{f.TotalAPagar()}");
        }
    }
}
