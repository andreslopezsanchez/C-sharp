using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3RO
{
    class Metros
    {
        private double long_m;

        public Metros(double long_m)
        {
            this.long_m = long_m;
        }

        public double Long_m
        {
            get
            {
                return long_m;
            }

            set
            {
                long_m = value;
            }
        }

        public static explicit operator Metros(Centimetros cm)
        {
            return new Metros(cm.Long_cm / 100d);
        }
        public static explicit operator double(Metros m)
        {
            return m.Long_m;
        }

        public static Metros operator+(Metros m, Metros m2)
        {
            return new Metros(m.long_m + m2.long_m);
        }
        public static Metros operator +(Metros m, Centimetros cm)
        {

            return m + (Metros)cm;
        }
        public static Metros operator +(Centimetros cm, Metros m)
        {
            return m + cm;
        }



        public static Metros operator-(Metros m, Metros m2)
        {
            return new Metros(m.long_m - m2.long_m);
        }
        public static Metros operator -(Metros m, Centimetros cm)
        {
            return m - (Metros)cm;
        }
        public static Metros operator -(Centimetros cm, Metros m)
        {
            return m + cm;
        }
    }
}
