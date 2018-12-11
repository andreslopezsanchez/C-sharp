using System;
using System.Text;


namespace ConsoleApplication9
{
    class EjerciciosArrays
    {
        #region Ejercicio1
        /* Realiza un programa que asigne datos aleatoriamente a un array de n elementos, 
         * y a continuación muestre el contenido de dicho array utilizando la instrucción foreach. 
         * Para generar un número aleatorio, puedes usar la función: 
         * 
         * Random.Next(int minValue, int maxValue)*/
        class Ejercicio1

        {
            //static void Main()
            //{
            //    Console.Write("Dime de cuanto quieres que sea el array: ");
            //    int longitudArray = int.Parse(Console.ReadLine());

            //    int[] arrayDatos = new int[longitudArray];

            //    Random semilla = new Random();
            //    foreach (int elemento in arrayDatos)
            //    {
            //        int numeroAleatorio = semilla.Next(int.MinValue, int.MaxValue);
            //        arrayDatos[elemento] = numeroAleatorio;
            //        Console.WriteLine(arrayDatos[elemento]);
            //    }


            //}
        }

        #endregion

        #region Ejercicio2
        /*Rellena un array de 10 caracteres de forma aleatoria y visualízalos de cuatro en cuatro*/
        class Ejercicio2

        {

            //static void Main()
            //{

            //    char[] arrayDatos = new char[10];

            //    Random semilla = new Random();
            //    for (int i= 0; i < 10; i++)
            //    {
            //        char numeroAleatorio = (char)(semilla.Next(47, 165));
            //        arrayDatos[i] = numeroAleatorio;
            //        Console.Write(arrayDatos[i]);
            //        if ((i+1) % 4 == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }

        #endregion

        #region Ejercicio3
        /*Programa que sume los valores de un array de 10 elementos reales. */
        class Ejercicio3

        {

            //static void Main()
            //{
            //    Random semilla = new Random();
            //    int[] arrayDatos = new int[10];
            //    int suma = 0;

            //    for (int i = 0; i < 10; i++)
            //    {
            //        int valorAleatorio = semilla.NextDouble(0, 10);
            //        arrayDatos[i] = valorAleatorio;
            //        suma = suma + arrayDatos[i];

            //        Console.Write($"{arrayDatos[i]} + ");
            //        if (i == 9)
            //            Console.Write($"{arrayDatos[i]} = {suma = suma + arrayDatos[i]} \n");
            //    }

            //}
        }

        #endregion

        #region Ejercicio4
        /* Rellena un array de 10 caracteres de forma aleatoria y luego sobre el mismo array 
         * modifícalo de forma que los elementos que estén en mayúsculas pasen a ser minúscula y 
         * los minúscula a mayúscula. Visualízalo con la instrucción foreach.*/
        class Ejercicio4
        {
            //public static char GeneraLetraAleatoria(Random semillaCaracteres)
            //{
            //    char[] parLetras = new char[2];
            //    parLetras[0] = (char)(semillaCaracteres.Next(65, 91));
            //    parLetras[1] = (char)(semillaCaracteres.Next(97, 123));
            //    return parLetras[semillaCaracteres.Next(0, 2)];
            //}

            //public static char[] CambiaMayusculasPorMinusculas(char[] datos)
            //{

            //    char[] datosAux = new char[datos.Length];
            //    datos.CopyTo(datosAux, 0);


            //    for (int i = 0; i < datosAux.Length; i++)
            //    {
            //        if (Char.7Upper(datos[i]))
            //        {
            //            datosAux[i] = char.ToLower(datosAux[i]);
            //        }
            //        else
            //        {
            //            datosAux[i] = char.ToUpper(datosAux[i]);
            //        }

            //    }
            //    return datosAux;
            //}

            //static void Main()
            //{
            //    char[] datos = new char[10];
            //    Random semillaCaracteres = new Random();

            //    Console.Write("El array original es: ");
            //    for (int i = 0; i < datos.Length; i++)
            //    {
            //        datos[i] = GeneraLetraAleatoria(semillaCaracteres);
            //        Console.Write(datos[i]);
            //    }
            //    Console.WriteLine();

            //    Console.Write("Cambiando mayúsculas y minúsculas: ");
            //    char[] datosModificados = CambiaMayusculasPorMinusculas(datos);

            //    for (int i = 0; i < datosModificados.Length; i++)
            //    {
            //        Console.Write(datosModificados[i]);
            //    }

            //    Console.WriteLine();
            //}
        }
            #endregion

        #region Ejercicio5
        /* Carga un array numérico de diez elementos, visualízalo con la instrucción foreach y luego 
         * visualiza los elementos cuyo contenido sea par, indicando su posición*/
         class Ejercicio5
         {

            //public static int[] GeneraNumerosAleatorios(Random semilla, int[] datos)
            //{

            //    for (int i = 0; i < datos.Length; i++)
            //    {
            //        int numeroAleatorio = semilla.Next(1, 50);
            //        datos[i] = numeroAleatorio;
            //    }
            //    return datos;
            //}

            //public static int[] MuestraArray(int posicion, int[] datos)
            //{
            //    foreach (int elemento in datos)
            //    {

            //        Console.WriteLine($"{posicion}. {elemento}");
            //        posicion++;
            //    }
            //    return datos;

            //}

            //public static int[] MuestraParesYPosicion(int posicion, int[] datos)
            //{
            //    Console.WriteLine("son pares y su posicion es: ");

            //    for (int i = 0; i < datos.Length; i++)
            //    {
            //        if (datos[i] % 2 == 0)
            //        {
            //            Console.WriteLine($"Posicion:{i + 1}   Numero:{datos[i]}");
            //        }

            //    }
            //    return datos;
            //}
            //static void Main()
            //{
            //    int[] datos = new int[10];
            //    Random semilla = new Random();
            //    Console.WriteLine("Numeros: ");
            //    int posicion = 1;

            //    GeneraNumerosAleatorios(semilla, datos);

            //    MuestraArray(posicion, datos);                                 

            //    MuestraParesYPosicion(posicion, datos);

            //}

        }


        #endregion

        #region Ejercicio6
        /* Crea un array de 10 elementos, visualiza el elemento mayor de la serie y la posición que ocupa. 
         * Si hay varios iguales, sólo el primero.*/
        class Ejercicio6
        {

            //public static int[] GeneraNumerosAleatorios(Random semilla, int[] datos)
            //{

            //    for (int i = 0; i < datos.Length; i++)
            //    {
            //        int numeroAleatorio = semilla.Next(1, 50);
            //        datos[i] = numeroAleatorio;
            //    }
            //    return datos;
            //}

            //public static int[] MuestraArray(int posicion, int[] datos)
            //{
            //    foreach (int elemento in datos)
            //    {

            //        Console.WriteLine($"{posicion}. {elemento}");
            //        posicion++;
            //    }
            //    return datos;

            //}

            //public static int[] MuestraNumeroMayor(int posicion, int numeroAlto, int[] datos)
            //{
            //    for (int i = 0; i < datos.Length; i++)
            //    {
            //        if (datos[i] > numeroAlto)
            //        {
            //            numeroAlto = datos[i];
            //            posicion = i + 1;
            //        }

            //    }
            //    Console.WriteLine($"El numero mas alto de la serie es {numeroAlto} en la posicion {posicion}");
            //    return datos;
            //}

            //static void Main()
            //{
            //    int[] datos = new int[10];
            //    Random semilla = new Random();
            //    int posicion = 1;
            //    int numeroAlto = 0;

            //    GeneraNumerosAleatorios(semilla, datos);
            //    MuestraArray(posicion, datos);
            //    MuestraNumeroMayor(posicion, numeroAlto, datos);
               

               
            //}
        }

            #endregion

        #region Ejercicio7
            /* Crea un array aleatorio de enteros con 10 elementos y llámalo V. 
             * • Con los elementos pares crea un array P y tras ordenalo en sentido creciente y 
             *   lo visualizas. 
             * • Con los elementos impares crea un array I y tras ordenalo en sentido decreciente y 
             *   lo visualizas.*/
            class Ejercicio7

            {

            public static int[] GeneraNumerosAleatorios(Random semilla, int[] datos)
            {

                for (int i = 0; i < datos.Length; i++)
                {
                    int numeroAleatorio = semilla.Next(1, 50);
                    datos[i] = numeroAleatorio;
                }
                return datos;
            }

            public static int[] MuestraArray(int posicion, int[] datos)
            {
                foreach (int elemento in datos)
                {

                    Console.WriteLine($"{posicion}. {elemento}");
                    posicion++;
                }
                return datos;

            }

            public static void MuestraPares(int[] datos)
            {

                int i = 0, j = 0;
                Console.WriteLine("PARES: ");
                foreach (int numero in datos )
                {
                    if (numero % 2 == 0)
                    {
                        i++;
                    }
                }

                int[] datosAux = new int[i];

                foreach (int numeroPar in datos)
                {
                    if (numeroPar % 2 == 0)
                    {
                        datosAux[j] = numeroPar;
                        j++;
                    }
                }

                Array.Sort(datosAux);
                

                foreach (int numeroParOrdenado in datosAux)
                {
                    Console.WriteLine($"{numeroParOrdenado}");
                }
               
            }

            public static void MuestraImpares(int[] datos)
            {

                int i = 0, j = 0;
                Console.WriteLine("IMPARES: ");
                foreach (int numero in datos)
                {
                    if (numero % 2 != 0)
                    {
                        i++;
                    }
                }

                int[] datosAux = new int[i];

                foreach (int numeroPar in datos)
                {
                    if (numeroPar % 2 != 0)
                    {
                        datosAux[j] = numeroPar;
                        j++;
                    }
                }

                Array.Sort(datosAux);
                Array.Reverse(datosAux);

                foreach (int numeroParOrdenado in datosAux)
                {
                    Console.WriteLine($"{numeroParOrdenado}");
                }

            }

            static void Main()
            {
                int[] datos = new int[10];
                Random semilla = new Random();
                int posicion = 1;
               

                GeneraNumerosAleatorios(semilla, datos);
                MuestraArray(posicion, datos);
                MuestraPares(datos);
                MuestraImpares(datos);


            }
        }

        #endregion

        #region Ejercicio8
        /* Implementa un programa en C# que dada un número entero sin signo introducido 
         * por teclado me diga si es capicúa. Un ejemplo de ejecución sería... 
         * 
         * Número: 1234321 
         * Es capicúa.
         * 
         * Puedes usar el siguiente código para leer un número en forma de array de caracteres. 
         * char[] numero = Console.ReadLine().ToCharArray()*/
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
            /* Crea  un menú con tres opciones: 1. Introducir contraseña. 2. Pedir contraseña. 3. Salir del programa.
             * Si seleccionamos la primera opción aparecerá una ventana que te pida una contraseña que tendrás que repetir 
             * para darla cómo válida. Mientras que estás escribiendo la contraseña solamente se verán los caracteres *****
             * 
             * Tras validarla, la contraseña se guardará en un array.
             * 
             * En la opción de Pedir contraseña, introducirás una cadena por teclado y se comprobará si la cadena 
             * introducida es igual a la contraseña guardada en el array*/
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

        #region Ejercicio10
            /* Escribe un programa en C# que acepte una línea de texto y escriba su traducción al ‘King Latin’. 
             * Supondremos que cada mensaje en ‘King latin’ puede estar contenido en una línea de 80 columnas. 
             * Por tanto,l El mensaje original debe constar de cómo máximo 80 caracteres con un solo espacio en blanco 
             * entre cada dos palabras sucesivas. Ten en cuenta que el mensaje en ‘King Latin’ tendrá mayor longitud ya 
             * que aoadimos las aes después de cada palabla. Deberemos utiliar al menos las siguientes funciones:  
             * LeeEntrada,  CuentaPalabras, ConviertePalabras, EscribeSalida.*/
            class Ejercicio10

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

