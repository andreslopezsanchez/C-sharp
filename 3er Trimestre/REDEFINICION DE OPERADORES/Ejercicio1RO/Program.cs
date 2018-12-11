using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1RO
{
    class Program
    {
        /*Para cierta implementación que no viene al caso, el departamento de diseño ha detectado
           la necesidad de implementar un nuevo tipo de números a los que ha denominado
“números curiosos”. Un número curioso se caracteriza por tres coordenadas reales
(a, b, c) que verifican a2
 + b2
 + c2
 = 1, salvo en el caso del número “cero” cuyas
coordenadas son (0, 0, 0).
Sobre los números curiosos interesa realizar las siguientes operaciones:
1. Suma (otro:CURIOSO) definida mediante la fórmula...
2. Resta (otro:CURIOSO) definida mediante la fórmula...
• Crea la clase NumeroCuriosos con los atributos, propiedades y métodos que tú
creas necesarios para su correcta implementación y prueba.
• Redefine los operadores necesarios para poder realizar la suma y resta de dos
números curiosos.
*/
        static void Main(string[] args)
        {
            Curioso c1 = new Curioso(1, 0, 0);
            Curioso c2 = new Curioso(0, 0, 0);


            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
            Console.WriteLine($"{c1} + {c2} = {c1+c2}");
        }
    }
}
