using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class TablaImpares : TablaEnteros
    {
        public TablaImpares(int[] tablaEnteros) : base(tablaEnteros)
        {
            ;
        }

        protected override int[] GuardarNumerosEnTabla(int[] tablaEnteros)
        {
            int[] tablaImpares;
            int sizeImpares = 0;
            for (int i = 0; i < tablaEnteros.Length; i++)
            {
                if (tablaEnteros[i] % 2 != 0)
                {
                    sizeImpares++;
                }
            }
            tablaImpares = new int[sizeImpares];

            int contador = 0;
            for (int i = 0; i < tablaEnteros.Length; i++)
            {
                if (tablaEnteros[i] % 2 != 0)
                {
                   tablaImpares[contador] = tablaEnteros[i] + tablaImpares[contador];
                    contador++;
                }
            }
            return tablaImpares;
        }

        public override void MostrarTabla(int[] tablaEnteros)
        {
            base.MostrarTabla(tablaEnteros);
            int[]tablaImpares= GuardarNumerosEnTabla(tablaEnteros);
            Console.WriteLine("Impares");
            for (int i = 0; i < tablaImpares.Length; i++)
            {
                Console.WriteLine(tablaImpares[i]);
                Console.WriteLine();
            }
          Console.WriteLine($"Suma de numeros: {SumaPropia(tablaImpares)}\n");

        }
    }
}
