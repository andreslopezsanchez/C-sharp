using System;
using System.Text;

namespace EjerciciosCadenas
{
    #region Ejercicio1
    /*Realiza un programa que se repita hasta pulsar  ESC. En el aparecerá un menú con 9 opciones que corresponderán
     *a los siguientes ejercicios. Utiliza un switch para seleccionar cada opción y los métodos necesarios para que 
     *el programa quede claro y no se repita el código:
     *  1. Lee una  cadena y a continuación muestra en pantalla su longitud.
     *  2. Introduce una cadena y una subcadena y muestra en que posición comienza la última aparición de la subcadena. 
     *  3. Lee un nombre y luego muestre ese mismo nombre pero con todas las letras en mayúsculas. 
     *  4. Introduciremos una cadena por teclado y encadenaremos la cadena “LA CADENA FIN HA SIDO AÑADIDA A NUESTRO ARRAY”.
     *      Visualizaremos el  resultado por pantalla.
        5. Introduce una cadena y elimina los N caracteres a partir de la posición P indicada. Mostrando posteriormente el resultado. 
        6. Introduce un texto y posteriormente dos cadenas. Sustituye las apariciones de la primera cadena en el texto por la segunda cadena. 
        Mostrando posteriormente el resultado*/

    class Ejercicio1
/*mirar que es index of o last index of*/
    {

        

        public static void MostrarMenu()
        {
           
            Console.WriteLine("1.Lee una  cadena y a continuación muestra en pantalla su longitud:");
            Console.WriteLine("2. Introduce una cadena y una subcadena y muestra en que posición comienza" + 
                              "la última aparición de la subcadena:");
            Console.WriteLine("3. Lee un nombre y luego muestre ese mismo nombre pero con todas las letras en mayúsculas:");
            Console.WriteLine("4. Introduciremos una cadena por teclado y encadenaremos la cadena" +
                            "\"LA CADENA FIN HA SIDO AÑADIDA A NUESTRO ARRAY\".Visualizaremos el  resultado por pantalla:");
            Console.WriteLine("5. Introduce una cadena y elimina los N caracteres a partir de la posición P indicada. Mostrando posteriormente el resultado:");
            Console.WriteLine("6. Introduce un texto y posteriormente dos cadenas. Sustituye las apariciones de la primera cadena en el texto por la segunda cadena: ");

            Console.WriteLine("SALIR. Pulsar ESC");
            Console.Write("Elige una opción: ");
        }

        static void Main()
        {
            int opcion = 0;
            
            do
            {
                MostrarMenu();
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dime una palabra y te diré su longitud");
                        string palabra = Console.ReadLine();
                        int longitudPalabra = palabra.Length;
                        Console.WriteLine($"La longitud de esa palabra es {longitudPalabra} \n\n");
                        break;
                    case 2:
                        int posicionAparicionSubCadena;

                        Console.Write("Dime una palabra: ");
                        string cadena = Console.ReadLine();

                        Console.Write("dime otra y te dire si la anterior la contiene y donde: ");
                        string subcadena = Console.ReadLine();

                        posicionAparicionSubCadena = cadena.LastIndexOf(subcadena);

                        if (posicionAparicionSubCadena < 0)
                            Console.WriteLine("No aparece en la cadena");
                        else
                            Console.WriteLine($"Aparece en la posicion {posicionAparicionSubCadena}\n\n");
                        break;
                    case 3:
                        Console.Write("Dime una palabra toh flamah: ");
                        string PalabraTohFlama = Console.ReadLine();

                        string palabraMayusculas = PalabraTohFlama.ToUpper();

                        Console.WriteLine(palabraMayusculas);
                        break;

                    case 4:
                        string cadenaFIn = " \"LA CADENA FIN HA SIDO AÑADIDA A NUESTRO ARRAY\"";

                        Console.Write("Dime una cadena(palabra): ");
                        string palabra4 = Console.ReadLine();

                        Console.WriteLine($"{palabra4}{cadenaFIn} \n\n");
                        break;
                    // 5. Introduce una cadena y elimina los N caracteres a partir de la posición P indicada. Mostrando posteriormente el resultado:
                    case 5:
                        Console.Write("Dime una palabra: ");
                        string palabraAborrar = Console.ReadLine();
                        Console.Write("Cuantos caracteres quieres eliminar: ");
                        int cuantosCaracteresAEliminar = int.Parse(Console.ReadLine());
                        Console.Write("¿A partir de que posicion de la palabra? Empezando por 0: ");
                        int posicionAEliminar = int.Parse(Console.ReadLine());

                        StringBuilder cadenaMutable = new StringBuilder(palabraAborrar);
                        cadenaMutable.Remove(posicionAEliminar, cuantosCaracteresAEliminar);

                        Console.WriteLine(cadenaMutable);                        
                        break;

                    //6. Introduce un texto y posteriormente dos cadenas. Sustituye las apariciones de la primera cadena en el texto por la segunda cadena
                    case 6:
                        Console.Write("Dime una palabra toh flamah: ");
                        string texto = Console.ReadLine();
                        Console.Write("Dime una palabra toh flamah: ");
                        string PalabraTohFlama = Console.ReadLine();
                        Console.Write("Dime una palabra toh flamah: ");
                        string PalabraTohFlama = Console.ReadLine();


                        break;

                    default:
                        break;
                }

            } while (opcion != 0 );
        }
    }

    #endregion

    #region Ejercicio2
    /* */
    class Ejercicio2

    {
        public static string PidePalabraAAdivinar()
        {
            Console.Write("Dime una palabra a adivinar: ");
            string palabraAdivinar = Console.ReadLine();
            return palabraAdivinar;
        }

       public static int PideMaximoFallos()
        {
            Console.Write("Dime cuantos fallos puedes tener: ");
            int numeroFallos = int.Parse(Console.ReadLine());
            return numeroFallos;
        }

        public static bool EstaLetraEnLetras(char letra, string letras)
        {

        }

        public static char PideLetra(string palabraParcialmenteAdivinada, string letrasFalladas)
        {

        }

        public static void MuestraEstadoJuego( string palabraParcialmenteAdivinada,string letrasFalladas)
        {

        }

        public static bool SeAñadeLetraALetrasPalabraAMostrar( string palabraAAdivinar, char letra,
                                                 StringBuilder palabraParcialmenteAdivinada)
        {

        }

        public static bool FinDeJuego(int numFallos, int maxFallos, string palabraAAdivinar, string palabraParcialmenteAdivinada, 
            out string mensajeSiFin)
        {

        }

        public static void Jugar(string palabraAAdivinar, int maximoFallos)
        {

        }


        public static void Main()
        {
            PidePalabraAAdivinar();
            PideMaximoFallos();
        }
    }

    #endregion
}
