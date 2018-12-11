using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce un numero de cuenta: ");
                string numero = Console.ReadLine();

                Cuenta cuenta = new Cuenta(numero, "Andres Lopez");

                Console.WriteLine(cuenta);


                cuenta.Reintegro(100);

            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatoCorrecto e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
