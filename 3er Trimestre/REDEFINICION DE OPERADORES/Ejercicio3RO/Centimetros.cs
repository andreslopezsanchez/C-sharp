using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3RO
{
    class Centimetros
    {
        private double long_cm;

        public Centimetros(double long_cm)
        {
            this.long_cm = long_cm;
        }
        public double Long_cm
        {
            get
            {
                return long_cm;
            }

            set
            {
                long_cm = value;
            }
        }

        public static explicit operator Centimetros(Metros m)
        {
            return new Centimetros(m.Long_m * 100);
        }
        public static explicit operator double(Centimetros cm)
        {
            return cm.Long_cm;
        }

        public static Centimetros operator +(Centimetros cm1, Centimetros cm2)
        {
            return new Centimetros(cm1.Long_cm + cm2.Long_cm);
        }

        public static Centimetros operator -(Centimetros c1, Centimetros c2)
        {
            return new Centimetros(c1.Long_cm - c2.Long_cm);
        }
    }
}
