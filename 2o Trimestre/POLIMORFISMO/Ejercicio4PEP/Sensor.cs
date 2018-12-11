using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PEP
{
    class Sensor
    {
        private int valorActual;

        public Sensor(int valorActual)
        {
            this.valorActual = valorActual;
        }

        public int ValorActual
        {
            get
            {
                return valorActual;
            }

            set
            {
                valorActual = value;
            }
        }
    }
}
