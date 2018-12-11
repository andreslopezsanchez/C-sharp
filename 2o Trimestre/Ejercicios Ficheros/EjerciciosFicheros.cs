using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication16
{
    #region Ejercicio1
    /* Como se explica en el tema, para crearlas rutas debemos utilizar la clase Path. 
     * Esta clase tiene varios métodos que no se nombran en el tema pero que son útiles para trabajar con rutas. 
     * Vas a crear un programa para mostrar que hace cada uno de estos métodos. Como mínimo deberás utilizar los siguientes: 
     * string GetExtension(string ruta) 
     * string GetFileName(string ruta) 
     * string GetFileNameWithoutExtension(string ruta) 
     * string GetDirectoryName(string ruta) 
     * string GetPathRoot(string ruta) 
     * string ChangeExtension(string ruta, string nuevaExtensión) 
     * string GetFullPath(string rutaRelativa) 
     * string Combine(string ruta1, string ruta2)*/
    class EjerciciosFicheros
    {
        //static void Main(string[] args)
        //{
        //    char s = Path.DirectorySeparatorChar;
        //    string ruta = $"C:{s}programacion{s}ejercicios{s}datos.txt";
        //    string ruta2 = $"1aEv{s}Ficheros{s}";
        //    Console.WriteLine($"GetExtencion: {Path.GetExtension(ruta)}");
        //    Console.WriteLine($"GetFileName: {Path.GetFileName(ruta)}");
        //    Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(ruta)}");
        //    Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(ruta)}");
        //    Console.WriteLine($"GetPathRoot: {Path.GetPathRoot(ruta)}");
        //    Console.WriteLine($"ChangeExtension: {Path.ChangeExtension(ruta, ".html")}");
        //    Console.WriteLine($"GetFullPath: {Path.GetFullPath($".{s}")}");
        //    Console.WriteLine($"Combine: {Path.Combine(Path.GetDirectoryName(ruta), ruta2)}");
        //}
    }
    #endregion
    #region Ejercicio2
    /*Crear un programa que tenga los siguientes métodos, que podrán llamarse mediante un
      menú hasta que no se pulse a ESC.
        1. CreaArbolDeDirectorios: Que te creará el siguiente árbol de directorios:
        2. EliminaDirectorio: Al que le pasarás una ruta y te eliminará el directorio
           correspondiente a esa ruta.
        3. EliminaFichero: Idem al anterior pero con ficheros.
        4. MuestraInformación: Que te mostrará el contenido del directorio que le
           indiques.
        5. MuestraAtributos: Que te mostrará los principales atributos del fichero que le
           indiques.*/

    class Ejercicio2
    {

        //public static void CreaArbolDeDirectorios(char s)
        //{


        //    Directory.CreateDirectory($"C:{s}nombres");
        //    Directory.CreateDirectory($"C:{s}nombres{s}pepe");
        //    Directory.SetCurrentDirectory($"C:{s}nombres{s}pepe");
        //    Directory.CreateDirectory($"..{s}juan");
        //    Directory.SetCurrentDirectory($"C:{s}nombres{s}pepe");
        //    Directory.CreateDirectory("datos");
        //    File.Create($".{s}documento.txt").Close();
        //}

        // public static void EliminaDirectorios(char s)
        //  {
        //      Directory.SetCurrentDirectory($"C:{s}nombres");
        //      Directory.Delete($"C:{s}nombres{s}pepe", true);
        //  }

        ///*public static void EliminaFichero(char s)
        //{
        //    File.Delete($"C:{s}nombres{s}pepe{s}documento.txt");
        //}*/
        //public static void MuestraInformacion(char s, string tab, string ruta)
        //{


        //   /* tab = $"\t";

        //    DirectoryInfo infoCarpeta = new DirectoryInfo(ruta);

        //    FileSystemInfo[] infoaMostrar = infoCarpeta.GetFileSystemInfos();

        //    foreach (FileSystemInfo informacion in infoaMostrar)
        //    {
        //        bool esCarpeta = ((informacion.Attributes & FileAttributes.Directory) == FileAttributes.Directory);
        //        bool esArchivo = ((informacion.Attributes & FileAttributes.Archive) == FileAttributes.Archive);

        //        if (esCarpeta)
        //        {
        //            DirectoryInfo informacionCarpeta = (DirectoryInfo)informacion;
        //            Console.WriteLine($"Carpeta: {informacionCarpeta.FullName}");
        //            Console.WriteLine(tab + $"Fecha y hora de la creacion del directorio:{ informacionCarpeta.CreationTime}");
        //            MuestraInformacion(s, tab, ruta);
        //        }
        //        else
        //        {
        //            FileInfo informacionArchivo = (FileInfo)informacion;
        //            Console.WriteLine($"Archivos: {informacionArchivo.FullName}");
        //            Console.WriteLine(tab + $"Fecha y hora de la creacion del archivo: {informacionArchivo.CreationTime}");
        //        }
        //    }*/
        //}
        //public static void MuestraAtributos(char s)
        //{
        //    //usar mascaras con los apartados que yo crea oportunos.
        //}

        //static void Main(string[] args)
        //{
        //    char s = Path.DirectorySeparatorChar;
        //    string ruta = $"C:{s}nombres{s}pepe";

        //    string tab = $"\t";
        //    CreaArbolDeDirectorios(s);
        //    EliminaDirectorios(s);
        //    /* EliminaFichero(s);*/
        //    MuestraInformacion(s, tab, ruta);
        //    MuestraAtributos(s);

        //}
    }
    #endregion
    #region Ejercicio3
    /* Escribe un programa que cree un fichero de texto de nombre ‘datos.txt’ que se encuentre en la carpeta datos
     * del directorio raíz de la unidad C (es importante que la ruta introducida sea independiente de la plataforma utilizada). 
     * 
     * El programa deberá comprobar si la carpeta existe y si no es así la creará. En ese fichero iremos guardando carácter a carácter 
     * los que se introduzca por teclado usando por ejemplo un adaptador BinaryWriter.  Finalizaremos la introducción con CTRL + Z
    */
    class Ejercicio3
    {
        
        //static void Main(string[] args)
        //{
        //    char s = Path.DirectorySeparatorChar;
        //    Directory.CreateDirectory($"C:{s}datos");
        //    Directory.SetCurrentDirectory($"C:{s}datos");

        //    FileStream fichero = new FileStream($"datos.txt", FileMode.Create, FileAccess.Write);
        //    Console.WriteLine("Escribe lo que quieras añadir al documento:");
        //    BinaryWriter adaptador = new BinaryWriter(fichero);

        //    ConsoleKeyInfo caracterUsuario;
        //    bool ctrlZPressed;
        //    bool ctrlCPressed;
        //    do
        //    {
        //        caracterUsuario = Console.ReadKey();
        //        ctrlZPressed = caracterUsuario.Modifiers == ConsoleModifiers.Control
        //                        && caracterUsuario.Key == ConsoleKey.Z;
        //        /* (caracterUsuario.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control*/
        //        ctrlCPressed = caracterUsuario.Modifiers == ConsoleModifiers.Control
        //                        && caracterUsuario.Key == ConsoleKey.C;
        //        if (!ctrlZPressed)
        //        {
        //            adaptador.Write(caracterUsuario.KeyChar);
        //            adaptador.Flush();
        //        }

        //    } while (!ctrlZPressed /*&& ctrlCPressed*/);

        //    adaptador.Close();
        //}
    }
    #endregion
    #region Ejercicio4
    /* Realiza un programa que visualice en pantalla el contenido de un fichero de texto unicode cuyo nombre es introducido por teclado. 
     * Intenta hacer la lectura de los caracteres usando un adaptador BinaryReader.
     * Para leer del teclado la ruta del fichero crea una función llamada: 
     * 
     * static string LeeRuta(string textoIndicandoLaEntrada) 
     * 
     * La cual me devolverá siempre una ruta a un fichero válida y si no es correcta, avisará al usuario pidiéndosela de nuevo. 
     * Nota: Esta función puede serte de utilidad en futuros ejercicios.*/
    class Ejercicio4
    {

        //public static string LeeRuta(string textoIndicandoLaEntrada)
        //{
        //    string ruta;
        //    do
        //    {
        //        Console.WriteLine(textoIndicandoLaEntrada);
        //        ruta = Console.ReadLine();

        //        if (!File.Exists(ruta))
        //            Console.WriteLine("El fichero no existe, vuelve a introducirlo:");

        //    } while (!File.Exists(ruta));

        //    return ruta;
        //}

        //static void Main(string[] args)
        //{
        //    string textoIndicandoLaEntrada = "Dime que fichero quieres que te muestre su contenido:";
        //    string ruta = LeeRuta(textoIndicandoLaEntrada);

        //    FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);

        //    BinaryReader adaptador = new BinaryReader(archivo, Encoding.UTF8);

        //    char c;
        //    while (archivo.Position < archivo.Length)
        //    {
        //        Console.Write(c = adaptador.ReadChar());
        //    }
        //}
    }
    #endregion
    #region Ejercicio5
    /* Diseña una función que reciba dos cadenas de caracteres como parámetros, correspondientes a las rutas a 
     * dos ficheros de texto (origen y destino) Esta función función copiará el contenido del primer fichero sobre 
     * el segundo dejando el fichero original intacto. La operación de copiar se deberá realizar byte a byte mediante FileStreams.*/
    class Ejercicio5
    {
        //public static string LeeRuta(string textoIndicandoLaEntrada)
        //{
        //    string ruta;
        //    do
        //    {
        //        Console.WriteLine(textoIndicandoLaEntrada);
        //        ruta = Console.ReadLine();

        //        if (!File.Exists(ruta))
        //            Console.WriteLine("El fichero no existe, vuelve a introducirlo:");

        //    } while (!File.Exists(ruta));

        //    return ruta;
        //}

        //static void CopiarArchivo(string rutaOrigen, char s)
        //{
        //    FileStream archivoOrigen = new FileStream(rutaOrigen, FileMode.Open, FileAccess.Read);
        //    FileStream archivoDestino = new FileStream($"c:{s}datos{s}datosDestino.txt", FileMode.Create, FileAccess.Write);

        //    byte[] datos = new byte[1];

        //    int leido;
        //    do
        //    {
        //        leido = archivoOrigen.Read(datos, 0, datos.Length);

        //        if (leido > 0)
        //            archivoDestino.Write(datos, 0, datos.Length);
        //    } while (leido >= datos.Length);
    

        //}

        //static void Main(string[] args)
        //{
        //    char s = Path.DirectorySeparatorChar;
        //    string textoIndicandoLaEntrada = "Dime el archivo que quieras copiar";
        //    string rutaOrigen = LeeRuta(textoIndicandoLaEntrada);
        //    CopiarArchivo(rutaOrigen, s);
        //}
    }
    #endregion
    #region Ejercicio6
    /* Realiza un programa que cuente el número de caracteres de texto unicode de un fichero. 
     * Nota: El número de caracteres no tiene porque coincidir con el número de bytes. 
     * Para hacer la lectura del fichero debes usar un adaptador StreamReader. 
     * El nombre del fichero será pasado como argumento en la línea de órdenes*/
    class Ejercicio6
    {

        //static void Main(string[] args)
        //{
        //    if (File.Exists(args[0]))
        //    {
        //        FileStream archivo = new FileStream(args[0], FileMode.Open, FileAccess.Read);
        //        StreamReader adaptadorLeer = new StreamReader(archivo, Encoding.UTF8);

        //        string texto = adaptadorLeer.ReadToEnd();
        //        Console.WriteLine($"Tiene {texto.Length} numero de caracteres");
        //    }
        //    else
        //        Console.WriteLine("El fichero no existe, vuelve a introducirlo.");
        //}
    }
    #endregion
    #region Ejercicio7 (AMPLIACION) NO HACER
    /* Programa que funcione como el copy del dos, metiendo los argumentos en la línea de órdenes y
     * comprobando que funciona correctamente. A diferencia del ejercicio 5 en lugar de copiar byte en byte debes crear un 
     * BufferedStream de con un buffer de 100000 Bytes que utilizaremos para ir copiando de 100 KB en 100 KB*/
    class Ejercicio7
    {
        //  static void Main(string[] args)
        //  {
        //  }
    }
    #endregion
    #region Ejercicio8 IMPORTANTE
    /*Escribe un programa que gestione datos de Alumnos y los almacene en un fichero binario.
     * 
     * 1) Definiremos la estructura Alumno con los campos: Nombre, Apellido y Edad. 
     * 2) Definiremos un menú con las siguientes opciones: 
     *          a. Introduce Alumno: El cual pedirá los datos de un alumno y lo almacenará en binario en 
     *             un fichero denominados alumnos.dat en la misma carpeta del ejecutable. Si el archivo 
     *             existe se permitirá añadir al final más información sin eliminar el contenido. 
     *          b. Mostrar Alumos: La cual mostrará en pantalla el contenido del fichero alumnos.dat. 
     *          c. Buscar Alumno: Buscará en el fichero mostrará la información de un determinado alumno 
     *             a partir del apellido introducido. Piensa la correcta modularización para aislar la persistencia 
     *             de la entrada y salida de datos, así cómo repetir el menor código posible.*/
    class Ejercicio8
    {
        //public static void MostrarMenu()
        //{
        //    Console.Write(" a.-Introduce Alumno \n" +
        //                  " b.-Mostrar Alumnos \n" +
        //                  " c.-Buscar Alumno \n" +
        //                  " 0.- Salir \n" +
        //                  "Elige una opcion: ");
        //}

        //public struct Alumno
        //{
        //    public string Nombre;
        //    public string Apellido;
        //    public ushort Edad;
        //}

        //public static Alumno AñadeAlumno()
        //{
        //    Alumno alumno;
        //    Console.WriteLine("Nombre: ");
        //    alumno.Nombre = Console.ReadLine();
        //    Console.WriteLine("Apellido: ");
        //    alumno.Apellido = Console.ReadLine();
        //    Console.WriteLine("Edad: ");
        //    alumno.Edad = ushort.Parse(Console.ReadLine());

        //    return alumno;
        //}

        //public static void GuardaAlumno(string ruta, Alumno alumno)
        //{
        //    FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write);
        //    BinaryWriter adaptador = new BinaryWriter(archivo, Encoding.UTF8);

        //    adaptador.Write(alumno.Nombre);
        //    adaptador.Write(alumno.Apellido);
        //    adaptador.Write(alumno.Edad);

        //    adaptador.Close();
        //}

        //public static Alumno LeeAlumno(BinaryReader adaptadorLeer)
        //{
        //    Alumno alumno;
        //    alumno.Nombre = adaptadorLeer.ReadString();
        //    alumno.Apellido = adaptadorLeer.ReadString();
        //    alumno.Edad = adaptadorLeer.ReadUInt16();
        //    return alumno;

        //}

        //public static void MostrarAlumno(Alumno alumno)
        //{
        //    Console.WriteLine($"Nombre: {alumno.Nombre}\n" +
        //                      $"Apellido: {alumno.Apellido}\n" +
        //                      $"Edad: {alumno.Edad}\n");
        //}

        //public static void MostrarAlumnosGuardados(string ruta)
        //{
        //    FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        //    BinaryReader adaptadorLeer = new BinaryReader(archivo, Encoding.UTF8);

        //    while (archivo.Position < archivo.Length)
        //    {
        //        Alumno alumno = LeeAlumno(adaptadorLeer);
        //        MostrarAlumno(alumno);
        //    }
        //    adaptadorLeer.Close();
        //}

        //static bool BuscaAlumnoGuardado(string ruta, string apellido, out Alumno alumno)
        //{
        //    bool encontrado = false;
        //    alumno = new Alumno();
        //    FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        //    BinaryReader adaptadorLeer = new BinaryReader(archivo, Encoding.UTF8);

        //    while (archivo.Position < archivo.Length)
        //    {
        //        alumno = LeeAlumno(adaptadorLeer);
        //        if (alumno.Apellido == apellido)
        //        {
        //            encontrado = true;
        //            break;
        //        }
        //    }
        //    adaptadorLeer.Close();
        //    return encontrado;
        //}

        //static void Main(string[] args)
        //{

           
        //    const string RUTA = "alumnos.dat";
        //    char opcion = Console.ReadKey().KeyChar;

        //    do
        //    {
        //        MostrarMenu();
        //        opcion = Char.Parse(Console.ReadLine());
        //        switch (opcion)
        //        {
        //            case 'a':
        //                {
        //                    Alumno alumno = AñadeAlumno();
        //                    GuardaAlumno(RUTA, alumno);
        //                    break;
        //                }
        //            case 'b':
        //                MostrarAlumnosGuardados(RUTA);
        //                break;
        //            case 'c':
        //                {
        //                    Alumno alumno;

        //                    Console.WriteLine("Apellido a buscar: ");
        //                    string apellidoABuscar = Console.ReadLine();

        //                    if (BuscaAlumnoGuardado(RUTA, apellidoABuscar, out alumno))
        //                    {
        //                        Console.WriteLine("Encontrado!");
        //                        MostrarAlumno(alumno);
        //                    }
        //                    else
        //                        Console.WriteLine($"El alumno con apellido: {apellidoABuscar} no existe");
        //                    break;
        //                }
        //            case '0':
        //                Console.WriteLine("ADIOS!");
        //                break;
        //            default:
        //                Console.WriteLine("Opcion no reconocida, vuelve a intentarlo");
        //                break;
        //        }
        //    } while (opcion != '0');


        //}
    }
    #endregion
    #region Ejercicio9 IMPORTANTE
    /* Realiza el mismo programa del ejercicio 8 pero en lugar de guardar a un fichero en binario, guardaremos 
     * a un fichero de texto con codificación UTF8 y separado por comas CSV. 
     *                  a) El fichero a almacenar los datos se llamará alumnos.csv. 
     *                  b) La coma de separación de los campos será el carácter ‘;’ (punto y coma). 
     *                  c) Ten en cuenta que la primera línea del fichero csv guarda el nombre de los campos, 
     *                     por lo que tras guardar el nombre de 2 alumnos el aspecto puede ser el siguiente… 
     *                     
     *                  Apellido;Nombre;Edad 
     *                  Guarinos;Juanjo;46 
     *                  Garcia;Xusa;42 
     * Piensa la correcta modularización para aislar la persistencia de la entrada y salida de datos, así cómo repetir el menor código posible.*/
    class Ejercicio9
    {
        //public static void MostrarMenu()
        //{
        //    Console.Write(" a.-Introduce Alumno \n" +
        //                  " b.-Mostrar Alumnos \n" +
        //                  " c.-Buscar Alumno \n" +
        //                  " 0.- Salir \n" +
        //                  "Elige una opcion: ");
        //}
        //public struct Alumno
        //{
        //    public string Nombre;
        //    public string Apellido;
        //    public ushort Edad;
        //}
        //public static Alumno AñadeAlumno()
        //{
        //    Alumno alumno;
        //    Console.WriteLine("Nombre: ");
        //    alumno.Nombre = Console.ReadLine();
        //    Console.WriteLine("Apellido: ");
        //    alumno.Apellido = Console.ReadLine();
        //    Console.WriteLine("Edad: ");
        //    alumno.Edad = ushort.Parse(Console.ReadLine());

        //    return alumno;
        //}
        //public static void GuardaAlumno(string ruta, Alumno alumno)
        //{
        //    FileStream archivo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
        //    StreamWriter adaptador = new StreamWriter(archivo, Encoding.UTF8);

        //    if (archivo.Position==0)
        //    {
        //        adaptador.WriteLine("Nombre;Apellido;Edad");
        //    }

        //    adaptador.WriteLine($"{alumno.Nombre};" +
        //                        $"{alumno.Apellido};" +
        //                        $"{alumno.Edad}");


        //    adaptador.Close();
        //}
        //public static Alumno LeeAlumno(StreamReader adaptadorLeer)
        //{
         
        //    Alumno alumno;
        //    string lineaTexto= adaptadorLeer.ReadLine();
            
        //    string[] CadenaTexto = lineaTexto.Split(';');
            
        //    alumno.Nombre = CadenaTexto[0];
        //    alumno.Apellido = CadenaTexto[1];
        //    alumno.Edad = ushort.Parse(CadenaTexto[2]);

        //    return alumno;

        //}
        //public static void MostrarAlumno(Alumno alumno)
        //{
        //    Console.WriteLine($"Nombre: {alumno.Nombre}\n" +
        //                      $"Apellido: {alumno.Apellido}\n" +
        //                      $"Edad: {alumno.Edad}\n");
        //}
        //public static void MostrarAlumnosGuardados(string ruta)
        //{
        //    FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        //    StreamReader adaptadorLeer = new StreamReader(archivo, Encoding.UTF8);

        //    while (archivo.Position < archivo.Length)
        //    {
        //        Alumno alumno = LeeAlumno(adaptadorLeer);
        //        MostrarAlumno(alumno);
        //    }
        //    adaptadorLeer.Close();
        //}
        //static bool BuscaAlumnoGuardado(string ruta, string apellido, out Alumno alumno)
        //{
        //    bool encontrado = false;
        //    alumno = new Alumno();
        //    FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        //    StreamReader adaptadorLeer = new StreamReader(archivo, Encoding.UTF8);

        //    while (!adaptadorLeer.EndOfStream)
        //    {
        //        alumno = LeeAlumno(adaptadorLeer);
        //        if (alumno.Apellido == apellido)
        //        {
        //            encontrado = true;
        //            break;
        //        }
        //    }
        //    adaptadorLeer.Close();
        //    return encontrado;
        //}
        //static void Main(string[] args)
        //{
        //    const string RUTA = "alumnos.csv";
        //    char opcion = '0';

        //    do
        //    {
        //        MostrarMenu();
        //        opcion = Char.Parse(Console.ReadLine());
        //        switch (opcion)
        //        {
        //            case 'a':
        //                {
        //                    Alumno alumno = AñadeAlumno();
        //                    GuardaAlumno(RUTA, alumno);
        //                    break;
        //                }
        //            case 'b':
        //                MostrarAlumnosGuardados(RUTA);
        //                break;
        //            case 'c':
        //                {
        //                    Alumno alumno;

        //                    Console.WriteLine("Apellido a buscar: ");
        //                    string apellidoABuscar = Console.ReadLine();

        //                    if (BuscaAlumnoGuardado(RUTA, apellidoABuscar, out alumno))
        //                    {
        //                        Console.WriteLine("Encontrado!");
        //                        MostrarAlumno(alumno);
        //                    }
        //                    else
        //                        Console.WriteLine($"El alumno con apellido: {apellidoABuscar} no existe");
        //                    break;
        //                }
        //            case '0':
        //                Console.WriteLine("ADIOS!");
        //                break;
        //            default:
        //                Console.WriteLine("Opcion no reconocida, vuelve a intentarlo");
        //                break;
        //        }
        //    } while (opcion != '0');
        //}
    }
    #endregion
    #region Ejercicio10
    /*  Escribe un programa que contiene un método que recibe el nombre de un fichero a partir
        del cual crea un segundo fichero de nombre ‘copia.txt’, cuyo contenido es la información
        almacenada en el fichero origen, pero sin espacios en blanco, tabuladores y cambios de
        línea.*/
    class Ejercicio10
    {

        public static void RellenarArchivoOrigen(string rutaOrigen)
        {
            FileStream archivoOrigen = new FileStream(rutaOrigen, FileMode.Create, FileAccess.Write);
            StreamWriter adaptadorEscribir = new StreamWriter(archivoOrigen, Encoding.UTF8);

            Console.WriteLine("Escribe lo que quieras rellenar en el archivo origen: ");
            string textoEscrito = Console.ReadLine();
            adaptadorEscribir.Write(textoEscrito);


            adaptadorEscribir.Close();


        }


        public static string CrearTextoACopiar(string rutaOrigen)
        {

            FileStream archivoOrigen = new FileStream(rutaOrigen, FileMode.Open, FileAccess.Read);
            StreamReader adaptadorLeer = new StreamReader(archivoOrigen, Encoding.UTF8);

            string textoEscrito = adaptadorLeer.ReadToEnd();


            char[] ComandosEscapar = new char[3];
            ComandosEscapar[0] = ' ';
            ComandosEscapar[1] = '\t';
            ComandosEscapar[2] = '\r';

            string[] cadenaTexto = textoEscrito.Split(ComandosEscapar);
            string textoAcopiar = "";

            for (int i = 0; i < cadenaTexto.Length; i++)
            {

                textoAcopiar += cadenaTexto[i];
            }

            return textoAcopiar;

        }


        public static void CopiarFichero(string rutaDestino, string rutaOrigen)
        {


            FileStream archivoDestino = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write);
            StreamWriter adaptadorCopiar = new StreamWriter(archivoDestino, Encoding.UTF8);
            string textoAcopiar = CrearTextoACopiar(rutaOrigen);

            adaptadorCopiar.Write(textoAcopiar);

            adaptadorCopiar.Close();

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Dime donde quieres crear el archivo origen");
            string rutaOrigen = Console.ReadLine();

            File.Create(rutaOrigen).Close();

            Console.WriteLine("Dime donde quieres crear el archivo destino");
            string rutaDestino = Console.ReadLine();

            RellenarArchivoOrigen(rutaOrigen);
            CopiarFichero(rutaDestino, rutaOrigen);

        }
    }
    #endregion
    #region Ejercicio11
    /* Dado un fichero de texto con codificación UTF8, escribe un programa que convierta los
       caracteres alfabéticos que aparecen en mayúscula por caracteres alfabéticos en minúscula y viceversa.

       Nota: El cambio deberá realizarse sobre el mismo fichero usando el método Seek de la
       clase FileStream.*/
    class Ejercicio11
    {
        //public static void RellenarArchivo(string ruta)
        //{
        //    FileStream archivoOrigen = new FileStream(ruta, FileMode.Create, FileAccess.Write);
        //    StreamWriter adaptadorEscribir = new StreamWriter(archivoOrigen, Encoding.UTF8);

        //    Console.WriteLine("Escribe lo que quieras rellenar en el archivo: ");
        //    string textoEscrito = Console.ReadLine();
        //    adaptadorEscribir.Write(textoEscrito);

        //    adaptadorEscribir.Close();

        //}

        //public static void CambioMaysMins()
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe ruta:");
        //    string ruta = Console.ReadLine();

        //    RellenarArchivo(ruta);

        //}
    }
    #endregion
    #region Ejercicio12 (AMPLIACION)
    /* Programa que permita buscar una palabra en uno o más ficheros de texto (introducidos en  la línea de comandos). 
     * Se necesitará un método BuscaEnFichero(string ruta, string palabra), que extraerá las líneas del fichero y 
     * llamará a la función BuscaEnCadena(string cadena, string palabra) que comprobará si las cadenas son iguales. En la línea de
       comandos introducirás la palabra y los nombres de fichero a buscar y te mostrará un
       mensaje para cada fichero, en el que te indicará si ha sido encontrada en ese fichero.

       FICHEROS + EXPRESIONES REGULARES*/
    class Ejercicio12
    {
        //  static void Main(string[] args)
        //  {
        //  }
    }
    #endregion
    #region Ejercicio13
    /*Programa que te muestre la línea o las líneas de un fichero que contengan una
      subcadena que nosotros indiquemos. Si no encuentra la subcadena en todo el fichero,
      nos mostrará un mensaje de CADENA NO ENCONTRADA. Para hacer este programa
      crearemos una expresión regular a partir de la cadena que nosotros indiquemos, que será
      la que se compare con las líneas extraídas.*/
    class Ejercicio13
    {
        //  static void Main(string[] args)
        //  {
        //  }
    }
    #endregion
    #region Ejercicio14 (AMPLIACION)
    /*Un diptongo está formado por dos vocales, una fuerte y una débil, o dos débiles. Las
      vocales fuertes son a, e, o; las vocales débiles son i, u. La acentuación de u o i destruye
      el diptongo. Crea un programa que, a partir de un archivo que nosotros indiquemos desde
      teclado y usando expresiones regulares, nos permita:

      a) mostrar todas las palabras con diptongo formado por dos vocales débiles, ordenadas y
         sin repetir.
      b) mostrar del mismo modo todos los diptongos con a.
      c) buscar una expresión regular mínima que despliegue todos los diptongos.*/
    class Ejercicio14
    {
        //  static void Main(string[] args)
        //  {
        //  }
    }
    #endregion
}
