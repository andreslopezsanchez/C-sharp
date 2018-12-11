using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*https://regexr.com/3ibqi
 * 
 * using System.Text.RegularExpressions PONER ESTO SIEMPRE MUY IMPORTANTE
 * ^([1-2][0-5]{2}|[1-9][0-9]|[0-9]\.)$
 * 
 * ejerciciof y e
 * ^[+-]?[0-9]*,?[0-9]+[Ee][+-]?[0-9]+$ */
namespace ConsoleApplication14
{
    #region Ejercicio1
    class ExpresionesRegulares
    {
        /*
         a) Una fecha larga. Formato válido DD<sep>MM<sep>AAAA 
            <sep> → Separadores ‘ ‘, ‘/‘ o ‘-‘;

            ^(?<dia>[0-9]|1[0-9]|2[0-9]|3[0-1])(\-|\,)(?<mes>[0-9]|1[0-2])(\-|\,)(?<year>[0-9]{4})$

         b) Una IPv4. Formato válido [0-255].[0-255].[0-255].[0-255]

            2[0-5]{2}|1[0-9]{2}|[1-9][0-9]|[0-9]

         c) Un número entero. Correctos: 12 →  +12  →  -12  →  -0 Una matrícula

          LL<sep>DDDD<sep>LL

            ^(?<g1>[a-z]{2})(\-|\s)(?<g2>[0-9]{4})(\-|\s)(?<g3>[a-z]{2})$

          DDDD<sep>LLL 

            ^(?<g1>[0-9]{4})(\-|\s)(?<g2>[a-z]{3})$

        d) Un número real. Con la coma Española. Correctos: 12  →  +12  →  -12  →  -0 →  12,34 →  0,34 →  +0,34 →  ,34 →  -, 34

        e) Un número real con exponente. Correctos: 12,34E12  →  -, 34e-1 →   0,34E+22

            ^[+-]?[0-9]*,?[0-9]+[Ee][+-]?[0-9]+$ 

        f) Un número de cuenta. Formato válido     EEEE<sep>SSSS<sep>C1C2<sep>NNNNNNNNNN <sep> → Separadores ‘ ‘ o ‘-‘; 
           El numero de cuenta tiene los siguientes subgrupos que deberás etiquetar: ◦ 
           E → Dígitos Entidad ◦ S → Dígitos Sucursal ◦ C1 → Dígito de Control 1 ◦ C2 → Dígito de Control 2 ◦ 
           N → Número de cuenta 

        ^(?<DigitosEntidad>[0-9]{4})(\s|\-)(?<DigitosSucursal>[0-9]{4})(\s|\-)(?<DigitoControl1>[0-9]{2})(?<DigitoControl2>[0-9]{2})(\s|\-)(?<NumeroCuenta>[0-9]{10})$
        */
    }
    #endregion
    #region Ejercicio2
    class Ejercicio2
    {
        /* Crea la expresión regular para comprobar el formato del Código de identificación Fiscal (C.I.F.) Tendrá el siguiente formato:
         * 
         *  T<sep>PPNNNNN<sep>C <sep>: ‘ ‘, ‘-‘ o nada. 
         *  
         *  • T: Letra de tipo de Organización, una de las siguientes: • A, B, C, D, E, F, G, H ,K, L, M, N, P, Q, S. 
         *  • P: Código provincial numérico. • N: Numeración secuencial dentro de la provincia. 
         *  • C: Dígito de control, un número ó letra: Aó1, Bó2, Có3, Dó4, Eó5, Fó6, Gó7, Hó8, Ió9, Jó0*/

        /*
         ^(?<Organizacion>[a-hk-npqs])(\s|\-)(?<CodigoProvincialNum>[0-9]{2})(?<NumeracionSecuencial>[0-9]{5})(\s|\-)(?<DigitoControl>[a-j0-9])$
         */
    }
    #endregion
    #region Ejercicio3
    /* Se nos pide hacer un programa en C# que compruebe el formato de entrada de un número de cuenta por teclado, 
     * utilizando expresiones regulares (del ejercicio 1 parte g). Además debe indicar tras la entrada que dígitos corresponden a la entidad,
     * cuales a la sucursal, los dígitos de control y el número de cuenta, para esto utilizaremos la captura con grupos.
     * 
     *  Opcional: Puedes comprobar si el número de cuenta es válido calculando los dígitos de control que debería tener y 
     *  comprobando si coinciden con los de la introducida. Puedes buscar por Internet como se calcula el dígito de control de una 
     *  cuenta bancaria.*/
    class Ejercicio3
    {
      /*  static void Main()
        {
            string patronCuenta =
                @"(?<DigitosEntidad>[0 - 9]{4})" +
                "\\s" +
                "(?<DigitosSucursal>[0 - 9]{4})" +
                "\\s" +
                "(?<DigitoControl1>[0 - 9]{2})" +
                "(?<DigitoControl2>[0 - 9]{2})" +
                "\\s" +
                "(?<NumeroCuenta>[0 - 9]{10})";

            Console.WriteLine("Introduzca el numero de cuenta: ");
            string cuenta = Console.ReadLine();

            Match m = Regex.Match(cuenta, patronCuenta);
            do
            {
                if (m.Success)
                {
                    Console.WriteLine($"Digitos de la Entidad: {m.Groups["DigitosEntidad"].Value}\n" +
                                      $"Digitos de la sucursal: {m.Groups["DigitosSucursal"].Value}\n" +
                                      $"Digitos de control 1: {m.Groups["DigitoControl1"].Value}\n" +
                                      $"Digitos de control 2: {m.Groups["DigitoControl2"].Value}\n" +
                                      $"Numero de Cuenta: {m.Groups["NumeroCuenta"].Value}");
                    m = m.NextMatch();
                }
                else
                    Console.WriteLine("numero introducido no valido");
            }
            while (m.Success);
        }*/
    }
    #endregion
    #region Ejercicio4
    /* Se nos pide hacer un programa en C# que compruebe el formato de entrada del Código de Identificación Fiscal (C.I.F.) 
     * por teclado y que etiquete cada uno de los grupos. */

    class Ejercicio4
    {
        //static void Main()
        //{
        //    string patron = "(?<Organizacion>[a-hk-npqs])" +
        //                    "(\\s|\\-)" + 
        //                    "(?<CodigoProvincialNum>[0-9]{2})" + 
        //                    "(?<NumeracionSecuencial>[0-9]{5})" + 
        //                    "(\\s |\\-)" + 
        //                    "(?<DigitoControl>[a-j0-9])";

        //    Console.Write("Escribe tu C.I.F T<sep>PPNNNNN<sep>C: ");
        //    string CIF = Console.ReadLine();

        //    Match m = Regex.Match(CIF, patron);

        //    if (m.Success)
        //    {
        //        Console.WriteLine("EXITO");
        //        Console.WriteLine($"Organizacion: {m.Groups["Organizacion"].Value}\n" +
        //                          $"CodigoProvincialNum: {m.Groups["CodigoProvincialNum"].Value}\n" +
        //                          $"NumeracionSecuencial: {m.Groups["NumeracionSecuencial"].Value}\n" +
        //                          $"Digitos de control: {m.Groups["DigitoControl"].Value}");
        //        m = m.NextMatch();
        //    }
        //    else
        //        Console.WriteLine("No valido");
        //}
    }
    #endregion
    #region Ejercicio5
    /*Para el ejercicio anterior, calcular además el dígito de control para el C.I.F. 
     * según se explica en http://club.telepolis.com/jagar1/Ccif.htm e indicar si el C.I.F. 
     * por tanto es correcto teniendo en cuenta además del formato, el digito de control introducido.*/

    //class Ejercicio5
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
    #endregion
    #region Ejercicio6
    /*  Programa que me compruebe, con una expresión regular que, si un número introducido es un número complejo.
     *  Un numero complejo en su forma binomial se representará como a + bi  o  a + bj siendo a y b números reales. 
     *  Correctos: -2,3 + 5e-2j →  7i →  2E+5 + 2,3i*/

    class Ejercicio6
    {
        //static void Main(string[] args)
        //{
        //    string patron = "([+-]?[0-9]+,?[0-9]*[EeJjiI]*)(\\s[+-]?\\s)*([+-]?[0-9]+,?[0-9]*[EeJjiI]*)?";

        //    Console.Write("Dime un numero binominal: ");
        //    string binominal = Console.ReadLine();

        //    Match m = Regex.Match(binominal, patron);

        //    if (m.Success)
        //    {
        //        Console.WriteLine("EXITO");
        //    }
        //    else
        //        Console.WriteLine("No valido");
        //}
    }
    #endregion
    #region Ejercicio7
    /* Expresión regular que me encuentre definiciones de tipos enumerados en una cadena de consumo. Para simplificar supondremos las siguiente 
     * sintaxis para los tipos enumerados, respetando espacios:
                    enum Nombre {Valor1,Valor2,Valor3,…,ValorN}
       con las siguientes restricciones: 
       • Las definiciones irán todas en la misma línea, esto es, no hay saltos de línea. 
       • Todos los textos deben ir en PascalCasing, no pueden comenzar por número y como deben contener una letra. 
       • No se podrán inicializar los valores enumerados. Casos posibles posibles: 
            enum Ejemplo {Valor1,Valor2,Valor3} → Entrada válida. 
            enum Ejemplo {Valor1,Valor2,Valor3,} → Entrada inválida. 
            enum Ejemplo{Valor1,Valor2, Valor3} → Entrada inválida. 
            enum ejemplo {Valor1,valor2,Valor3} → Entrada inválida. 
            enum 1ejemplo {Valor1,2Valor,Valor3} → Entrada inválida.*/

    //class ejercicio7
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
    #endregion
}
