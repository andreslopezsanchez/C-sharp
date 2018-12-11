using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class TablaPares : TablaEnteros
    {
        public TablaPares(int[] tablaEnteros) : base(tablaEnteros)
        {
            ;
        }

        protected override int[] GuardarNumerosEnTabla(int[] tablaEnteros)
        {
            int[] tablaPares;
            int sizePares = 0;
            for (int i = 0; i < tablaEnteros.Length; i++)
            {
               if(tablaEnteros[i]%2 == 0)
                {
                    sizePares++;
                }
            }
            tablaPares = new int[sizePares];

            int contador = 0;
            for (int i = 0; i < tablaEnteros.Length; i++)
            {
                if (tablaEnteros[i] % 2 == 0)
                {
                    tablaPares[contador] = tablaEnteros[i] + tablaPares[contador];
                    contador++;
                }
            }
            
            return tablaPares;
        }

        public override void MostrarTabla(int[] tablaEnteros)
        {
            base.MostrarTabla(tablaEnteros);
            int[] tablaPares = GuardarNumerosEnTabla(tablaEnteros);
            tablaEnteros = GuardarNumerosEnTabla(tablaEnteros);
            Console.WriteLine("Pares:");
            for (int i = 0; i < tablaPares.Length; i++)
            {
                Console.WriteLine(tablaPares[i]);
                Console.WriteLine();
            }
            Console.WriteLine($"Suma de numeros: {SumaPropia(tablaPares)}\n");

        }
    }
}
