using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class EjercicioMatrices
    {
        #region Ejercicio1
        /* Crea un programa que cree un array bidimensional de 10 x 10. Inicializa la matriz de forma que las filas 
         * pares se rellenen con unos y las impares a ceros. Una vez inicializada la matriz, muestra su contenido 
         * en pantalla.*/
        class Ejercicio1

        {

            //static public int[,] RellenarMatriz()
            //{
            //   int[,] m= new int[10, 10];

            //    for (int fila = 0; fila < m.GetLength(0); fila++)
            //    {
            //        if (fila % 2 == 0)
            //        {
            //            for (int columna = 0; columna < m.GetLength(1); columna++)
            //            {
            //                m[fila, columna] = 0;
            //            }
            //        }

            //        else
            //        {
            //            for (int columna = 0; columna < m.GetLength(1); columna++)
            //            {
            //                m[fila, columna] = 1;
            //            }
            //        }
            //    }
            //    return m;
            //}

            //static public int[,] MostrarMatriz(int[,] mMostrar)
            //{
            //    mMostrar = new int[10, 10];
               

            //    for (int fila = 0; fila < mMostrar.GetLength(0); fila++)
            //    {
            //        Console.Write($"{fila + 1}. ");
            //        for (int columna = 0; columna < mMostrar.GetLength(1); columna++)
            //        {
            //            Console.Write(mMostrar[fila, columna]);
            //        }
            //        Console.WriteLine();
            //    }
            //    return mMostrar;
            //}
            

            //static void Main()
            //{
            //    int[,] matriz = new int[10, 10];
            //    matriz = RellenarMatriz();
            //    MostrarMatriz(matriz);

                

            //}
        }

        #endregion

        #region Ejercicio2
        /* Crea un programa que cree un array bidimensional de 5 x 5. Inicializa la matriz de forma que los 
         * componentes pertenecientes a la diagonal de la matriz tomen valor uno y el resto valor cero. 
         * Una vez inicializada la matriz, muestra su contenido en pantalla.*/
        class Ejercicio2

        {
            //static public int[,] RellenarMatriz()
            //{
            //    int[,] m = new int[5,5];

            //    for (int fila = 0; fila < m.GetLength(0); fila++)
            //    {                                     
            //                m[fila, fila] = 1;                                                   
            //    }
            //    return m;
            //}


            //static public int[,] MostrarMatriz(int [,] matriz)
            //{
            //    for (int fila = 0; fila < matriz.GetLength(0); fila++)
            //    {
            //        for (int columna = 0; columna < matriz.GetLength(1); columna++)
            //        {
            //            Console.Write(matriz[fila, columna]);
            //        }
            //        Console.WriteLine();
            //    }
            //    return matriz;
            //}


            //static void Main()
            //{
            //    int[,] matriz = new int[5, 5];
            //    matriz = RellenarMatriz();

            //    Console.Write(MostrarMatriz(matriz));
            //}
        }

        #endregion

        #region Ejercicio3
        /* Dada una matriz de 3x5, diseña un programa que lea dicha matriz y posteriormente cree una nueva 
         * matriz a partir de la primera permutando filas por columnas. A esta nueva matriz la llamaremos 
         * matriz traspuesta */
        class Ejercicio3

        {

            //static public int[,] RellenaMatriz(int[,] m)
            //{

            //    for (int fila = 0; fila < m.GetLength(0); fila++)
            //    {
            //        for (int columna = 0; columna < m.GetLength(1); columna++)
            //        {
            //            m[fila, columna] = ;
            //        }
            //    }
            //    return m;
            //}

            //static public int[,] PermutaMatriz(int[,] matriz)
            //{
            //    int[,] matrizTraspuesta = new int[matriz.GetLength(1), matriz.GetLength(0)];

            //    for (int fila = 0; fila < matrizTraspuesta.GetLength(0); fila++)
            //    {
            //        for (int columna = 0; columna < matrizTraspuesta.GetLength(1); columna++)
            //        {
            //            matrizTraspuesta[fila, columna] = matriz[columna, fila];
            //        }
            //    }
            //    return matrizTraspuesta;
            //}


            //static public int[,] MostrarMatriz(int[,] matriz)
            //{
            //    for (int fila = 0; fila < matriz.GetLength(0); fila++)
            //    {
            //        for (int columna = 0; columna < matriz.GetLength(1); columna++)
            //        {
            //            Console.Write($"{matriz[fila, columna]} ");
            //        }
            //        Console.WriteLine("\n");
            //    }
            //    return matriz;
            //}

            //static void Main()
            //{
            //    int[,] matriz = new int[,]
            //        {
            //            {1,2,3,4,5},
            //            {6,7,8,9,10},
            //            {11,12,13,14,15}
            //        };

            //    int[,] matrizTraspuesta = PermutaMatriz(matriz);

            //    MostrarMatriz(matriz);
            //    MostrarMatriz(matrizTraspuesta);

            //}
        }

        #endregion

        #region Ejercicio4
        /* Diseña un programa que ordene los apellidos de 5 personas almacenados en una tabla dentada de 
         * caracteres.*/
        class Ejercicio4
        {
            static char[] Ordena(char[] a)
            {
                char[] ao = new char[a.Length];
                a.CopyTo(ao, 0);

                for (int i = 0; i < ao.Length; i++)
                {
                    int iBurbuja = 0;
                    int topeAscension = ao.Length - i; // Porque ya hay otras burbujas por encima.
                    for (int iSigABurbuja = iBurbuja + 1; iSigABurbuja < topeAscension; iSigABurbuja++)
                    {
                        if (ao[iBurbuja] > ao[iSigABurbuja])
                        {
                            char aux = ao[iBurbuja];
                            ao[iBurbuja] = ao[iSigABurbuja];
                            ao[iSigABurbuja] = aux;
                        }
                        iBurbuja++;
                    }
                    Console.WriteLine(new string(ao));
                }
                return ao;
            }

            static void Main()
            {
                char[][] apellidos = new char[5][]
                {
                    new char[] {'L','o','p','e','z'},
                    new char[] {'G','o','m','e','z'},
                    new char[] {'M','o','n','t','e','s'},
                    new char[] {'P','e','r','e','z'},
                    new char[] {'M','o','n','t','e' }
                };


                for (int i = 0; i < apellidos.Length; i++)
                {

                   

                    Console.WriteLine(apellidos[i]);
                }


                for (int i = 0; i < apellidos.Length; i++)
                {
                    
                   apellidos[i]= Ordena(apellidos[i]);
                    
                    Console.WriteLine(apellidos[i]);
                }
               
            }
        }
        #endregion

        #region Ejercicio5
        /* Dada la siguente tabla dentada: 
         * int[][] m = new int[][]
         * { 
         *  new int [] {1,2,3,4}, 
         *  new int [] {5,6,7}, 
         *  new int [] {9,10,11,12,5}, 
         *  new int [] {9,10}
         * }; 
         * Haz un programa que me busque en la tabla y posteriormente muestre el array con mayor 
         * número de elementos usando solo bucles foreach. Nota: No hace falta que crees ningún método auxiliar*/
        class Ejercicio5
        {
            //static void Main()
            //{
            //    int[][] tablaDentada = new int[][]
            //    {
            //        new int[] { 1, 2, 3, 4 }, 
            //        new int[] { 5, 6, 7 }, 
            //        new int[] { 9, 10, 11, 12, 5 }, 
            //        new int[] { 9, 10 }
            //    };

            //    int[] filaSuperior;

            //    foreach (int[] fila in tablaDentada)
            //    {
            //        foreach (int valor in fila)
            //        {
                      
            //        }                    
            //    }
            //}
        }


        #endregion

        #region Ejercicio6
        /* Crea un programa para mostrar los elementos de la siguiente tabla dentada:
         *  int[][][] tabla = new int[][][] 
         *  {    
         *      new int [][]    
         *      {        
         *          new int [] {1,2,3,4},        
         *          new int [] {5,6,7},        
         *          new int [] {9,10,11,12}    
         *      },    
         *      new int [][]    
         *      {        
         *          new int [] {13,14,15,16},        
         *          new int [] {17,18,19,20},        
         *          new int [] {21,22}    
         *      }, 
         * }; 
         * 
         * Cada tabla se debe mostrar de la siguiente manera. Utiliza las funciones necesarias 
         * para que el código quede claro. 1,2,3,4 5,6,7 9,10,11,12 13,14,15,16 17,18,19,20 21,22*/
        class Ejercicio6
        {


            //static void Main()
            //{

            //}
        }

        #endregion

        #region Ejercicio7
        /*Escribe un programa que se encargue de controlar el aforo de un Multicine: • El Cine tendrá Tres Salas (A, B, C), 
         * en las cuales se pasarán diariamente tres sesiones (1ª, 2ª, 3ª). • El número máximo de personas de cada una de las salas es:
         *   ◦ Sala A = 200 personas. ◦ Sala B = 150 personas. ◦ Sala C = 125 personas. 
         *   • Tendremos un menú con dos opciones: 1.Venta de entradas. 2.Estadística de aforo. 
         *   • Para salir del programa se tendrá que pulsar la tecla ESC. 
         *   • Cada vez que se realice una venta de entradas se pedirá: 
         *   el número de entradas que se van a comprar, para que sala y a que sesión se quiere asistir. 
         *   • Las entradas vendidas quedarán registradas en el array. 
         *   Si el número de entradas sobrepasa el aforo máximo de la sala, se indicará mediante un mensaje por pantalla. 
         *   • En la opción de estadística de aforo, se mostrará una tabla de la siguiente manera: 
         *         Sesión1 Sesión2 Sesión3 
         *   SalaA   178 100 99 
         *   SalaB   12 50 100 
         *   SalaC   32 101 55*/
        class Ejercicio7

        {



            //static void Main()
            //{

            //}
        }

        #endregion

        #region Ejercicio8
        /*Tenemos una tabla dentada de caracteres que tiene almacenados los nombres de 20 países. 
         * Se pide diseñar un programa que realice tantas veces como sea requerido por el usuario la siguiente operación: 
         * Buscar un país y pedir y añadir al final del nombre del país el prefijo telefónico de dicho país 
         * (2 caracteres para el prefijo de teléfono) dejando un espacio en blanco entre el nombre y el código telefónico. 
         * Cuando se acabe el bucle el programa debe presentar en pantalla todos los países en orden alfabético.
         *  Para eso utilizaremos una función con un método de ordenación seleccionado que nos ordene el array*/
        class Ejercicio8

        {

            //public static void ()
            //{
            //}

            // static void Main()
            //{
            //}
        }

        #endregion

        #region Ejercicio9
        /* Realiza un programa que cree una array de dos elementos. Donde cada elemento será una tabla dentada de enteros. El programa pedirá cuantas filas tiene y el número de elementos de cada fila para cada una de las tablas dentadas. Reservará la memoria y rellenará la fila con los elementos generados de forma aleatoria. Posteriormente se mostrará el array de dos matrices dentadas de la siguiente forma: 1,2,3,4 5,6,7 9,10,11,12 13,14,15,16 17,18,19,20 21,22 Recuerda que las tablas se dimensionan con la palabra reservada new*/
        class Ejercicio9

        {

            //public static void ()
            //{
            //}

            // static void Main()
            //{
            //}
        }

        #endregion
    }
}
