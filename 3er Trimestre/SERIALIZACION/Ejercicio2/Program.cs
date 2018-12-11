using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


/*Crea una clase Alumno con las siguientes propiedades: 
     * • Código • Curso • Nombre • Apellido • Edad • Sexo • Teléfono 
     * 
     * • Defínela con propiedades auto-implementadas y mutadores privados. 
     * • Define un constructor público que reciba todos los parametros. 
     * • Define un constructor privado que reciba un FileStream y construya un objeto Alumno deserializando 
     *   en binario desde la posición de ese stream. 
     * • Define el método privado void Serializa(FileStream s) que serialice a binario el alumno en 
     *   la posición actual de ese strea,
     * • Usando los métodos que acabas de definir. Añade también los métodos estáticos que te permitan realizar 
     *   las siguientes operaciones: 
     *          1. Haz lo necesario para almacenar la información de N alumnos en un fichero ‘alumos.dat’. 
     *          2. Listar el contenido del fichero en pantalla. 
     *          3. Buscar un registro en el fichero según el código dado. 
     *          4. Modificar los datos de cualquiera de los registros del fichero según el código dado. 
     *          5. Añadir un alumno al fichero. 
     * • Crea un programa principal para probar todos los métodos definidos.*/

namespace Ejercicio2
{  
    [Serializable]
    class Alumno
    {        
        public enum Sexos { macho, hembra };

        public const string FICHERO = "alumnos.dat";

        public int Codigo { get; private set; }
        public int Curso { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Edad { get; private set; }        
        public Sexos Sexo { get; private set; }
        public int Telefono { get; private set; }

        public Alumno(int codigo, int curso, string nombre, string apellido, int edad, Sexos sexo, int telefono)
        {
            Codigo = codigo;
            Curso = curso;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
            Telefono = telefono;
        }        
        private Alumno(FileStream s)
        {            
            IFormatter formatter = new BinaryFormatter();
            Alumno alumno = formatter.Deserialize(s) as Alumno;
            Codigo = alumno.Codigo;
            Curso = alumno.Curso;
            Nombre = alumno.Nombre;
            Apellido = alumno.Apellido;
            Edad = alumno.Edad;
            Sexo = alumno.Sexo;
            Telefono = alumno.Telefono;            
        }          
        private void Serializa( FileStream s)
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(s, this);
        }
        public static IEnumerable<Alumno> Carga()
        {
            using (FileStream archivo = new FileStream(FICHERO, FileMode.Open, FileAccess.Read))
            {
                while (archivo.Position < archivo.Length)
                    yield return new Alumno(archivo);
            }

        }

        public static void Añade(Alumno a)
        {
            using (FileStream archivo = new FileStream(FICHERO, FileMode.Append, FileAccess.Write))
            {
                a.Serializa(archivo);
            }
        }
        public static void Almacena(List<Alumno> alumnos, bool alFinal = true)
        {
            using (FileStream archivo = new FileStream(FICHERO, (alFinal)?FileMode.Append:FileMode.Create, FileAccess.Write))
            {           
                alumnos.ForEach(x => x.Serializa(archivo)); 
            }
        }                     
        public static Alumno BuscaAlumno(int codigoAlumno) 
        {
            IEnumerable<Alumno> als = Carga().Where(x => x.Codigo == codigoAlumno);
            return (als.Count() > 0) ? als.First() : null;       
        }   
        public static void MostrarFichero()
        {
            Carga().ToList().ForEach(x => Console.WriteLine(x));
        }
        public static void Modifica(int codigoAlumno)
        {       
            List<Alumno> alumnos = Carga().ToList();
            int i = Carga().ToList().FindIndex(x => x.Codigo == codigoAlumno);

            Console.WriteLine("Cambia curso: ");
                alumnos[i].Curso = int.Parse(Console.ReadLine());
            Console.WriteLine("Cambia nombre: ");
                alumnos[i].Nombre = Console.ReadLine();
            Console.WriteLine("Cambia apellido: ");
                alumnos[i].Apellido = Console.ReadLine();
            Console.WriteLine("Cambia edad: ");
                alumnos[i].Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cambia telefono");
                alumnos[i].Telefono = int.Parse(Console.ReadLine());

            bool alFinal = true;
            Almacena(alumnos, !alFinal);
        } 
        public override string ToString()
        {
            return $"{Codigo} - {Curso} - {Nombre},{Apellido} - {Edad} años - {Sexo} - Phone:{Telefono}";
        }
    }      
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno(123, 1, "felipe", "garcia", 23, Alumno.Sexos.macho, 654321123);
            Alumno a2 = new Alumno(324, 2, "antonia", "lopez", 45, Alumno.Sexos.hembra, 655789867);
            Alumno a3 = new Alumno(435, 3, "jesus", "vazquez", 16, Alumno.Sexos.macho, 609876543);

            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(a2);
            alumnos.Add(a3);
        
            Alumno.Añade(a1);
            Alumno.Almacena(alumnos);
            Alumno.MostrarFichero();
            Console.WriteLine("\n\n");
            Console.WriteLine(Alumno.BuscaAlumno(123));

            Console.WriteLine("\n\n");
            Alumno.Modifica(324);
            Alumno.MostrarFichero();
        }
    }
}
