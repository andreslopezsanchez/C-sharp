using System;


namespace EjerciciosMetodos


{

    #region Ejercicio1
    /* Diseña un método denominado Eleva, que calcule x elevado a n, dados ambos como parámetro. 
     * Una vez definida, integra dicho método en un programa que calcule e imprima el resultado de 
     * la expresión a la derecha. Siendo x, y, m tres números enteros introducidos por teclado.*/
    class Ejercicio1

    {

      /*  public static double Eleva(double _base, double exponente)
        {
            double potencia = 1;

            if (exponente > 0)
                for (int i = 0; i < exponente; i++)
                    potencia = potencia * _base;

            return potencia;
        }

        static void Main()
        {
            Console.WriteLine("Teniendo la funcion: (x^4 + y^m) / 2");
            Console.Write("Dime x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Dime y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Dime m:");
            double m = double.Parse(Console.ReadLine());

            double resultado = (Eleva(x, 4) + Eleva(y, m)) / 2;
            Console.WriteLine($"El resultado es {resultado}");
        }*/
    }

    #endregion

    #region Ejercicio2
    /* Escribe un algoritmo que, dados por teclado cinco días de la semana, escritos en forma de 
     * número (de 1 a 7), escriba por pantalla el nombre del día asociado a cada uno de ellos. 
     * Para ello, escribe y utiliza el método (DiaSemana) que, dado un número entre uno y siete, 
     * escriba en pantalla el día correspondiente (utilizando switch). */
    class Ejercicio2

    {
      /*  public static string DiaSemana(int numeroSemana)
        {
            string mensaje= "";
            switch (numeroSemana)
            {
                case 1:
                    mensaje = "Lunes";
                    break;
                case 2:
                    mensaje = "Martes";
                    break;
                case 3:
                    mensaje = "Miercoles";
                    break;
                case 4:
                    mensaje = "Jueves";
                    break;
                case 5:
                    mensaje = "Viernes";
                    break;
                case 6:
                    mensaje = "Sábado";
                    break;
                case 7:
                    mensaje = "Domingo";
                    break;
            }
            return mensaje;
        }

        static void Main()
         {
            Console.Write("Dime un numero del 1 al 7 y te diré que día de la semana es: ");
            int numeroSemana = int.Parse(Console.ReadLine());

            string DiaElegido = DiaSemana(numeroSemana);

            Console.WriteLine(DiaElegido);

         }*/
    }

    #endregion

    #region Ejercicio3
    /*Escribe el resultado de ejecutar este programa y comenta por que se produce. */
    class Ejercicio3

    {
      /*public const int n = 5; 
        public static int b = 2, a = 3;

        static int funcion(int b) 
        { 
            int c; 
            c = b + a;
            b++; 
            return c; 
        }

        static void Main() 
        { 
            int i; 
            for (i = 0; i < n; i++)
                b = funcion(i);
            Console.WriteLine(b);
        } */
        
        /*Mostrara el 7 porque */
     }  

    #endregion

    #region Ejercicio4
    /**/
    class Ejercicio4

    {
        /* static void Main()
          {
            
         }*/
    }

    #endregion

    #region Ejercicio5
    /* Implementa un programa en C# con un método que admita como argumento dos números enteros 
     * (m y n) y devuelva como valor asociado al nombre de la función el número combinatorio. 
     * Este método debe llamar a su vez al método factorial (que devolverá el factorial de un 
     * número pasado como argumento).*/
    class Ejercicio5

    {
        /*        
        public static double Factorial(double numero)
        {
            double factorial = 1;
            double contador = numero;

            if (numero > 0)
            {
                for (int i = 0; i < numero; i++)
                {
                    factorial = factorial * contador;
                    contador--;
                }
            }          
            return factorial;
        }


        public static double Formula(double numero1, double numero2)
        {
            double resultado = Factorial(numero1) / (Factorial(numero2) * Factorial(numero1-numero2));
            return resultado;
        }

        static void Main()
        {
            Console.WriteLine("Teniendo la funcion: m! / (n!(m-n)!)");
            Console.Write("Dime m:");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Dime n:");
            double n = double.Parse(Console.ReadLine());

            double resultado = Formula(m, n);

            Console.WriteLine($"El resultado es {resultado}");
        }
       */ 
    }

    #endregion

    #region Ejercicio6
    /* Crea un método que cambie de formato una fecha: dados el día, mes y año que devuelva un 
     * número entero tipo long (ej: 2/4/1997 sería 19970402). Dada esta función, diseña un programa 
     * que solicite dos fechas de nacimiento y averigüe cual de las dos personas es mayor.*/
    class Ejercicio6

    {
        
      /*  public static void PedirFechaNacimiento(out int dia, out int mes, out int año)
        {
            Console.Write("Dime el día en el que naciste ej:2/4/1997: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Dime ahora el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Y por último tu año: ");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public static long NumeroFechaNacimiento(int dia, int mes, int año)
        {
            
            long añoTotal = año * 10000;
            long mesTotal = mes * 100;
            long fechaTotal= añoTotal + mesTotal + dia;
            return fechaTotal;
        }


        static void Main()
         {
            int dia, mes, año;
            long persona1=0, persona2=0;
                        
            for (int i =1; i <=2 ; i++)
            {
                Console.WriteLine($"Datos de PERSONA{i}");
                PedirFechaNacimiento(out dia, out mes, out año);

                if (i == 1)
                    persona1 = NumeroFechaNacimiento(dia, mes, año);
                else
                    persona2 = NumeroFechaNacimiento(dia, mes, año);
            }
            long resultado;
            if (persona1 > persona2)
                resultado = persona1;
            else
                resultado = persona2;

            Console.WriteLine($"Siendo la fecha de la primera persona {persona1}\n" +
                               $"Y la fecha de la seguna persona {persona2}\n" +
                               $"El mayor es {resultado}");

        }*/
    }

    #endregion

    #region Ejercicio7
    /* Escribe un programa para jugar a adivinar números. Nota:  Será necesario realizar los métodos 
     * y el paso de parámetros que consideres adecuado para una correcta programación El programa 
     * tiene que seguir los siguientes pasos: 
     * 1. Calcular de forma aleatoria el número que el jugador debe adivinar. 
     * El número debe hallarse  entre 0 y 50 (ambos inclusive). 
     * 
     * 2. Preguntar números al jugador contestando si son mayores o menores que el número a adivinar. 
     *
     * 
     * 3. Si el jugador acierta el número, la partida terminará indicando la cantidad de tentativas 
     * hechas por este jugador para acertar. 
     * 
     * 4. Habrá un máximo de tentativas dependiendo del nivel elegido para jugar: 
     * (fácil =10, medio = 6, difícil = 4). 
     * 
     * 5. El programa preguntará si se desea seguir jugando. Si se responde que sí el juego seguirá 
     * pidiendo un nuevo nivel y generando otro número. 
     * 
     *6. Para salir abra que pulsar ESC. 
     * 
     * Consideraciones: Forma de controlar la pulsación en consola de la tecla ESC con C#..*/
    class Ejercicio7
    {
          public static void PedirNumeroRandom (out int _random)
          {
		  Random semilla = new Random();
             _random = semilla.Next(0, 50);
		  }     
          
          public static void PedirDificultad(out int cantidad)
		  {
			Console.WriteLine("¿A qué nivel quieres jugar? Introduce(F/M/D):" +
							  " \nF=Fácil(10 INTENTOS) \nM=Medio(6 INTENTOS) \nD=Difícil(4 INTENTOS)");
            char dificultad = char.Parse(Console.ReadLine());
            cantidad=0;

            switch (dificultad)
            {
                case 'f':
                case 'F':
                    cantidad= 10;
                    break;
                case 'm':
                case 'M':
                    cantidad = 6;
                    break;
                case 'd':
                case 'D':
                    cantidad = 4;
                    break;
            }
            Console.WriteLine();
        }
          
		  public static void AveriguarNumero(out int numero, int cantidadDificultad, int numeroAleatorio)
		  {
				do
			{
            Console.Write("Dime un numero entre 0 Y 50: ");
             numero = int.Parse(Console.ReadLine());

            if (numero>numeroAleatorio)
				Console.WriteLine("El numero que has introducido es mayor");
			else if (numero<numeroAleatorio)
				Console.WriteLine("El numero que has introducido es menor");
			else
			{
				Console.WriteLine("¡ENHORABUENA!");
				break;
			}
			
			cantidadDificultad--;
			Console.WriteLine($"Te quedan {cantidadDificultad} intentos");
            
            }while(cantidadDificultad!=0);
		  }
          static void Main()
          {

            
			int cantidadDificultad, numeroAleatorio, numeroUsuario;
            
            PedirNumeroRandom(out numeroAleatorio);
            PedirDificultad(out cantidadDificultad);
			AveriguarNumero(out numeroUsuario, cantidadDificultad, numeroAleatorio);
// me falta por poner el escape u pedir si quiere volver a jugar

          }
    }

    #endregion

    #region Ejercicio8
    /*Escribe un programa que lea un número en base 10 y que posteriormente muestre un menú que nos permita convertirlo 
     * a base dos, base ocho o hexadecimal. Crea un método llamado PasaABinario, otro llamado PasaAOctal y otro llamado 
     * PasaAHexadecimal para realizar dichas operaciones. Todos los métodos devolverán un string que contendrá los dígitos 
     * resultantes de la conversión. Nota: No se puede usar el método Convert existente ya en C#*/
    class Ejercicio8

    {

        static public string PasaAbinario(int numero)
        {
            int resto=0;
            string representacionBinario="";

            while (numero>0)
            {
              
                resto = numero % 2;
                numero = numero / 2;
                representacionBinario = representacionBinario + resto;

            }
            return representacionBinario;
        }

        static public string PasaAOctal(int numero)
        {
            int resto = 0;
            string representacionOctal = "";

            while (numero > 0)
            {

                resto = numero % 8;
                numero = numero / 8;
                representacionOctal =  resto + representacionOctal;

            }
            return representacionOctal;
        }

        static public string PasaAHexadecimal(int numero)
        {
			   int resto = 0;
            string representacionHexadecimal = "";

            while (numero > 0)
            {

                resto = numero % 8;
                numero = numero / 8;
                representacionHexadecimal =  resto + representacionHexadecimal;

            }
            
            switch ()
			{
				case 10: 
					representacionHexademical = 'A';					
					break;
				case 11: 
					representacionHexademical = 'B';					
					break;
				case 12: 
					representacionHexademical = 'C';					
					break;
				case 13: 
					representacionHexademical = 'D';					
					break;	
				case 14: 
					representacionHexademical = 'E';					
					break;
				case 15: 
					representacionHexademical = 'F';					
					break;
									
				default:
					break;
					
			}
			
            return representacionHexadecimal
        }



        static void Main()
         {
            Console.Write("Dime un numero: ");
            int numero = int.Parse(Console.ReadLine());

            string numeroBinario = PasaAbinario(numero);
            string numeroOctal = PasaAOctal(numero);
           string numeroHexadecimal = PasaAHexadecimal;

           Console.WriteLine($"Numero en binario:{numeroBinario}" +
                              $"\nNumero en Octal:{numeroOctal}"); + 
                              $"Numero en Hexadecimal: {numeroHexadecimal}");

         } 
    }

    #endregion

    #region Ejercicio9
    /**/
    class Ejercicio9

    {
        /* static void Main()
         {
            
         }*/
    }

    #endregion

}
