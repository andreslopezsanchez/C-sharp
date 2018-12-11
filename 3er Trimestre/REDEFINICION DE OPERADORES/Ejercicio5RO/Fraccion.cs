using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5RO
{
    class Fraccion
    {
       
        private int numerador;
        private uint denominador;


        public Fraccion(int numerador, uint denominador)
        {
            if (denominador != 0)
            {
                this.numerador = numerador;
                this.denominador = denominador;
                simplifica();
            }
            else
                throw new DivideByZeroException("No se puede dividir por cero");

        }

        public int Numerador
        {
            get
            {
                return numerador;
            }

            set
            {
                numerador = value;
                simplifica();
                
            }
        }
        public uint Denominador
        {
            get
            {
                return denominador;
            }

            set
            {
                
                denominador = value;
                if (denominador!=0)
                {
                    simplifica();
                }
                else
                {
                    throw new DivideByZeroException("No se puede dividir por cero");
                }
            }
        }

        public static explicit operator double(Fraccion f)
        {
            return (double)(f.Numerador/f.Denominador);
        }
      
        public static Fraccion operator +(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador==f2.Denominador)
            {
                return new Fraccion(f1.Numerador+f2.Numerador,f1.Denominador);
            }
            else
            {
                int numSuma = (int)((f1.Numerador * f2.Denominador) + (f2.Numerador * f1.Denominador));
                uint denSuma =f1.Denominador * f2.Denominador;

                return new Fraccion(numSuma, denSuma);
            }
        }
        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == f2.Denominador)
            {
                return new Fraccion(f1.Numerador - f2.Numerador, f1.Denominador);
            }
            else
            {
                int numSuma = (int)((f1.Numerador * f2.Denominador) - (f2.Numerador * f1.Denominador));
                uint denSuma = f1.Denominador * f2.Denominador;

                return new Fraccion(numSuma, denSuma);
            }
        }
        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {
            return new Fraccion(f1.Numerador*f2.Numerador, 
                                f1.denominador*f2.Denominador);
        }     
        public static Fraccion operator /(Fraccion f1, Fraccion f2)
        {
            return new Fraccion(f1.Numerador*(int)f2.Denominador,
                                f1.Denominador*(uint)f2.Numerador);
        }


        private void simplifica()
        {
            int maxcd = mcd(Numerador, Denominador);

            numerador = Numerador / maxcd;
            denominador = (uint)(Denominador / maxcd);
        }
        
        
        private static int mcd(int n, uint d)
        {
            n = Math.Abs(n);

            while ((uint)n % d != 0)
            {
                int r= n% (int)d;
                n = (int)d;
                d = (uint)r;
            }

            return (int)d;
        }
  
        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }
}
