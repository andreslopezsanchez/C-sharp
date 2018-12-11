using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5IN
{
    class Presupuestos
    {
        public enum Concepto
        {
            Comida, Casa, Entretenimiento
        }
        public enum Mes
        {
            Enero,
            Febrero,
            Marzo,
            Abril,
            Mayo,
            Junio,
            Julio,
            Agosto,
            Septiembre,
            Octubre,
            Noviembre,
            Diciembre
        }

        private int[,] presupuesto;
        private static string[] conceptos = Enum.GetNames(typeof(Concepto));
        private static string[] meses = Enum.GetNames(typeof(Mes));


        public Presupuestos()
        {
            presupuesto = new int[filaConceptos.Length, columnaMes.Length];

            for (RECORRO MESES )
            {
                this["", MES] = "300";
                this["", MES] = "500";
                this["", MES] = "200";
            }
           
        }


        public int this[int concepto, int mes]
        {
            set
            {
                presupuesto[concepto, mes] = value;
            }
        }

        public int this[string concepto, string mes]
        {
            set
            {
                int iC = (int)Enum.Parse(typeof(Concepto), concepto);
                int iM = (int)Enum.Parse(typeof(Mes), mes);
                presupuesto[iC, iM] = value;
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
