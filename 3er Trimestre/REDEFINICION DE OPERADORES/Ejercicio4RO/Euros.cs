using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4RO
{
    class Euros
    {
        private double moneda_Euro;

        public Euros(double moneda_Euro)
        {
            this.moneda_Euro = moneda_Euro;
        }
        public double Moneda_Euro
        {
            get
            {
                return moneda_Euro;
            }

            set
            {
                moneda_Euro = value;
            }
        }

        public static explicit operator Euros(Pesetas p)
        {
            return new Euros(p.Moneda_Peseta / 166.386d);
        }
        public static explicit operator double(Euros e)
        {
            return e.Moneda_Euro;
        }


        public static Euros operator+(Euros e1, Euros e2)
        {
            return new Euros(e1.Moneda_Euro + e2.Moneda_Euro);
        }
        public static Euros operator +(Euros e, Pesetas p)
        {
            return e + (Euros)p;
        }
        public static Euros operator +(Pesetas p, Euros e)
        {
            return e + p;
        }

        public static Euros operator -(Euros e1, Euros e2)
        {
            return new Euros(e1.Moneda_Euro - e2.Moneda_Euro);
        }
        public static Euros operator -(Euros e, Pesetas p)
        {
            return e - (Euros)p;
        }
        public static Euros operator -(Pesetas p, Euros e)
        {
            return e - p;
        }

        public static bool operator ==(Euros e1, Euros e2)
        {
            return e1.Moneda_Euro == e2.Moneda_Euro;
        }
        public static bool operator !=(Euros e1, Euros e2)
        {
            return !(e1 == e2);
        }

        public static Euros operator ++(Euros e)
        {
            return new Euros(e.Moneda_Euro + 1);
        }
        public static Euros operator --(Euros e)
        {
            return new Euros(e.Moneda_Euro - 1);
        }

    }
}
