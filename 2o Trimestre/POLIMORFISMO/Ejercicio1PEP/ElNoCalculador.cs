using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PEP
{
    class ElNoCalculador
    {
        private int numero;

        public ElNoCalculador(int numero)
        {
            this.numero = numero;
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public virtual int Factorial()
        {
            return 0;
        }

        public virtual string Primo()
        {
           return "" ;
        }
    }
}
