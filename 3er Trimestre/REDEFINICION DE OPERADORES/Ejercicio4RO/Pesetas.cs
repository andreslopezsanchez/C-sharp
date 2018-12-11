using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4RO
{
    class Pesetas
    {
        private double moneda_Peseta;

        public Pesetas(double moneda_Peseta)
        {
            this.moneda_Peseta = moneda_Peseta;
        }
        public double Moneda_Peseta
        {
            get
            {
                return moneda_Peseta;
            }

            set
            {
                moneda_Peseta = value;
            }
        }

        public static explicit operator Pesetas(Euros e)
        {
            return new Pesetas(e.Moneda_Euro * 166.386d);
        }
        public static explicit operator double(Pesetas p)
        {
            return p.Moneda_Peseta;
        }

        public static Pesetas operator +(Pesetas p1, Pesetas p2)
        {
            return new Pesetas(p1.Moneda_Peseta + p2.Moneda_Peseta);
        }
        public static Pesetas operator -(Pesetas p1, Pesetas p2)
        {
            return new Pesetas(p1.Moneda_Peseta - p2.Moneda_Peseta);
        }

        public static bool operator ==(Pesetas p1, Pesetas p2)
        {
            return p1.Moneda_Peseta == p2.Moneda_Peseta;
        }
        public static bool operator !=(Pesetas p1, Pesetas p2)
        {
            return !(p1 == p2);
        }

        public static Pesetas operator ++(Pesetas p)
        {
            return new Pesetas(p.Moneda_Peseta + 1);
        }
        public static Pesetas operator --(Pesetas p)
        {
            return new Pesetas(p.Moneda_Peseta - 1);
        }
    }
}
