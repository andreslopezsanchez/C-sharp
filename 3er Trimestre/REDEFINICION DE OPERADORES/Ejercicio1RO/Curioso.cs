using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1RO
{
    class Curioso
    {
        private double a;
        private double b;
        private double c;

        public Curioso(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

       

        public static Curioso operator +(Curioso c1, Curioso c2)
        {
            double parteComun = (Math.Sqrt(Math.Pow(c1.a + c2.a, 2) + Math.Pow(c1.b + c2.b, 2) + Math.Pow(c1.c + c2.c, 2)));
            if (parteComun!=0)
            {
                double a = (c1.a + c2.a) / parteComun;
                double b = (c1.b + c2.b) / parteComun;
                double c = (c1.c + c2.c) / parteComun;

                return new Curioso(a, b, c);
            }
            else
            {
                return new Curioso(0, 0, 0);
            }
            
        }

        public static Curioso operator -(Curioso c1, Curioso c2)
        {
            double parteComun = (Math.Sqrt(Math.Pow(c1.a - c2.a, 2) + Math.Pow(c1.b - c2.b, 2) + Math.Pow(c1.c - c2.c, 2)));

            if (parteComun!=0)
            {
                double a = (c1.a - c2.a) / parteComun;
                double b = (c1.b - c2.b) / parteComun;
                double c = (c1.c - c2.c) / parteComun;

                return new Curioso(a, b, c);
            }
            else
            {
                return new Curioso(0, 0, 0);
            }
            
        }

        public override string ToString()
        {
            return $"({a:G2} , {b:G2} , {c:G2})";
        }
    }
}
