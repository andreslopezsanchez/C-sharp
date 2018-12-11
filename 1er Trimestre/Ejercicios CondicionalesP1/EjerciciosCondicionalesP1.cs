using System;


namespace EjerciciosCondicionalesP1

{

    #region Ejercicio1
    /*Pide dos números enteros y di cual es el mayor. 
     Realiza el ejercicio de dos formas diferentes: 1. Utilizando un if 2. Utilizando el operador ternario ?:*/
    class Ejercicio1

    {
        /* static void Main()
         {
             int numero1, numero2, mayor=0;
        

             Console.Write("Dime el primer numero: ");
             numero1 = int.Parse(Console.ReadLine());

             Console.Write("Dime el segundo numero: ");
             numero2 = int.Parse(Console.ReadLine());

			 if (numero1 > numero2)
                mayor = numero1;
            
             else if (numero2 > numero1)
                mayor=numero2;
           
                
             Console.WriteLine($"Utilizando el if el numero mayor es {mayor}");

             int operacion = (numero1>numero2) ? numero1 : numero2;

             Console.WriteLine($"Con el metodo ternario el numero mayor es {operacion}");
         
         }*/
    }

    #endregion

    #region Ejercicio2
    /*Pide dos letras y di si son iguales o distintas*/
    class Ejercicio2

    {
        /*static void Main()
          {
            char letra1, letra2;
			string mensaje;

            Console.Write("Dime una letra: ");
            letra1 = char.Parse(Console.ReadLine());

            Console.Write("Dime otra letra: ");
            letra2 = char.Parse(Console.ReadLine());

            if (letra1 == letra2)
                mensaje = "¡Son iguales!";

            else 
                mensaje = "Son distintos";
      
			Console.WriteLine(mensaje);
        }*/
    }

    #endregion

    #region Ejercicio3
    /*Se piden dos números, si el primero es mayor que el segundo se calcula su resta, sino se calcula su suma*/
    class Ejercicio3

    {
         /*static void Main()
         {
            int numero1, numero2;
            
            Console.Write("Dime un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Dime otro numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1>numero2)
            {
                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            }
            else
            {
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            }
         }*/
    }

    #endregion

    #region Ejercicio4
    /*Se piden tres números. Saldrán en pantalla tres mensajes: 
El mayor es: ... 
El mediano es: ...
El menor es: ...*/
    class Ejercicio4

    {
       /*  static void Main()
         {
            int numero1, numero2, numero3;
            Console.Write("Dime el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Dime el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Dime el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 == numero2 && numero2 == numero3)
                Console.WriteLine("Todos los numeros son iguales");
            else if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
                Console.WriteLine("Dos de los numeros son iguales");


            else if (numero1 > numero2 && numero2>numero3)
                Console.WriteLine($"El mayor es:{numero1} \nEl mediano es:{numero2} \nEl menor es:{numero3}");

            else if (numero1 > numero3 && numero3 > numero2)
                Console.WriteLine($"El mayor es:{numero1} \nEl mediano es:{numero3} \nEl menor es:{numero2}");

            else if (numero2 > numero1 && numero1 > numero3)
                Console.WriteLine($"El mayor es:{numero2} \nEl mediano es:{numero1} \nEl menor es:{numero3}");

            else if (numero2 > numero3 && numero3 > numero1)
                Console.WriteLine($"El mayor es:{numero2} \nEl mediano es:{numero3} \nEl menor es:{numero1}");

            else if (numero3 > numero2 && numero2 > numero1)
                Console.WriteLine($"El mayor es:{numero3} \nEl mediano es:{numero2} \nEl menor es:{numero1}");

            else if (numero3 > numero1 && numero1 > numero2)
                Console.WriteLine($"El mayor es:{numero3} \nEl mediano es:{numero1} \nEl menor es:{numero2}");


        }*/
    }

    #endregion

    #region Ejercicio5
    /*Se pide una cantidad y su precio. Hay que hallar el total aplicando 
     * un tanto por ciento de descuento según la cantidad comprada. 
     * CANTIDAD     DESCUENTO 
     *  0-10        0%
     *  11-30       5% 
     *  31-50       10% 
     *  Más de 50   15%*/
    class Ejercicio5

    {
       /* static void Main()
        {
            float cantidad, precio;
           

            Console.Write("Dime cuantas lechugas quieres: ");
            cantidad = float.Parse(Console.ReadLine());

            Console.Write("Dime a cuanto te sale cada lechuga: ");
            precio = float.Parse(Console.ReadLine());

            if (cantidad <= 10)
                Console.WriteLine($"La/s lechugas te salen por el modico precio de {((precio * cantidad) - (precio * 0.0)):F2}€");
            else if(cantidad>10 && cantidad<=30)
                Console.WriteLine($"La/s lechugas te salen por el modico precio de {((precio * cantidad) - (precio * 0.05)):F2}e");
            else if (cantidad > 30 && cantidad <= 50)
                Console.WriteLine($"La/s lechugas te salen por el modico precio de {((precio * cantidad) - (precio * 0.1)):F2}e");
            else if (cantidad > 50)
                Console.WriteLine($"La/s lechugas te salen por el modico precio de {((precio * cantidad) - (precio * 0.15)):F2}$");
        }*/
    }

    #endregion

    #region Ejercicio6
    /*Una compañía de videojuegos te ha contratado para escribir el programa de un videojuego nuevo.
     *  Deberás crear la parte del programa que calcula el número total de puntos que un jugador gana
     *  en el juego Galaxy. Los jugadores acumulan puntos mediante la recolección de objetos. 
     *  Los objetos tienen asignados los siguientes puntos: 
     *  • Estrella = 10 puntos. • Planeta = 20 puntos.
     *  • Asteroide = 50 puntos. • Cometa = 100 puntos. 
     *  Si un jugador acumula más de 5.000 puntos, en una misma jugada, ganará un bono de 500 puntos. 
     *  Implementa pues una jugada, donde le pidamos al usuario el nombre de un objeto y el número de 
     *  estos que ha recogido. Mostrando el total de puntos teniendo en cuenta los bonos.*/
    class Ejercicio6

    {
       /* static void Main()
        {
            Console.Write("¿Qué objeto has recogido? \n-Estrella \n-Planeta \n-Asteroide \n-Cometa \nInrtodúcelo: ");
            string nombre = Console.ReadLine();

            Console.Write("¿Cuantos has recogido?: ");
            int cantidad = int.Parse(Console.ReadLine());

            int resultado=0;

            switch (nombre)
            {
                case "estrella":
                case "ESTRELLA":
                    resultado = 10 * cantidad;
                    Console.WriteLine("Total de puntos {0}", resultado);
                    break;
                case "planeta":
                case "PLANETA":
                    resultado = 20 * cantidad;
                    Console.WriteLine("Total de puntos {0}", resultado);
                    break;
                case "asteroide":
                case "ASTEROIDE":
                    resultado = 50 * cantidad;
                    Console.WriteLine("Total de puntos {0}", resultado);
                    break;
                case "cometa":
                case "COMETA":
                    resultado = 100 * cantidad;
                    Console.WriteLine("Total de puntos {0}", resultado);
                    break;
                default:
                    Console.WriteLine("Valor no válido");
                    break;
            }
                    if (resultado >= 5000)
                    {
                        resultado = resultado + 500;
                        Console.WriteLine("¡BONUS! has ganado 500 puntos extras haciendo un total de {0}", resultado);
                    }
                 
        }*/
    }

    #endregion

    #region Ejercicio7
    /*Una empresa solicita a su departamento de informática un programa para la confección de facturas.
     *  La mayoría de los artículos que vende dicha compañía soportan un IVA de consumo del 12%, y sólo
     *  unos pocos están cargados con un IVA del 6%. El programa leerá el nombre, dirección y CIF del comprador
     *  y el total a pagar. Además preguntará si el articulo es de consumo o no. Imprimiendo la factura con el  
     *  cálculo la base imponible y el IVA soportado*/
    class Ejercicio7

    {
         /*static void Main()
         {

            float baseImponible=0;
            float iva=0;

            Console.Write("Dime tu nombre: ");
            string  nombre = Console.ReadLine();

            Console.Write("Dime tu direccion: ");
            string direccion = Console.ReadLine();

            Console.Write("Dime tu CIF: ");
            string cif =Console.ReadLine();

            Console.Write("Dime el total a pagar: ");
            float totalAPagar = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Es de consumo? (S/N): ");
            char consumo = char.Parse(Console.ReadLine());

            if (consumo=='s'|| consumo=='S')
            {
                iva = 0.12f;
            }
            else
            {
                iva = 0.06f;
            }
            baseImponible = iva * totalAPagar - iva;

            Console.WriteLine($"FACTURA: \nNombre:{nombre}  \nDireccion:{direccion}  \nCIF:{cif}  \nTotal a pagar:{totalAPagar}  \nBase Imponible:{baseImponible}   \nIva:{iva*100}%");
        }*/
    }

    #endregion
}
