using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crea una clase Libro con los siguientes Propiedades públicas Titulo, 
 * Autor, Editorial, NumPaginas (short), ISBN,  y Reseña (de tipo String) 
 * y no definas un constructor para la misma. Dada la siguiente definición 
 * de una lista de objetos libro 
 * 
 * Termina de definir la lista de libros utilizando la siguiente sintaxis 
 * utilizada en el ejemplo con los siguientes datos… 
 * 
 *  Define la misma lista cómo un array de tipos inmutable … 
 *      var listaInmutable = new[] { … }  
 *  ¿Qué diferencia hay entre uno y otro? 
 *  ¿Pon un ejemplo en el programa principal? 
 */
namespace Ejercicio1
{
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public short  NumPaginas { get; set; }
        public string ISBN { get; set; }
        public string Reseña { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region Definir lista nueva sintaxis
            List<Libro> listaLibro = new List<Libro>
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

            #region Definir lista tipo inmotuble

            var listaInmutable = new []
            {
                new  { Titulo =  "Don Quijote de la Mancha",
                            Autor =  "Miguel de Cervantes",
                            Editorial = "Editorial EDAF, S.A",
                            NumPaginas = 765,
                            ISBN = "9788441405298",
                            Reseña = "El libro, sinopsis… Nos presentan a este personaje como un loco trastornado a causa"+
                            " de las novelas de caballerías, pero, ¿Quién dice que el señor Quijana era sólo eso? ¿Por algún"+
                            " motivo será la cumbre de la literatura española verdad? Y aquí se plantea la duda héroe o "+
                            "simplemente viejo loco." },


                new  { Titulo = "El camino",
                            Autor = "Miguel Delibes",
                            Editorial= "Espasa",
                            NumPaginas =  187,
                            ISBN = "9788467023664",
                            Reseña= "Una de las más importantes obras de Miguel Delibes cuenta la historia de un niño , Daniel "+
                            "el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato. Una noche antes de partir"+
                            " Daniel recordará todo lo que le ha ocurrido en este lugar, sus amigos, sus peripecias, y descubrirá..."
                          },
                new { Titulo= "Cien años de soledad",
                            Autor = "Gabriel García Márquez",
                            Editorial= "Alfaguara",
                            NumPaginas= 562,
                            ISBN= "9788420471839",
                            Reseña= "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de"+
                            " recordar aquella tarde remota en que su padre lo llevó a conocer el hielo.» Con estas palabras "+
                            "empieza una novela ya legendaria en los anales de la literatura universal, una de las aventuras "
                          },
                new  { Titulo= "La Regenta",
                            Autor= "Leopoldo Alas Clarín",
                            Editorial= "Crítica",
                            NumPaginas= 182,
                            ISBN= "9788484326977",
                            Reseña= "En La Regenta, sin lugar a dudas una de las cumbres de la novela realista, Leopoldo Alas "+
                            "alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron a la narrativa europea "+
                            "de la segunda mitad del siglo XIX: el retrato de un carácter femenino que se debate entre el deseo y..."
                          },
                new  { Titulo= "Los mejores cuentos de Clarín",
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

           // listaLibro[1].NumPaginas = 14; Aquí comprobamos que puede ser mutable
           // listaInmutable[1].NumPaginas = 1; Aquí como bien dice su definicion es inmutable y no podemos modificar su valor
        }
    }
}
