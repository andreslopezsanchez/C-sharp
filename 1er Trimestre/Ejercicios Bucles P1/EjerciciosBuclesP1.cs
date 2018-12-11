using System;


namespace EjerciciosBuclesP1

{

    #region Ejercicio1
    /*Programa que calcula y escribe la suma y el producto de los 10 primeros números naturales.*/
    class Ejercicio1

    {
        /*static void Main()
         {
            
            int suma=0, producto=1;

            for (int numero = 1; numero <= 10; numero++)
            {
                suma = numero+suma;
                producto = producto * numero;
            }
            Console.WriteLine($"La suma es {suma} y el producto es {producto:N}");
         }*/
    }

    #endregion

    #region Ejercicio2
    /*2. Programa que lee 100 números y cuenta cuántos de ellos son positivos (n > 0). */
    class Ejercicio2

    {
       /* static void Main()
        {
            float positivos=0, numero;
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"Dime el numero {i+1}: ");
                numero = float.Parse(Console.ReadLine()); 
                if (numero>0)
                {
                    positivos++;
                }
                
            }
            Console.WriteLine($"Hay {positivos} numeros positivos");
        }*/
    }

    #endregion

    #region Ejercicio3
    /*Programa que lea números hasta que se de un cero y escriba la media
     * de los números leídos. Ejemplo de ejecución: 4 6 8 2 0 Media = 5*/
    class Ejercicio3

    {
       /* static void Main()
        {
            int numero, media=0, contador=1, numerosTotales=0;

            do
            {
                Console.Write("Dime numeros para calcular su media (Pulsa 0 para salir y saber resultado):");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    media = (numerosTotales + numero) / contador;
                    contador++;
                    numerosTotales = numerosTotales + numero;
                }
            } while (numero != 0);
            Console.WriteLine($"La media de los {contador-1} numeros es {media}");
        }*/
    }

    #endregion

    #region Ejercicio4
    /*Programa que lee una secuencia de notas (con valores que van de 0 al 10) que
     *termina con el valor -1 y nos dice si hay algún 10 entre ellas.*/
    class Ejercicio4

    {
       /* static void Main()
         {
            float notas, contador = 0, notasCon10=0;

            do
            {
                Console.WriteLine("Dime las notas de tu curso (Pulsa -1 para salir)");
                Console.Write("Notas: ");
                notas = float.Parse(Console.ReadLine());
                if (notas == 10 )
                {
                    notasCon10++;
                }
                contador++;
            } while (notas != -1);
            Console.WriteLine($"De {contador} notas tienes {notasCon10} Sobresalientes");
        }*/
    }

    #endregion

    #region Ejercicio5
    /*Programa que lee una secuencia de 100 números y nos dice cuántos hay 
     *positivos y cuántos negativos (Para hacer las pruebas puedes reducir el número de entradas).*/
    class Ejercicio5

    {
       /* static void Main()
        {
            float positivos = 0, negativos = 0, numero;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Dime el numero {i + 1}: ");
                numero = float.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    positivos++;
                }
                if (numero < 0)
                {
                    negativos++;
                }

            }
            Console.WriteLine($"Hay {positivos} numeros positivos y {negativos} negativos");
        }*/
    }

    #endregion

    #region Ejercicio6
    /*Programa que lee una secuencia de números no nulos, terminada con la introducción de un 0,
     *y obtiene e imprime el mayor.*/
    class Ejercicio6

    {
       /* static void Main()
        {
            int numero, mayor=0;
            bool leidoPrimerNumero = false;
            Console.WriteLine("Dime numeros no nulos(Pulsa 0 para salir y saber el mayor):");
            do
            {
               
                Console.Write("Numeros (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (leidoPrimerNumero == false)
                {
                    leidoPrimerNumero = true;
                    mayor = numero;
                }
                 if (numero>mayor)
                 {
                    mayor = numero;
                 }
                

                if (numero < 0)
                {
                    Console.WriteLine("¡Número no válido! vuelve a intentarlo");
                }
            } while (numero != 0);
            Console.WriteLine($"El numero mayor es {mayor}");
        }*/
    }

    #endregion

    #region Ejercicio7
    /*Programa que lee un número entero positivo y calcula su factorial*/
    class Ejercicio7

    {
        static void Main()
        {
			
			
			Console.Write("Dime un numero para calcular su factorial: ");
			double numero = double.Parse(Console.ReadLine());

            double factorial = 1;
            double contador= numero;
			
			if (numero>0)

			{
				for (int i = 0; i <numero ; i++)
				{
					factorial= factorial*contador;
					contador--;
                    
				}
			}
			Console.WriteLine($"El factorial de {numero} es {factorial}");
			
		}
    }

    #endregion

    #region Ejercicio8
    /*Programa que obtenga el producto de dos números enteros positivos mediante sumas sucesivas.
     *Esto es, para calcular 2 x 5 haga 2 + 2 + 2+ 2 + 2*/
    class Ejercicio8

    {
       /* static void Main()
        {
			int producto=0;
			Console.Write("Dime un numero: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Dime otro: ");
			int numero2 = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < numero2 ; i++)
			{
				
				producto= producto + numero;
			}
			Console.WriteLine($"{numero}X{numero2}={producto}");
			
		}*/
    }

    #endregion

    #region Ejercicio9
    /*Programa que obtenga el cociente y el resto de dos números enteros positivos 
     * mediante restas. Esto es, para calcular n / 2 haga n -= 2 mientras n >= 2 
     * y cuente el número de restas*/
    class Ejercicio9

    {
       /* static void Main()
        {
			int division=0;
			Console.Write("Dime un numero: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Dime otro: ");
			int numero2 = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < numero2 ; i++)
			{
				
				division= division - numero;
			}
			Console.WriteLine($"{numero}/{numero2}={division}");
		}*/
    }

    #endregion

    #region Ejercicio10
    /* Programa que lee un número n de (1 a 9) e imprime su tabla de multiplicar*/
    class Ejercicio10

    {
        /*static void Main()
        {
            int numero;
            Console.Write("Dime un numero del uno al 9 para saber su tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero}x{i}={numero * i}");
            }
        }*/
    }

    #endregion

    #region Ejercicio11
    /*Programa que te diga si un número,  introducido por teclado, es primo.*/
    class Ejercicio11

    {
       /* static void Main()
        {
            Console.Write("Dime un numero: ");
            int numero = int.Parse(Console.ReadLine());
            bool hayDivisores = false;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    hayDivisores = true; 
                    break;
                }
            }

            Console.WriteLine(!hayDivisores ? "Es Primo" : "No es Primo");
        }*/
    }

    #endregion

    #region Ejercicio12
    /*Programa que determina si dos números enteros positivos son amigos. 
     *(Dos números son amigos si la suma de los divisores del  primero, excepto él mismo, 
     *es igual al segundo, y viceversa).*/
    class Ejercicio12

    {
        /*static void Main()
        {
            int numero1, numero2;
            int divisoresNumero1=0;
            int divisoresNumero2=0;

            Console.Write("Dime el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero1; i++)
            {
               if(numero1 % i == 0);
                divisoresNumero1 = divisoresNumero1 + i;
            }

            for (int i = 1; i < numero2; i++)
            {
                if (numero2 % i == 0) ;
                divisoresNumero2 = divisoresNumero2 + i;
            }


            if (divisoresNumero1==divisoresNumero2)
            {
                Console.WriteLine("Son amigos");
            }
            else
            {
                Console.WriteLine("No son amigos");
            }
        }*/
    }

    #endregion

    #region Ejercicio13
    /*Haz un programa que muestre en pantalla la tabla de códigos UTF-8
     HEX   DEC   CAR 
     0x20  32 
     0x22  34    " 
     0x24  36    $ 
     0x26  38    & 
     0x28  40    ( 
     0x2a  42    * 
     0x2c  44    , 
     … Así hasta 255 (256 caracteres). 
     Nota: Se parará la pantalla cuando sea necesario para que se puedan ver todos los caracteres*/
    class Ejercicio13

    {
        /*static void Main()
        {
            Console.WriteLine("HEX  DEC  CAR");
            for (double i = 0; i <= 255; i++)
            {
                Console.WriteLine($"{i:X4}  {i}  {char()}");

                if 

            }
        }*/
    }

    #endregion

    #region Ejercicio14
    /* Simulación de una calculadora. Realiza un programa que sea capaz de sumar, 
     * restar, multiplicar y dividir. El programa presentará un menú, en un bucle 
     * para salir con ESC, con las cuatro operaciones que puede realizar*/
    class Ejercicio14

    {
       /* static void Main()
        {
            int opcion = 0;
            do
            {
                
                Console.WriteLine("1 .-Sumar");
                Console.WriteLine("2 .-Restar");
                Console.WriteLine("3 .-Multiplicar");
                Console.WriteLine("4 .-Dividir");
                Console.WriteLine("0 .-Salir");
                Console.Write("Dime que opcion quieres: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch(opcion)
                {
                    case 1:
                    {
                            Console.WriteLine("Sumar:");
                            Console.Write("Dime un numero: ");
                            int numero1 = int.Parse(Console.ReadLine());
                            Console.Write("Dime otro numero: ");
                            int numero2 = int.Parse(Console.ReadLine());

                            Console.Write($"{numero1}+{numero2}={numero1 + numero2}\n\n");

                            break;
                    }
                    case 2:
                    {
                            Console.WriteLine("Restar:");
                            Console.Write("Dime un numero: ");
                            int numero1 = int.Parse(Console.ReadLine());
                            Console.Write("Dime otro numero: ");
                            int numero2 = int.Parse(Console.ReadLine());

                            Console.Write($"{numero1}-{numero2}={numero1 - numero2}\n\n");

                            break;
                        }
                    case 3:
                    {
                            Console.WriteLine("Multiplicar:");
                            Console.Write("Dime un numero: ");
                            int numero1 = int.Parse(Console.ReadLine());
                            Console.Write("Dime otro numero: ");
                            int numero2 = int.Parse(Console.ReadLine());

                            Console.Write($"{numero1}*{numero2}={numero1 * numero2}\n\n");

                            break;
                        }
                    case 4:
                    {
                            Console.WriteLine("Dividir:");
                            Console.Write("Dime un numero: ");
                            int numero1 = int.Parse(Console.ReadLine());
                            Console.Write("Dime otro numero: ");
                            int numero2 = int.Parse(Console.ReadLine());

                            Console.Write($"{numero1}/{numero2}={numero1 / numero2}\n\n");

                            break;
                        }

                }

                    
            } while (opcion!= 0);
        }*/
    }

    #endregion

    #region Ejercicio15
    /*Imprimir los múltiplos de 7 que hay entre 7 y 112.*/
    class Ejercicio15

    {
       /* static void Main()
        {
            Console.WriteLine("Múltiplos de 7 entre 7 y 112");
            for (int i = 1; ; i++)
            {
                
                int resultado = 7 * i;
                if (resultado <= 112)
                {
                    Console.WriteLine($"{resultado} ");
                }
                else
                    break;
            }
        }*/
    }

    #endregion

    #region Ejercicio16
    /* Pide un número, por ejemplo el 4, y saca en pantalla 1223334444. (Hazlo con un for).*/
    class Ejercicio16

    {
        /*static void Main()
        {
            Console.Write("Dime un numero: ");
            int numero = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                   
                   Console.Write($"{i}");
                }
            }
        }*/
    }

    #endregion

    #region Ejercicio17
    /*Lee un número y escribe la suma de sus dígitos*/
    
    class Ejercicio17

    {
       /* static void Main()
        {
			Console.Write("Dime un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int suma=0;
            
            
            if (numero>10)
			{
			
					while(numero!=0)
					{
					int resto= numero%10;
					suma =	suma+resto;
					numero = numero/10;
					}
					
			}
			else
				suma=numero;
          
            Console.WriteLine($"La suma de sus digitos es {suma} ");
            
		}*/
    }

    #endregion

    #region Ejercicio18
    /*Imprimir un tablero de ajedrez y sobre él marcar con * las celdas a las que se puede mover un
     *alfil desde una posición dada. Ten en cuenta que en ajedrez las filas son numéricas del 1 al 8 
     *y las columnas letras de la A  a la H. 
     *Aunque no es necesario, si quieres imprimir colores en el terminal puedes usar 
     *las propiedades de consola:
            Console.BackgroundColor = ConsoleColor.Color; 
            Console.ForegroundColor = ConsoleColor.Color; 
     Además, puedes imprimir en una posición específica en pantalla con.
            Console.SetCursorPosition(Columna, Fila);*/
    class Ejercicio18

    {
       /* static void Main()
        {
            Console.Write("Introduce fila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Introduce columna (A-H): ");
            char columna = char.Parse(Console.ReadLine());

            Console.Write(" ");
            for (int i = 0; i < 8; i++)
            {
                char tabla = (char)('A' + i);
                Console.Write(numero);   
            }
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; ji++)
                {

                }
            }
        }*/
    }

    #endregion

    #region Ejercicio19
    /**/
    class Ejercicio19

    {
        /*static void Main()
        {
 }*/
    }

    #endregion

    #region Ejercicio20
    /**/
    class Ejercicio20

    {
        /*static void Main()
        {
 }*/
    }

    #endregion

    #region Ejercicio21
    /**/
    class Ejercicio21

    {
        /*static void Main()
        {
 }*/
    }

    #endregion

    #region AmpliacionBucle
    /**/
    class AmpliacionBucle

    {
        /*static void Main()
        {
            int numeroEnLista;
            int numero = int.Parse(Console.ReadKey().KeyChar.ToString());
            bool estaEnLista = false;
            bool estaizquierda = true;
            bool estaDerecha = false;
            bool estaIntercalado = false;

            Console.Write(" en ");
            do
            {
                numeroEnLista = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Write(" ");

                if (numeroEnLista!=0)
                {
                    if (numero == numeroEnLista)
                        estaEnLista = true;
                    else if (numero>numeroEnLista)
                    {
                        estaizquierda = false;
                    }
                    else if (numero < numeroEnLista && estaizquierda==false)
                    {
                        estaIntercalado = true;
                    }
                }

            } while (numeroEnLista!=0);

            if (!estaizquierda && !estaIntercalado && !estaEnLista)
            {
                estaDerecha = true;
            }


            string mensaje;
            if (estaEnLista)
                mensaje = "\nEn la lista.";
            else
            {
                mensaje = "\nFuera de la lista";
                if (estaizquierda)
                    mensaje += " a la izquierda";
                if (estaIntercalado) 
                    mensaje += " esta intercalado";
                if (estaDerecha)
                    mensaje += " a la derecha";
            }
            Console.WriteLine(mensaje);
        }*/
    }

    #endregion

}
