using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    /* Crear una clase llamada TablaEnteros que no permita que se creen objetos a partir de ella. 
     * Esta clase almacenará una tabla de enteros de un tamaño que debe ser especificado mediante su constructor.  
     * La clase debe obligar a que  cualquier clase que herede de ella y no quiera ser una clase abstracta, implemente 
     * un método llamado GuardarNumerosenTabla.  Además, TablaEnterps dispondrá de un método redefinible MostrarTabla para 
     * mostrar la tabla completa por pantalla y decir cuántos elementos tiene y otro SumaPropia que se encargará de comprobar 
     * si existen más números positivos o negativos en la tabla y mostrar la suma de aquellos de los que hay mayor cantidad. 
     * Crear a partir de esta clase dos nuevas clases llamadas: 
     *      • TablaImpares: que solo guardará números impares. 
     *      • TablaPares: que solo guardará números pares. 
     *      • Ambas, lo harán mediante el método GuardarNumerosEnTabla antes mecionado que seleccionará los números apropiados 
     *        (pares o impares) a guardar, de una lista introducida por el usuario.
     *         
     * Crea instancias de cada una de estas  clases, dales valores y muestra las tablas y la suma propia de ambos objetos por pantalla.*/
   public  class Program
    {
        static void Main(string[] args)
        {
            int[] tablaEnteros = new int[]
                {
                   1,2,3,4,5,6,7,8
                };
            TablaEnteros tablaPares = new TablaPares(tablaEnteros);
            TablaEnteros tablaImpares = new TablaImpares(tablaEnteros);
            tablaPares.MostrarTabla(tablaEnteros);
            tablaImpares.MostrarTabla(tablaEnteros);
           
        }
    }
}

