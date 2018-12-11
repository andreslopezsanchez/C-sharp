using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// extension de ejercicio 3 de using, anonimos y extensores

/* A partir de la solución en el ejercicio 4. Rehaz los métodos ... 
*     • public bool EstaPrestado(String isbn) 
*     • public Libro BuscaPorISBN(String isbn) 
*     • public int CuentaLibrosConNumeroDePaginasMenorA(int num) 
*     • public void EliminaPorAutor(String autor) 
* Utilizando consultas de LINQ.*/

namespace BibliotecaExtensions
{
    using Ejercicio6;
    public static class BibliotecaExtension
    {
        public static string[] ISBNS(this Biblioteca b)
        {
       
            string[] arrayISBNS = new string[b.ListaLibros.Count];
            for (int i = 0; i < b.ListaLibros.Count; i++)
            {
                arrayISBNS[i] = b.ListaLibros[i].ISBN;
            }
            Array.Sort(arrayISBNS);
            return arrayISBNS;
        }
    }
}
namespace Ejercicio6
{
    using BibliotecaExtensions;
    class BibliotecaException : Exception
    {
        public BibliotecaException(string message) : base(message)
        {
            ;
        }
    }
    public  class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public short NumPaginas { get; set; }
        public string ISBN { get; set; }
        public string Reseña { get; set; }
       

        public override string ToString()
        {
            var libroAMostrar = new { titulo = Titulo, autor=Autor, isbn = ISBN};

            return libroAMostrar.ToString();
        }
    }

    public class Biblioteca
    {
        public string Nombre { get; set; }
        public List<Libro> ListaLibros { get; set; }
        public Biblioteca(string nombre, List<Libro> listaLibros)
        {
            Nombre = nombre;
            ListaLibros = listaLibros;
        }
     
        public void Presta(string dniSocio, string isbn)
        {
            if (BuscaPorISBN(isbn) != null)
            {
                var prestamo = new
                {
                    DNI = dniSocio,
                    Titulo = BuscaPorISBN(isbn).Titulo,
                    ISBN = isbn
                };
                using (FileStream archivo = new FileStream(@"C:\prueba1\prestamos.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter adaptador = new StreamWriter(archivo, Encoding.UTF8))
                    {
                        adaptador.WriteLine(prestamo.ToString());
                        adaptador.Close();
                    }
                }

            }
            else
            {
                throw new BibliotecaException("No existe ese libro en la bilbioteca");
            }

        }

        public Libro BuscaPorISBN(string isbn)
        {         
            List<Libro> libros =  new List<Libro>(  from i in ListaLibros
                                                    where i.ISBN == isbn
                                                    select i);
            if (libros.Count == 1)
                return libros[0];
            else
                return null;           
     
        }
        public bool EstaPrestado(string isbn)
        {             
            IEnumerable<string> estaPrestado = (from e in LibrosPrestados()
                                                where e.Contains(isbn)
                                                select e);
            return estaPrestado.Count()>0;
        }
        public int CuentaLibrosConNumeroDePaginasMenorA(int numPag) 
        {           
            List<Libro> librosConMenorNumPag = new List<Libro>( from libro in ListaLibros
                                                                where libro.NumPaginas < numPag
                                                                select libro);
            
            return librosConMenorNumPag.Count;
        }
        public void EliminaPorAutor(string autor)
        {            
            List<Libro> libroConAutor = new List<Libro> ( from libro in ListaLibros
                                                          where libro.Autor == autor
                                                          select libro);
            if (libroConAutor.Count > 0)
                libroConAutor.ForEach(x => ListaLibros.Remove(x));
        }

        public IEnumerable<string> LibrosPrestados()
        {
            using (FileStream archivo = new FileStream(@"C:\prueba1\prestamos.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader adaptador = new StreamReader(archivo, Encoding.UTF8))
                {
                    while(!adaptador.EndOfStream)
                        yield return adaptador.ReadLine();
                    
                }
            }
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                #region Definir lista nueva sintaxis
                List<Libro> libros = new List<Libro>
            {
                new Libro { Titulo =  "Don Quijote de la Mancha",
                            Autor =  "Miguel de Cervantes",
                            Editorial = "Editorial EDAF, S.A",
                            NumPaginas = 765,
                            ISBN = "9788441405298",
                            Reseña = "El libro, sinopsis… Nos presentan a este personaje como un loco trastornado a causa"+
                            " de las novelas de caballerías, pero, ¿Quién dice que el señor Quijana era sólo eso? ¿Por algún"+
                            " motivo será la cumbre de la literatura española verdad? Y aquí se plantea la duda héroe o "+
                            "simplemente viejo loco." },


                new Libro { Titulo = "El camino",
                            Autor = "Miguel Delibes",
                            Editorial= "Espasa",
                            NumPaginas =  187,
                            ISBN = "9788467023664",
                            Reseña= "Una de las más importantes obras de Miguel Delibes cuenta la historia de un niño , Daniel "+
                            "el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato. Una noche antes de partir"+
                            " Daniel recordará todo lo que le ha ocurrido en este lugar, sus amigos, sus peripecias, y descubrirá..."
                          },
                new Libro { Titulo= "Cien años de soledad",
                            Autor = "Gabriel García Márquez",
                            Editorial= "Alfaguara",
                            NumPaginas= 562,
                            ISBN= "9788420471839",
                            Reseña= "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de"+
                            " recordar aquella tarde remota en que su padre lo llevó a conocer el hielo.» Con estas palabras "+
                            "empieza una novela ya legendaria en los anales de la literatura universal, una de las aventuras "
                          },
                new Libro { Titulo= "La Regenta",
                            Autor= "Leopoldo Alas Clarín",
                            Editorial= "Crítica",
                            NumPaginas= 182,
                            ISBN= "9788484326977",
                            Reseña= "En La Regenta, sin lugar a dudas una de las cumbres de la novela realista, Leopoldo Alas "+
                            "alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron a la narrativa europea "+
                            "de la segunda mitad del siglo XIX: el retrato de un carácter femenino que se debate entre el deseo y..."
                          },
                new Libro { Titulo= "Los mejores cuentos de Clarín",
                            Autor= "Leopoldo Alas Clarín",
                            Editorial= "De Vecchi",
                            NumPaginas= 145,
                            ISBN= "9788431533441",
                            Reseña= "Una cuidadosa selección que nos muestra la riqueza de los recursos estilísticos de este gran"+
                            " escritor del s. XIX.En el volumen se incluyen: Doña Berta, Benedictino, Manín de Pepa José, Zurita,"+
                            " Cambio de luz, y la Conversión de Chiripa"
                          }
            };
                #endregion
                Biblioteca biblioteca = new Biblioteca("EL RINCÓN DE LEER", libros);
                biblioteca.Presta("22111333", "9788420471839");
                biblioteca.Presta("22111333", "9788431533441");
                Console.WriteLine(biblioteca.EstaPrestado("9788420471839"));
                Console.WriteLine(biblioteca.EstaPrestado("22111444"));
                Console.WriteLine(biblioteca.BuscaPorISBN("9788431533441"));     
                Console.WriteLine(biblioteca.BuscaPorISBN("97884551533441"));
                Console.WriteLine(biblioteca.CuentaLibrosConNumeroDePaginasMenorA(400));
                Console.WriteLine(biblioteca.BuscaPorISBN("9788467023664"));
                biblioteca.EliminaPorAutor("Miguel Delibes");          
                Console.WriteLine(biblioteca.BuscaPorISBN("9788467023664"));

                string[] isbnsOrdenados = biblioteca.ISBNS();

                for (int i = 0; i < isbnsOrdenados.Length; i++)
                {
                    Console.WriteLine(isbnsOrdenados[i]);
                }
            }
           catch(BibliotecaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception j)
            {
                Console.WriteLine(j.Message);
            }
        }
    }
}
