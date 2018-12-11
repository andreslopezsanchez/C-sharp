using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PEP
{
    class ElCalculador : ElNoCalculador
    {

        private int num; 
        public ElCalculador(int num) : base(num)
        {
            ;
        }

        public override int Factorial()
        {
            int resultado = 1;
            for (int i = 1; i <= num; i++)
            {
                resultado = resultado * i;
            }
            return resultado;

        }

        public override string Primo()
        {
            int a = 0;
            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                return "No es Primo";
            }
            else
            {
                return "Si es Primo";
            }
        }

        public void MostrarResultado()
        {
            string mensaje = $"Numero:{num} \nFactorial{Factorial()} \nPrimo:" + Primo();
            Console.WriteLine(mensaje);
        }
    }
}
