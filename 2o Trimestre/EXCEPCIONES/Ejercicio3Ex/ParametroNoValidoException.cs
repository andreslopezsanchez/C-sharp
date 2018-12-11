using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Ex
{
    /* Le definiremos 3 constructures: 
     * 
     * 1. Vacío.
     * 2. Pasándole el mensaje de error.
     * 3. Pasándole el mensaje de error y un parámetro con la Excepción.*/

    class ParametroNoValidoException : Exception
    {


        public ParametroNoValidoException()
        {
            ;
        }

        public ParametroNoValidoException(string message):
                                        base(message)
        {
            ;
        }

        public ParametroNoValidoException(string message, ArgumentOutOfRangeException argOutRange) :
                                        base(message)
        {
            ;
        }
    }
}
