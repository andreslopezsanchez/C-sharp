using System;


namespace EjerciciosSecuencialidad
{

    #region Ejercicio1
    class Ejercicio1

    {
       /* static void Main()
        {
            int numero1, numero2;

            Console.Write("Dime el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Dime el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            int producto = numero1 * numero2;
            int division = numero1 / numero2;
            int modulo = numero1 % numero2;

            Console.WriteLine($"su producto es:{producto}, division:{division} y módulo:{modulo}");
        }*/
    }

    #endregion

    #region Ejercicio2
    class Ejercicio2

    {
      /* static void Main()
        {
            double radio;
            Console.Write("Dime la longitud del radio de una circunferencia: ");
            radio = double.Parse(Console.ReadLine());

            double longitud = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(radio, 3);

            Console.WriteLine($"El area de la circunferencia es:{area:F2}  y su longitud es{longitud:F2} ");

            
         }*/
    }

    #endregion

    #region Ejercicio3
    class Ejercicio3

    {
       /* static void Main()
        {
            int numero1;
            Console.Write("Dime un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            int numeroAnterior = numero1 - 1;
            int numeroPosterior = numero1 + 1;

            Console.WriteLine($"El numero anterior es:{numeroAnterior} \nEl numero posterior es:{numeroPosterior}");
        }*/
    }

    #endregion

    #region Ejercicio4
    class Ejercicio4

    {
       /* static void Main()
        {
            int numero;
            Console.Write("Dame un numero: ");
            numero = int.Parse(Console.ReadLine());
            int cubo =(int) Math.Pow(numero, 3);

            Console.WriteLine($"El cubo de {numero} es {cubo} ");

        }*/
    }

    #endregion

    #region Ejercicio5
    class Ejercicio5

    {
        /*static void Main()
        {
            float velocidad;
            Console.Write("Dime a que velocidad va tu vehiculo en km/h: ");
            velocidad = float.Parse(Console.ReadLine());

            float convertidorAMetrosPorSegundos = (velocidad * 1000) / 3600;
            Console.WriteLine($"tambien va a {convertidorAMetrosPorSegundos:F2} M/s");
        }*/
    }

    #endregion

    #region Ejercicio6
    class Ejercicio6

    {
         static void Main()
         {
           float producto;
             Console.Write("Dime cuanto te ha costado el producto sin: ");
             producto = float.Parse(Console.ReadLine());
           
            float cantidad;
             Console.Write("Dime que cantidad: ");
             cantidad = float.Parse(Console.ReadLine());
            
            float iva;
             Console.Write("Dime que porcentaje de iva vas a utilizar: ");
             iva = float.Parse(Console.ReadLine());

           float ivaProducto= producto*(iva/100);
            float factura = ((producto + ivaProducto) * cantidad);
             
             Console.WriteLine($"La factura te saldrá por {factura} ");
         }
    }

    #endregion

    #region Ejercicio7
    class Ejercicio7

    {
       /* static void Main()
        {
            float numero1, numero2;
            Console.Write("dime un numero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("dime otro numero: ");
            numero2 = float.Parse(Console.ReadLine());

            float media=(numero1+numero2)/2;

            Console.WriteLine($"La media de los dos numeros es {media:F2}");
        }*/
    }

    #endregion
}
