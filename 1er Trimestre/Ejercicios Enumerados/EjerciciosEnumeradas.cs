using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEnumeradas
{
    #region Ejercicio1
    /*Ejercicio 1 Define las siguientes estructuras para contener: 
     * • Una estructura Naipe que contendrá un valor y un palo y vamos a inicializarla al 3 de oros. 
     * • Una IP e inicialízala al valor de la IP 10.0.151.100, donde cada parte de la IP será de tipo byte. 
     * • Los siguientes datos de un alumno: curso, grupo, nombre y crea una tabla de notas para las tres evaluaciones.*/

    /*Modifica la estructura Naipe del ejercicio 1 de la entrega anterior, de forma que ahora el valor palo sea una enumeración.
      Crea una matriz Naipe[,] baraja -> new Naipe[4,12] e inicialízala suponiendo que cada fila representa un palo.*/

    //class Enjercicio1
    //{

    //    public enum Palo
    //    {
    //        Oros,
    //        Bastos,
    //        Copas,
    //        Espadas
    //    }

    //    public struct Naipe
    //    {
    //        public Palo palo;
    //        public int numero;
    //    }

    //    struct Alumno
    //    {
    //        public int curso;
    //        public char grupo;
    //        public string nombre;
    //        public int[] notas;
    //    }

    //    public static Naipe[,] RellenarBaraja()
    //    {
    //        Palo[] palos = (Palo[])Enum.GetValues(typeof(Palo));
    //        Naipe[,] baraja = new Naipe[palos.Length, 12];

    //        foreach (Palo palo in palos)
    //        {
    //            for (int i = 0; i < baraja.GetLength(1); i++)
    //            {
    //                baraja[(int)palo, i].palo = palo;
    //                baraja[(int)palo, i].numero = i;

    //            }
    //        }
    //        return baraja;
    //    }

    //    static void Main()
    //    {
    //        Naipe[,] baraja = RellenarBaraja();

    //    }
    //}
    #endregion

    #region Ejercicio2
    /*Modifica la estructura Alumno del ejercicio 1 de la entrega anterior, de forma que ahora
      tenga un campo más. Un array del enumerado Modulo, al que llamaremos Modulos y el
      cual representará las asignaturas que se están evaluando en la matriz de notas por
      trimestre.Matriz
      
      Crea un método MostrarNotas que muestre la tabla con las notas de todos los módulos
      para las tres evaluaciones.*/

    class Ejercicio2
    {

        //public enum Modulo
        //{
        //    ED,
        //    PROG,
        //    SI,
        //    FOL,
        //    LM,
        //    GBD
        //}

        //public struct Alumno
        //{
        //    public int Curso;
        //    public char Grupo;
        //    public string Nombre;
        //    public int[,] Notas;
        //    public Modulo[] Modulos;
        //}

        //public static void RellenarNotas(int[,] notas, Random semilla)
        //{
        //    for (int i = 0; i < notas.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < notas.GetLength(1); j++)
        //        {
        //            notas[i, j] = semilla.Next(0, 11);
        //        }
        //    }
        //}

        //public static void MostrarNotas(Alumno alumno)
        //{
        //    Console.WriteLine($" Nombre:{alumno.Nombre}\n Curso:{alumno.Curso}\n Grupo:{alumno.Grupo}\n");

        //    for (int i = 0; i < alumno.Notas.GetLength(0); i++)
        //    {
        //        Console.Write($"{alumno.Modulos[i].ToString()} ");

        //        for (int j = 0; j < alumno.Notas.GetLength(1); j++)
        //        {
        //            Console.Write($" \t\t {alumno.Notas[i, j]}");
        //        }
        //        Console.WriteLine("\n");
        //    }
        //}


        //static void Main()
        //{
        //    Random semilla = new Random();
        //    Modulo[] modulos = (Modulo[])Enum.GetValues(typeof(Modulo));

        //    Alumno alumno;

        //    alumno.Nombre = "Andres";
        //    alumno.Curso = 1;
        //    alumno.Grupo = 'A';
        //    alumno.Notas = new int[modulos.Length, 3];
        //    alumno.Modulos = modulos;

        //    RellenarNotas(alumno.Notas, semilla);
        //    MostrarNotas(alumno);

        //}
    }
    #endregion

    #region Ejercicio3
    /*1. Crea una enumeración colores la cual inicializarás con los siguientes valores en
hexadecimal:
Rojo → 0xFF0000
Azul → 0x0000FF
Verde → 0x00FF00
Amarillo → 0xFFFF00
Violeta → 0xC71585
Blanco → 0xFFFFFF
Negro → 0x000000
Gris → 0xCDCDCD
Marron → 0xA52A2A
2. Muestra todos los colores de la enumeración, inficando el nombre del color en el
enum y su valor correspondiente en hexadecimal.
3. Por último, prediremos un color al usuario y mostraremos su valor en hexadecimal
si existe en la enumeración o un mensaje de error si no existe.*/
    class Ejercicio3
    {

        public enum Colores
        {
            Rojo = 0xFF0000,
            Azul = 0x0000FF,
            Verde = 0x00FF00,
            Amarillo = 0xFFFF00,
            Violeta = 0xC71585,
            Blanco = 0xFFFFFF,
            Negro = 0x000000,
            Gris = 0xCDCDCD,
            Marron = 0xA52A2A
        }

        public static void MuestraColores(Colores[] colores)
        {
            for (int i = 0; i < colores.Length; i++)
            {
                Console.Write($"{colores[i]} = ");
                Console.WriteLine($"{(int)colores[i]:X6}");
            }
            Console.WriteLine();
        }

    

        static void Main()
        {
            Colores[] colores = (Colores[])Enum.GetValues(typeof(Colores));

            MuestraColores(colores);

            Console.Write("dime un color: ");
            string colorElegido = Console.ReadLine();

            if (Enum.IsDefined(typeof(Colores), colorElegido)==true)
            {
                Console.WriteLine($"{colorElegido} = {(int)Enum.Parse(typeof(Colores), colorElegido):X6}");
            }
            else
            {
                Console.WriteLine("No es válido");
            }

            
        }
    }
    #endregion

    #region Ejercicio4
    /*Crea una estructura Coche que posea los datos matricula, color, marca, numPlazas y
categoría (este último será una enumeración con los siguientes datos [Berlina, Coupe,
Sedan, Cabrio, TodoTerreno, MonoVolumen, StationWagon, PickUp]).
Crea un método para recoger la información de un coche. Este método llamará a su vez a
otro genérico llamado LeeEnum, el cual nos servirá para comprobar si el dato introducido
para categoría realmente esta en la enumeración.
Para esto utilizaremos dicho método genérico con esta signatura*/

    class Ejercicio4
    { 
        //public enum Categoria
        //{
        //    Berlina,
        //    Coupe,
        //    Sedan,
        //    Cabrio,
        //    TodoTerreno,
        //    MonoVolumen,
        //    StationWagon,
        //    PickUp
        //}
        //public struct Coche
        //{
        //    public int Matricula;
        //    public string Color;
        //    public string Marca;
        //    public int NumPlazas;
        //    public Categoria Categoria;

        //}

        //public static void RecogerYMostrarInformacion()
        //{
        //    Coche vehiculo;
        //    Console.Write("Dime la matricula de tu vehículo: ");
        //    vehiculo.Matricula = int.Parse(Console.ReadLine());
        //    Console.Write("Dime el color: ");
        //    vehiculo.Color = Console.ReadLine();
        //    Console.Write("Dime la marca: ");
        //    vehiculo.Marca = Console.ReadLine();
        //    Console.Write("Dime el número de plazas: ");
        //    vehiculo.NumPlazas = int.Parse(Console.ReadLine());

        //    string texto = "Dime la categoria: ";
        //    string textoError = "No pertenece a ninguna categoria";
            
        //    vehiculo.Categoria= (Categoria)LeerEnum(typeof(Categoria), texto, textoError);

        //    MostrarInformacion(vehiculo);
        //}

        //public static Object LeerEnum(Type tipo, string texto, string textoError)
        //{
        //    Console.Write(texto);
        //    string categoria = Console.ReadLine();

        //    bool funciona = Enum.IsDefined(tipo, categoria);

        //    if (funciona == false)
        //    {
        //        Console.WriteLine(textoError);
        //    }

        //    return Enum.Parse(tipo, categoria);
        //}

        //public static void MostrarInformacion(Coche vehiculo)
        //{
        //    Console.WriteLine($"Matricula: {vehiculo.Matricula} ");
        //    Console.WriteLine($"Color: {vehiculo.Color}");           
        //    Console.WriteLine($"Marca: {vehiculo.Marca} ");           
        //    Console.WriteLine($"Número de plazas: {vehiculo.NumPlazas}");
        //    Console.WriteLine($"Categoria: {vehiculo.Categoria.ToString()}");
        //}
        
        //static void Main()
        //{
        //    RecogerYMostrarInformacion();          
        //}
    }
    #endregion

    #region Ejercicio5
    //class Ejercicio5
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
    #endregion
}
