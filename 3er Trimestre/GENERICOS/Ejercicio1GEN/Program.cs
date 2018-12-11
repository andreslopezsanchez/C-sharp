using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1GEN
/* Partiendo de la siguiente definición de clase parametrizada…
 * 
 * Nota: Sin usar el códigio “autogenerado” por el IDE. 
 * 
 * • Define un constructor que reciba los dos atributos como parámetro. 
 * • Crea 2 propiedades que te permitirán devolver los dos atributos. 
 * • Prueba la clase en em Main con una clave de tipo entero y un valor de tipo cadena.
*/
{
    class A<T, U>
    {
        private T clave;
        private U valor;

        public A(T clave, U valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public T Clave
        {
            get
            {
                return clave;
            }
        }

        public U Valor
        {
            get
            {
                return valor;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A<int, string> a1 = new A<int, string>(9, "onzas");

            Console.WriteLine($"{a1.Clave} {a1.Valor}");
        }
    }
}
