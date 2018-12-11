using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2RO
{
    /*A partir del ejercicio de Cuenta Bancaria de excepciones, vas a redefinir como mínimo dos operadores que serán:
     * 
     *  • !=  → que a partir de dos cuentas te devolverá true sin son distintas y false en caso contrario. 
     *  • == → que a partir de dos cuentas, te devolverá false sin son distintas y true en caso contrario. 
     *  
     *  • Para ambos operadores utilizaremos un solo método estático Iguales que será el que nos compruebe si 
     *    las cuentas son iguales. 
     *  
     *  Nota: Para ver si dos cuentas son iguales tendrás que ver además del titular y saldo, si los números 
     *  de cuenta son iguales (redefiniendo también su operador == y !=).*/
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce un numero de cuenta: ");
                string numero1 = Console.ReadLine();

                Console.WriteLine("Introduce otro numero de cuenta: ");
                string numero2 = Console.ReadLine();

                Cuenta cuenta1 = new Cuenta(numero1, "Andres Lopez");
                Cuenta cuenta2 = new Cuenta(numero2, "Andres Lopez");

                cuenta1.Ingreso(100);
                cuenta2.Ingreso(100);

                Console.WriteLine(cuenta1);
                Console.WriteLine(cuenta2);

                if (cuenta1==cuenta2)
                {
                    Console.WriteLine("Cuentas iguales!");
                }
                if (cuenta1!=cuenta2)
                {
                    Console.WriteLine("No son iguales");
                }
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatoCorrecto e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
