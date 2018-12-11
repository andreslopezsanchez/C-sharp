using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
 /* Crea una aplicación que sirva para buscar coincidencias en una lista de 
  * cadenas. Para ello, asignaremos a un delegado genérico una una función-λ 
  * que reciba una lista y una cadena y sobre la lista con el método FindAll 
  * busque la cadena. 
  * 
  * Ten en cuenta que el método FindAll necesitará un predicado para el cual 
  * utilizaremos otra función-λ para formarlo. 
  * 
  * Nota: Puede serte de utilidad la operación Contains sobre cadenas. 
  * Por último, muestra con un foreach la lista resultante que devuelve el delegado.*/
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Hola");
            lista.Add("caracola");
            lista.Add("Adios");
            string texto = "Hola que tal caracola, pues xao";
          
            Action<List<string>, string> MuestraCoincidencias;

            MuestraCoincidencias = (x, y) => {
                                                 Console.WriteLine($"\nCoinciden estas palabras de la lista en el texto: ");

                                                 x.FindAll(i => y.Contains(i)).ForEach(c =>
                                                 {
                                                     Console.WriteLine($" \"{c}\" ");
                                                 });
                                             };

            Console.WriteLine($"texto: {texto}");
            Console.Write($"Lista: ");
            foreach (var item in lista)
            {
                Console.Write($" \"{item}\" ");
            }

            MuestraCoincidencias(lista, texto);
        }
    }
}
