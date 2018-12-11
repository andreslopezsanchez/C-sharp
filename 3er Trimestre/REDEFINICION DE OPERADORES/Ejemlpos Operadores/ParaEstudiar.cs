using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Complejo
    {
        private double parteReal;
        private double parteImaginaria;

        public Complejo(double parteReal, double parteImaginaria) {
            this.parteReal = parteReal; this.parteImaginaria = parteImaginaria;
        }

        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            double pR = c1.parteReal + c2.parteReal;
            double pI = c1.parteImaginaria + c2.parteImaginaria;
            return new Complejo(pR, pI);
        }
        public static Complejo operator +(Complejo c, double d)
        {
            return new Complejo(c.parteReal + d, c.parteImaginaria);
        }
        public static Complejo operator +(double d, Complejo c)
        {
            return c+d;
        }

        public static bool operator ==(Complejo c1, Complejo c2)
        {
          
            return c1.parteReal == c2.parteReal && c1.parteImaginaria == c2.parteImaginaria;
        }
        public static bool operator !=(Complejo c1, Complejo c2) //evitas repetir codigo
        {
 
            return !(c1==c2);
        }

        public static explicit operator double(Complejo c)
        {
            return c.parteReal;
        }

        public static Complejo operator ++(Complejo c) //el pre incremento y el post incremento lo hace la maquina sola c++ ++c
        {
            /*c.parteReal++;
             return c; 
             FALLO!!*/

            //SIEMPRE HAY QUE HACER UN NEW 
            return new Complejo(c.parteReal + 1, c.parteImaginaria);
        }


        public override string ToString() {
            string texto = $"({parteReal:G})";
            texto += (parteImaginaria > 0D) ? " + " : " - ";
            texto += $"{Math.Abs(parteImaginaria):G}i";
            return texto;
        }
    }

    class Programa
    {
        public static void Main()
        {
            Complejo c1 = new Complejo(2d, 4d);
            Complejo c2 = new Complejo(1d, 5d);


            Console.WriteLine($"{c2 + (double)c1}");
            Console.WriteLine($"{(double)c1}");
            Console.WriteLine($"{c1} + {c2} = {c1+c2}");
        }
    }
    
}
