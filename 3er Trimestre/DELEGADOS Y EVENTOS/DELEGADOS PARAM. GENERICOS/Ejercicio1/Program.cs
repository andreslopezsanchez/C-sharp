using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        public delegate void Mostrar<T>(T[,] valor);
       
        static void MostrarMatriz<T>(T[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i,j],10}");
                }
                Console.WriteLine();
            }
        }
        public static T Mayor<T>(T v1, T v2) where T : IComparable
        {
            if (v1.CompareTo(v2) > 0)
            {
                return v1;
            }
            else
                return v2;
        }

        static void Main(string[] args)
        {
            float[,] mFloat = new float[,]
            {
                {3, 4, 5},
                {2.4f, 4.4f, 5}                
            };
            string[,] mString = new string[,]
            {
                {"SAL","AGUA","AZUCAR","VINO"},
                {"COLA","CAFE","ZUMO","LECHE"}
            };

            Mostrar<float> MostrarF = MostrarMatriz;
            Mostrar<string> MostrarS = MostrarMatriz;
            MostrarF(mFloat);
            MostrarS(mString);

            Action<float[,]> GmostFloat = MostrarMatriz;
            Action<string[,]> GmostString = MostrarMatriz;
            Func<int, int, int> numMayor = Mayor<int>;

            GmostFloat(mFloat);
            GmostString(mString);

            Console.WriteLine($"entre {2} y {5} el mas mayor es {Mayor<int>(2, 5)}");
            Console.WriteLine($"entre {2} y {5} el mas mayor es {numMayor(2, 5)}");
        }
    }
}
