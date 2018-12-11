using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static int AddTwoNumbers(int n1, int n2)
        { return n1 + n2; }
        static double GetTopSpeed()
        { return 108.4; }
        static double fcalcul(string tipo, string nom1, string nom2)
        {
            Console.WriteLine($"Introduce {nom1}");
            string temp1 = Console.ReadLine();
            int var1 = Int32.Parse(temp1);
            Console.WriteLine($"Introduce {nom2}");
            string temp2 = Console.ReadLine();
            int var2 = Int32.Parse(temp2);
            if (tipo == "Potencia")
                return (var1 * var2);
            else
                return (var1 / var2);
        }
        static int SquareANumber(int number)
        { return number * number; }
        static bool MultiploCinco(int n)
        { if ((n % 5) != 0) return false; else return true; }
        static void Noseque(double[,] x, int[] y, string z)
        {
            if (x.Length == y.Length)
            {
                int p = 0;
                foreach (double c in x)
                {
                    z += (c + y[p]);
                    z += " ";
                    p++;
                }
            }
            Console.WriteLine(z);
        }

        static void Main(string[] args)
        {
            Func<int, int, int> AñadeDosNumeros = AddTwoNumbers;
            Console.WriteLine(AñadeDosNumeros(2, 3));

            Func<double> VelocidadMaxima = GetTopSpeed;
            Console.WriteLine($"{VelocidadMaxima}");

            Func<string, string, string, double> FuncionCalculo = fcalcul;
            Console.WriteLine(FuncionCalculo("int", "1", "2"));

            Func<int, int> NumeroCuadrado = SquareANumber;
            Console.WriteLine(NumeroCuadrado(2));

            Predicate<int> Mult5 = MultiploCinco;
            Console.WriteLine(Mult5(5));

            Action<double[,], int[], string> QueSeNo = Noseque;
            QueSeNo(new double[,] { { 2, 3 }, { 3, 2 } }, new int[] { 2, 3 }, "hola");

        }
    }
}
