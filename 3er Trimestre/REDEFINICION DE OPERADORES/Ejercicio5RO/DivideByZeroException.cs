﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5RO
{
    class DivideByZeroException : Exception
    {
        public DivideByZeroException(string message):
                                        base(message)
        {
            ;
        }
    }
}
