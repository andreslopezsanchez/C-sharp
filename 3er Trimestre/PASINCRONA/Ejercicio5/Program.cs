using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
 /* Vamos ha realizar un programa de consola que se sindique a contenidos RSS de la sección 
  * internacional de algunos periódicos españoles filtrando por una palabra clave. 
  *     1. Prediremos la palabra para filtrar titulares. Ej: Nombre presidente EE.UU 
  *     2. Definiremos un diccionario donde la clave sea el nombre del diario y el valor 
  *        la URL con el XML a sindicar. Por ejemplo: 
  *             El País → https://elpais.com/tag/rss/estados_unidos/a/ 
  *             La Razón → https://www.larazon.es/rss/internacional.xml 
  *             ABC → http://www.abc.es/rss/feeds/abc_Internacional.xml 
  *             El Diario → https://www.eldiario.es/rss/section/4000/ 
  *         
  *             Nota: Estos enlaces pueden estar obsoletos, pruébalos por si hay que actualizarlos. 
  *     3. Para realizar las tareas asíncronas deberemos usar las cláusulas async y await. 
  *     4. Para filtrar los titulares extraeremos mediante una ER el contenido entre las 
  *        etiquetas <title> … </title> en algunas sindicaciones podremos encontrar la 
  *        <title><![CDATA[ … ]]></title> que podremos tener en cuenta en la propia ER o 
  *        eliminar de la cadena resultante mediante un “mapeo” después del filtrado. 
  *     5. El programa principal se quedará en un bucle que indique que se está haciendo la búsqueda*/
    class Program
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        static void SituaYDibuja(
                     int col, int fila,
                     string texto,
                     ConsoleColor colorFondo,
                     ConsoleColor colorLetra)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(col, fila);
            Console.BackgroundColor = colorFondo;
            Console.ForegroundColor = colorLetra;
            Console.Write(texto); Console.ResetColor();
        }

        static void Main(string[] args)
        {
        }
    }
}
