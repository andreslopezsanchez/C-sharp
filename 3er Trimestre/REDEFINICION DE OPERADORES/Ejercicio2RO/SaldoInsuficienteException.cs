using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2RO
{
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string message):
                                        base(message)
        {
            ;
        }
    }
}
