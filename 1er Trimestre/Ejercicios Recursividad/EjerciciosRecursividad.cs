using System;


namespace EjerciciosRecursividad


{

    #region Ejercicio1
    /*Construir un programa que calcule y muestre los divisores de un número de forma recursiva.*/
    class Ejercicio1

    {

           // public static void MuestraDivisores(int numero, int divisor)
           //  {

           //    divisor++;
           //    if (divisor == numero)// caso base
           //        Console.WriteLine(divisor);
           //    else // caso general
           //    {
           //        if(numero%divisor==0)
           //            Console.WriteLine(divisor);

           //        MuestraDivisores(numero, divisor);
           //    }


           //  }

           //  static void Main()
           //  {
           //    int divisor = 1;
           //    Console.Write("Dime un numero: ");
           //    int numero = int.Parse(Console.ReadLine());
           //     MuestraDivisores(numero, divisor);

           //}
    }

    #endregion

    #region Ejercicio2
    /*Construir un programa que calcule y muestre los múltiplos menores de 1000 de un número introducido por teclado, 
     * de forma recursiva.  */
    class Ejercicio2

    {
          //public static void MostrarMultiplo  (int numero, int multiplo)
          //{
          //  while (multiplo < 1000 && (multiplo % numero != 0))//caso base
          //  {
          //      multiplo++;
          //  }

          //  if (multiplo % numero == 0)//caso general
          //  {
          //      Console.WriteLine(multiplo);
          //      MostrarMultiplo(numero, multiplo + 1);
          //  }
          //}

          //static void Main()
          // {
            
          //  Console.WriteLine("dime un numero: ");
          //  int numero = int.Parse(Console.ReadLine());
          //  int multiplo = numero;

          //  MostrarMultiplo(numero, multiplo);
          // }
    }

    #endregion

    #region Ejercicio3
    /*Programa que encuentre el primer valor N para el que la suma: 1+2+3+…+N exceda a un valor M que se introduce por teclado. */
    class Ejercicio3

    {


        //static public void PrimerValorQueExcedaM(int numeroBase, int numeroExcede, int suma)
        //{

        //    suma = suma + numeroExcede;

        //    if (suma > numeroBase)//caso base
        //    {
        //        Console.Write($"{numeroExcede} = {suma}\n");
        //        Console.WriteLine($"El primer numero para el que la suma exceda es: {numeroExcede}");


        //    }
        //    else // caso general
        //    {
        //        Console.Write($" {numeroExcede} +");
        //        PrimerValorQueExcedaM(numeroBase, numeroExcede + 1, suma);
        //    }

        //}

        //static void Main()
        //{
        //    int suma = 0;
        //    int numeroExcede = 0;
        //    Console.WriteLine("Dime un numero: ");
        //    int numeroBase = int.Parse(Console.ReadLine());
        //    Console.Write("Suma =");
        //    PrimerValorQueExcedaM(numeroBase, numeroExcede, suma);
        //}
        

    }

    #endregion

    #region Ejercicio4
    /*Escriba una función recursiva para calcular el término n-ésimo de la secuencia: 1, 3, 4, 7, 11, 18, 29, 47, …, Términon donde  Término n =  Término n-1 +  Término n-2*/
    class Ejercicio4

    {
        //static public int TerminoSucesion(int numero)
        //{
        //    int termino = 0;

        //    if (numero == 1)//casos base
        //        termino= numero;
        //    else if (numero == 2)
        //        termino= 3;
        //    else // caso general
        //       termino=
        //            TerminoSucesion(numero - 1) +
        //            TerminoSucesion(numero - 2);

        //    return termino;
        //}

        //static void Main()
        //  {
        //    Console.Write("Dime un numero  para calcular el término n-ésimo de forma recursiva: ");
        //    int numero = int.Parse(Console.ReadLine());

        //    int resultado = TerminoSucesion(numero);

        //    Console.WriteLine($"el resultado es {resultado}");
        // }
    }

    #endregion

    #region Ejercicio5
    /*Escriba una función recursiva para calcular el máximo común divisor de dos números 
     * enteros dados aplicando las propiedades recurrentes.  
     * • Si a>b, entoces m.c.d(a,b)=m.c.d(a-b,b) 
     * • Si a<b, entoces m.c.d(a,b)=m.c.d(a,b-a) 
     * • Si a=b, entoces m.c.d(a,b)=m.c.d(b,a)=a=b */
    class Ejercicio5

    {

        //public static int MCD(int numero1, int numero2)
        // {
        //    int _mcd;
        //     if (numero1>numero2)//caso general
        //     {
        //        _mcd = MCD(numero1-numero2, numero2);
        //     }
        //     else if(numero1<numero2)
        //     {
        //        _mcd = MCD(numero1, numero2 - numero1);
        //     }
        //     else //caso base
        //     {
        //        _mcd=numero1;
        //    }
        //    return _mcd;
        //}

        // static void Main()
        // {
        //     Console.Write("Dime un numero: ");
        //     int numero1 = int.Parse(Console.ReadLine());
        //     Console.Write("Dime otro numero: ");
        //     int numero2 = int.Parse(Console.ReadLine());

        //     int resultado=MCD(numero1, numero2);

        //    Console.WriteLine($"El Máximo común divisor de {numero1} y {numero2} es {resultado}");
        // }

    }

    #endregion

    #region TerminoFibonacci
   
    class Ejercicioff

    {
        /* static public int TerminoSucesionFibonacci(int n)
         {
             int termino;
             if (n <= 2)
                 termino = 1;
             else
                 termino =
                     TerminoSucesionFibonacci(n - 1) +
                     TerminoSucesionFibonacci(n - 2);
             return termino;
         }

         static void Main()
         {
             for (int i = 1; i <=20; i++)
             {
                 n = 8;
                 Console.Write(TerminoSucesionFibonacci(n));
             }
         }*/
    }
        #endregion
}