using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PEP
{
    class FormatoCorrecto : Exception
    {
        public FormatoCorrecto(string message):
                                        base(message)
        {
            ;
        }
    }
}
