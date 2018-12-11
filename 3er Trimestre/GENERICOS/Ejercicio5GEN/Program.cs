using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejercicio5GEN
/* • A partir de la clase del ejercicio 4 , vamos a crear una clase NumeroComplejo que derivare de 
 *    ParOrdenado<double>. 
 *    
 *  • Como ya sabemos, los números complejos constan de dos partes una real y una imaginaria 
 *    (compuesta por el número y el sufijo i), por eso vamos a utilizar la superclase ParOrdenado 
 *    que ya posee los dos elementos que necesitamos. 
 *    
 *  • Tendremos un constructor al que le pasaremos un string con la forma binomial de un número 
 *    complejo y se encargará de comprobarlo con una expresión regular. 
 *    
 *  • Además, también tendrás que redefinir los operadores +, - , *, ==, !=, el cast explícito y el 
 *    método ToString que te devolverá el número de forma correcta con el sufijo y el signo + añadido. 
 *  
 *  • Crea los elementos necesarios para que la clase quede completa y el programa para probar su funcionamiento.*/
{

    class ParOrdenado<T>
    {
        private T primero;
        private T segundo;

        public ParOrdenado(T primero, T segundo)
        {
            this.primero = primero;
            this.segundo = segundo;
        }

        public ParOrdenado()
        {
            this.primero = default(T);
            this.segundo = default(T);
        }

        public T Primero
        {
            get
            {
                return primero;
            }
            set
            {
                primero = value;
            }
        }
        public T Segundo
        {
            get
            {
                return segundo;
            }
            set
            {
                segundo = value;
            }
        }

        public T this[int d]
        {
            get
            {
                if (d == 0)
                    return Primero;
                else if (d == 1)
                    return Segundo;
                else
                    throw new Exception("índice no correcto");
            }
        }
    }

    class NumeroComplejo : ParOrdenado<double>
    {
        public NumeroComplejo(double primero, double segundo) : base(primero, segundo)
        {
            ;
        }

        public NumeroComplejo(string formaBinomial) : base()
        {
            string R = @"[+-]?(\d*.\d+|\d+)([eE][+-]\d+)?";

            string patronComplejo = @"^(?<real>"+R+")" +
                                    @"\s?[+-]\s?" +
                                    @"(?<imaginario>"+R+@")[ij]$";

            Regex patron = new Regex(patronComplejo);
            Match coincidencia = patron.Match(formaBinomial);
            if (coincidencia.Success)
            {
                Primero = double.Parse(coincidencia.Groups["real"].Value);
                Segundo = double.Parse(coincidencia.Groups["imaginario"].Value);
            }
            else
                throw new Exception("Forma binomial INCORRECTA");
        }

        public static NumeroComplejo operator +(NumeroComplejo z1, NumeroComplejo z2)
        {
            return new NumeroComplejo(z1.Primero + z2.Primero, z1.Segundo + z2.Segundo);
        }
        public static NumeroComplejo operator -(NumeroComplejo z1, NumeroComplejo z2)
        {
            return new NumeroComplejo(z1.Primero - z2.Primero, z1.Segundo - z2.Segundo);
        }
        public static NumeroComplejo operator *(NumeroComplejo z1, NumeroComplejo z2)
        {
            return new NumeroComplejo((z1.Primero * z2.Primero) - (z1.Segundo * z2.Segundo),
                                      (z1.Primero * z2.Segundo) - (z1.Segundo * z2.Primero));
        }
        public static bool operator ==(NumeroComplejo z1, NumeroComplejo z2)
        {
            if (z1.Primero==z2.Primero && z1.Segundo==z2.Segundo)            
                return true;            
            else
                return false;
        }
        public static bool operator !=(NumeroComplejo z1, NumeroComplejo z2)
        {
            return !(z1 == z2);
        }

        public static explicit operator double(NumeroComplejo z)
        {
            return z.Primero;
        }

        public override string ToString()
        {
            if (Segundo<0)
            {
                return $"{Primero} - {Math.Abs(Segundo)}i";
            }
            else
            return $"{Primero} + {Segundo}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumeroComplejo z1 = new NumeroComplejo("3 + 2i");
                NumeroComplejo z2 = new NumeroComplejo("4,56 + 51j");

                
                NumeroComplejo z4 = new NumeroComplejo(3, 2);

                if (z1==z4)                
                    Console.WriteLine($"{z1} y {z4} ¡son iguales!");
                else
                    Console.WriteLine($"Ooooh....{z1} y {z4} no son iguales");


                Console.WriteLine($"{z1} + {z2} = {z1 + z2}");
                Console.WriteLine($"{z1} - {z2} = {z1 - z2}");
                Console.WriteLine($"{z1} * {z2} = {z1 * z2}");

                Console.WriteLine($"El numero real de {z1} es {(double)z1}");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
