using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstructuras
{
    class EjercicioEstructuras
    {
        #region Ejercicio1
        /* Define las siguientes estructuras para contener:
            • Una estructura Naipe que contendrá un valor y un palo y vamos a inicializarla al 3
            de oros.
            • Una IP e inicialízala al valor de la IP 10.0.151.100, donde cada parte de la IP será
            de tipo byte.
            • Los siguientes datos de un alumno: curso, grupo, nombre y crea una tabla de notas
            para las tres evaluaciones.*/
        class Ejercicio1

        {
            //public struct Naipe
            //{
            //    public int Valor;
            //    public string Palo;
            //}

            //public struct IP
            //{
            //   public int Byte1;
            //   public int Byte2;
            //   public int Byte3;
            //   public int Byte4;
            //}

            //public struct Alumno
            //{
            //    public int Curso;
            //    public char Grupo;
            //    public string Nombre;
            //    public int[,] Notas;
            //}



            //static void Main()
            //{
            //    Naipe carta;
            //    carta.Palo= "3 de oros";
                
            //    IP ip;
            //    ip.Byte1 = 10;
            //    ip.Byte2 = 0;
            //    ip.Byte3 = 151;
            //    ip.Byte4 = 100;

            //    Alumno alumno;
            //    alumno.Notas= new int[6, 3];
            //}
        }

        #endregion

        #region Ejercicio2
        /* Escribe un programa que utilice una estructura llamada Fecha para almacenar una fecha
           (mes, día y año).
           El programa deberá pedir al usuario que introduzca una fecha y luego mostrará la fecha
           del día siguiente.
           Para realizar estas operaciones definiremos los siguientes métodos:
                static Fecha PideFecha() {...}
                static void SumaUnDía(ref Fecha fecha) {…}
                static string FechaACadena(Fecha fecha) {…}
           Ej:si el usuario introduce 27/02/2018, entonces el programa deberá mostrar 28/02/2018*/
        class Ejercicio2

        {
            //public struct Fecha
            //{
            //    public int Mes;
            //    public int Dia;
            //    public int Año;
            //}

            //static Fecha PideFecha()
            //{
            //    Fecha fecha;
            //    Console.Write("Dime un día: ");
            //    fecha.Dia = int.Parse(Console.ReadLine());
            //    Console.Write("Dime un mes (en número): ");
            //    fecha.Mes = int.Parse(Console.ReadLine());
            //    Console.Write("Dime un año: ");
            //    fecha.Año = int.Parse(Console.ReadLine());

            //    return fecha;
            //}

            //static void SumaUnDía(ref Fecha fecha)
            //{
            //    fecha.Dia = fecha.Dia + 1;
            //}

            //static string FechaACadena(Fecha fecha)
            //{
            //    string fechaEnCadena = $"{fecha.Dia}/{fecha.Mes}/{fecha.Año}";

            //    return fechaEnCadena;
            //}

            //static void Main()
            //{
            //    Fecha fecha = PideFecha();
            //    SumaUnDía(ref fecha);
            //    Console.WriteLine(FechaACadena(fecha));

            //}
        }

        #endregion

        #region Ejercicio3
        /*  A un crítico de restaurantes le gustaría almacenar la información que se indica a continuación sobre cada restaurante que visita: 
            nombre, dirección, ciudad, número de teléfono, tipo de comida (por ejemplo Italiana, Mejicana, China, Americana, etc.), el plato
            más caro del menú, el plato más barato del menú y la categoría (de uno a cuatro tenedores, donde cuatro tenedores es la categoría más alta).

            Introduce los datos de 3 restaurantes en un array de estructuras Restaurante con los datos de los mismos y después visualiza un listado de todos 
            ellos (del array).

            Nota: Para el dato categoría aparecerán tantos asteriscos como tenedores tiene el
            restaurante. */
        class Ejercicio3

        {
            //public struct Restaurante
            //{
            //    public string Nombre;
            //    public string Direccion;
            //    public string Ciudad;
            //    public int Telefono;
            //    public string TipoComida;
            //    public string PlatoMasCaro;
            //    public string PlatoMasBarato;
            //    public int Categoría;
            //}

            //static Restaurante  PedirDatos ()
            //{
            //    Restaurante restaurante;
            //    Console.Write("Dime el nombre del restaurante: ");
            //     restaurante.Nombre= Console.ReadLine();
            //    Console.Write("Su dirección: ");
            //    restaurante.Direccion = Console.ReadLine();
            //    Console.Write("Su ciudad: ");
            //    restaurante.Ciudad = Console.ReadLine();
            //    Console.Write("Su telefono: ");
            //    restaurante.Telefono = int.Parse(Console.ReadLine());
            //    Console.Write("Tipo de Comida: ");
            //    restaurante.TipoComida = Console.ReadLine();
            //    Console.Write("Su plato mas caro: ");
            //    restaurante.PlatoMasCaro = Console.ReadLine();
            //    Console.Write("Su plato mas Barato: ");
            //    restaurante.PlatoMasBarato = Console.ReadLine();
            //    do
            //    {
            //        Console.Write("Su categoría (por tenedores y máximo 4): ");
            //        restaurante.Categoría = int.Parse(Console.ReadLine());

            //        if (restaurante.Categoría < 1 || restaurante.Categoría > 4)                    
            //            Console.WriteLine("Categoría no válida. Vuelve a intentarlo");            
                    
            //    } while (restaurante.Categoría < 1 || restaurante.Categoría > 4);

            //    return restaurante;
            //}

            //static void MostrarDatos(Restaurante restaurante)
            //{

            //    Console.WriteLine($"Nombre:{restaurante.Nombre}");
            //    Console.WriteLine($"Direccion:{restaurante.Direccion}");
            //    Console.WriteLine($"Ciudad:{restaurante.Ciudad}");
            //    Console.WriteLine($"Telefono:{restaurante.Telefono}");
            //    Console.WriteLine($"Tipo de comida:{restaurante.TipoComida}");
            //    Console.WriteLine($"Plato más caro:{restaurante.PlatoMasCaro}");
            //    Console.WriteLine($"Plato más barato:{restaurante.PlatoMasBarato}");

            //    string CategoriaAsteriscos = "";

            //    for (int i = 0; i < restaurante.Categoría; i++)
            //    {
            //        CategoriaAsteriscos = "*" + CategoriaAsteriscos;
            //    }
            //    Console.WriteLine($"Categoria:{CategoriaAsteriscos}");
                 
            //}

            //static void Main()
            //{
            //    Restaurante[] restaurantes = new Restaurante[3];

            //    for (int i = 0; i < restaurantes.Length; i++)
            //    {
            //        Console.WriteLine($"Restaurante nº{i + 1}");
            //        restaurantes[i] = PedirDatos();
            //        Console.WriteLine();
            //    }

            //    for (int i = 0; i < restaurantes.Length; i++)
            //    {
            //        Console.WriteLine($"Restaurante nº{i + 1}");
            //        MostrarDatos(restaurantes[i]);
            //    }

            //}
        }

        #endregion

        #region Ejercicio4
        /*  Partiendo de la siguiente declaración de estructura:
         
            struct Temperaturas
            {
                public string Provincia;
                public short TemperaturaMaxima;
                public short TemperaturaMinima;
            }

            Escribe un programa con los métodos necesarios para definir una tabla de N provincias e introducir los datos por teclado de nombre, temperatura máxima y mínima.
            Se deberá crear un método que visualice los nombres de las provincias con temperatura máxima superior a la media de las temperaturas máximas y el nombre 
            de las provincias con temperatura mínima inferior a la media de las temperaturas mínimas.*/

        class Ejercicio4

        {

           // public struct Temperaturas
           // {
           //     public string Provincia;
           //     public short TemperaturaMaxima;
           //     public short TemperaturaMinima;
           // }

           // static Temperaturas[] PedirDatosEIntroducirlos()
           // {

           //     Console.Write("¿De cuantas provincias quieres hacer la tabla?: ");
           //     int numeroProvincias = int.Parse(Console.ReadLine());

           //     Temperaturas[] temperaturas = new Temperaturas[numeroProvincias];

           //     for (int i = 0; i < temperaturas.Length; i++)
           //     {
           //         Console.WriteLine($"Provincia nº{i + 1}");

           //         Console.Write("Dime el nombre de la provincia: ");
           //         temperaturas[i].Provincia = Console.ReadLine();
           //         Console.Write("Su temperatura máxima: ");
           //         temperaturas[i].TemperaturaMaxima = short.Parse(Console.ReadLine());
           //         Console.Write("Su temperatura mínima: ");
           //         temperaturas[i].TemperaturaMinima = short.Parse(Console.ReadLine());
           //         Console.WriteLine();
           //     }
           //     return temperaturas; 
           // }

           //public static void SumaMaximosYMinimos (Temperaturas[] temperaturas, out short sumaMaximos, out short sumaMinimos)
           // {

           //      sumaMaximos = 0;
           //      sumaMinimos = 0;

           //     for (int i = 0; i < temperaturas.Length; i++)
           //     {                                      
           //         sumaMaximos += temperaturas[i].TemperaturaMaxima;
           //         sumaMinimos += temperaturas[i].TemperaturaMinima;                    
           //     }
           //     Console.WriteLine($"Suma de las temperaturas maximas:{sumaMaximos} ");
           //     Console.WriteLine($"Suma de las temperaturas minimas:{sumaMinimos} ");
           //     Console.WriteLine();
           // }

           // static void MostrarProvinciasFueraDeLaMedia(Temperaturas[] temperaturas, short sumaMax, short sumaMin)
           // {
           //     float mediaMaxima = sumaMax / temperaturas.Length;
           //     float mediaMinima = sumaMin / temperaturas.Length;
           //     Console.WriteLine("Provincias con temperaturas más altas que la media:");
           //     for (int i = 0; i < temperaturas.Length; i++)
           //     {
           //         if (temperaturas[i].TemperaturaMaxima > mediaMaxima)
           //         {
           //             Console.WriteLine(temperaturas[i].Provincia);
           //         }
           //     }
           //     Console.WriteLine();

           //     Console.WriteLine("Provincias con temperaturas más bajas que la media:");
           //     for (int i = 0; i < temperaturas.Length; i++)
           //     {
           //         if (temperaturas[i].TemperaturaMinima < mediaMinima)
           //         {
           //             Console.WriteLine(temperaturas[i].Provincia);
           //         }
           //     }
           // }

           // static void Main()
           // {
           //     short sumaMaximos;
           //     short sumaMinimos;                

           //     Temperaturas[] provincias = PedirDatosEIntroducirlos();
           //     SumaMaximosYMinimos(provincias, out sumaMaximos, out sumaMinimos);
           //     MostrarProvinciasFueraDeLaMedia(provincias, sumaMaximos, sumaMinimos);
           // }                        
        }
        #endregion

        #region Ejercicio5(opcional)
        /* Realiza un programa que dados los resultados de los 10 partidos de fútbol de una jornada
de liga ficticia. Actualice la tabla de clasificación, en la que se guarda para los 20 equipos
su nombre, el número de puntos hasta ese momento, goles a favor y goles en contra.
Después de visualizará un listado de todos los partidos ordenados de mayor a menor
puntos.
Un posible Main del programa puede ser..
static void Main()
{
 Equipo[] equipos = InicializaLiga();
 Partido[] resultados = ObtenResultadosJornadaFicticia(equipos);
 MuestraResultadosJornada(resultados);
 ActualizaClasificacion(equipos, resultados);
 OrdenaClasificacion(equipos);
 MuestraClasificacion(equipos);
}
*/
        class Ejercicio5
        {
            //static void Main()
            //{

            //}
        }


        #endregion

        #region Ejercicio6
        /* Programa que define una tabla de proveedores utilizando estructuras, teniendo asignado
cada proveedor, un nombre, una cantidad vendida del artículo, un precio unitario
(Introducidos por teclado) y un importe (calculado a partir de los datos anteriores).
Se pretende visualizar:
• Los datos de cada proveedor.
• El importe total de compra.
• El nombre del proveedor más barato y el del más caro. */
        class Ejercicio6
        {

            public struct Proveedores
            {
                public string Nombre;
                public int CantidadArticulo;
                public float PrecioUnitario;
                public float Importe;
            }

            static Proveedores[] PedirDatosEIntroducirlos()
            {

                Console.Write("¿Cuantos proveedores tienes?: ");
                int numeroProveedores = int.Parse(Console.ReadLine());

                Proveedores[] arrayProveedores= new Proveedores[numeroProveedores];

                for (int i = 0; i < arrayProveedores.Length; i++)
                {                    
                    Console.Write($"Introduce el nombre del proveedor {i+1}: ");
                    arrayProveedores[i].Nombre = Console.ReadLine();
                    Console.Write("Introduce cantidad de piezas: ");
                    arrayProveedores[i].CantidadArticulo = int.Parse(Console.ReadLine());
                    Console.Write("Introduce precio unitario: ");
                    arrayProveedores[i].PrecioUnitario = float.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                return arrayProveedores;
            }

            static void MostrarDatosEImporte(Proveedores[] arrayProveedores)
            {
                string mensaje= "";
                Console.WriteLine($"{"NOMBRE",-15}{"CANT",5}{"PRECIO",7}{"IMPORTE",12}");
                for (int i = 0; i < arrayProveedores.Length; i++)
                {
                    arrayProveedores[i].Importe = arrayProveedores[i].CantidadArticulo * arrayProveedores[i].PrecioUnitario;
                    mensaje = $"{arrayProveedores[i].Nombre, -15} {arrayProveedores[i].CantidadArticulo,3}" +
                              $"{arrayProveedores[i].PrecioUnitario,6} {arrayProveedores[i].Importe,13} ";
                    Console.Write(mensaje);
                    Console.WriteLine();
                }
                Console.WriteLine();
            } 

            static void MuestraImporteTotal(Proveedores[] arrayProveedores)
            {
                float ImporteTotal = 0;
               
                for (int i = 0; i < arrayProveedores.Length; i++)
                {
                    ImporteTotal += arrayProveedores[i].Importe;
                }
                Console.Write($"{"EL IMPORTE TOTAL ES",-27}:{ImporteTotal}");
                Console.WriteLine();
            }

            static void MuestraProveedoresMasCarosYBaratos(Proveedores[] arrayProveedores)
            {
                float MasBarato = arrayProveedores[1].Importe;
                float MasCaro = 0;
                string ProveedorCaro="";
                string ProveedorBarato = arrayProveedores[1].Nombre;

                for (int i = 0; i < arrayProveedores.Length; i++)
                {
                    if (arrayProveedores[i].Importe < MasBarato)
                    {
                        ProveedorBarato = arrayProveedores[i].Nombre;
                    }
                   
                }
                Console.Write($"{"EL PROVEEDOR MAS BARATO ES",-27}:{ProveedorBarato}");
                Console.WriteLine();

                
                for (int i = 0; i < arrayProveedores.Length; i++)
                {
                    if (arrayProveedores[i].Importe>MasCaro)
                    {
                        MasCaro = arrayProveedores[i].Importe;
                        ProveedorCaro = arrayProveedores[i].Nombre;
                    }
                }
                Console.Write($"{"EL PROVEEDOR MAS CARO ES", -27}:{ProveedorCaro}");
                Console.WriteLine();
            }

            static void Main()
            {
                Proveedores[] proveedores = PedirDatosEIntroducirlos();
                MostrarDatosEImporte(proveedores);
                MuestraImporteTotal(proveedores);
                MuestraProveedoresMasCarosYBaratos(proveedores);
            }
        }

        #endregion

        #region Ejercicio7(opcional)
        /* Vamos a definir una estructura Segmento que contendrá una los datos necesarios para
definir un segmento en el plano como son la coordenada del punto origen, la longitud del
segmento y una dirección en forma de seno y coseno.
Deberemos introducir los datos de un segmento y mostrarlos.
Para introducir la dirección lo haremos introduciendo un ángulo en grados, pero ten
presente que los ordenadores operan con radianes.
Nota: radianes = grados * Π / 180;
*/
        class Ejercicio7

        {
            //static void Main()
            //{

            //}
        }

        #endregion

        #region Ejercicio8(opcional)
        /* Utilizando el método de la clase Console void SetCursorPosition(int letf, int top); que situa
el cursor en una cordenada dentro de las 24 filas y 80 columnas que puede tener una
consola con origen en la esquina superior izquierda.
Se nos piden las siguientes especificaciones para un programa en C#:
• Deberemos introducir por teclado las coordenadas de 5 puntos y el carácter
unicode a dibujar en cada punto.
• Además almacenaremos los datos en una tabla definida de la siguiente manera:
 Estrella[] estrellas = new Estrella[NumPuntos];
• Borraremos la pantalla con el método Clear() de la clase Console.
• Dibujaremos el carácter en cada una de las coordenadas introducidas.
• Esperaremos la pulsación de una tecla. */
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
        /* Se desea realizar la gestión del ingreso de pacientes en los 4 hospitales existentes.
                • La información que se guarda sobre los hospitales es: nombre, número de plantas (que no puede exceder de 7) y la información de cada una de las plantas.

                • La información de las plantas está compuesta de: especialidad, número de habitaciones (que no puede exceder de 20).

                • La información sobre las habitaciones que consta de: número de camas (que no pueden exceder de 3) y situación de las camas (es decir libres u ocupadas).
                   
            Realizar un programa con los métodos necesarios para, recoger los datos de los cuatro hospitales, mostrar la información de todos los hospitales, 
            mostrar la información de un hospital en particular y modificar la información de un hospital en particular. */
        class Ejercicio9

        {
            //public struct Hospitales
            //{
            //    public string Nombre;

            //}
            //static void Main()
            //{
            //}
        }

        #endregion
    }
}
