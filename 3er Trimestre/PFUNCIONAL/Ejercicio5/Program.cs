using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    /* Vamos ha realizar una serie de operaciones funcionales usando funciones-λ 
     * con el patrón MAP – FILTER – REDUCE (Select – Where – Aggregate en C#) 
     * Partiendo de la siguiente lista de números reales:
     *         List<double> reales = new List<double> { 
     *              0.5, 1.6, 2.8, 3.9, 4.1, 5.2, 6.3, 7.4, 8.1, 9.2 
     *          };
     * 
     * Vamos a realizar las siguientes operaciones: 
     *      1. Mostrar la lista usando el método ForEach(Action<T> action) 
     *         de lista. Pasando a la función-λ action, una clausura de la 
     *         variable string texto, en la que iremos componiendo su contenido
     *         separado por un espacio en blanco. 
     *      2. Cuenta aquellos elementos cuya parte decimal es menor que 0.5 
     *          ◦ Map: Paso del valor real a su parte decimal. Ej: 2.8 → 0.8 
     *          ◦ Filter: Filtro aquellas partes decimales que cumplen el 
     *            predicado: d < 0.5 
     *          ◦ Reduce: Contar los elementos en la secuencia resultante. 
     *      3. Calcular la suma de todos los valores de la secuencia cuya parte 
     *         entera sea múltiplo de 3. 
     *          ◦ Map: Mapea el valor real a un objeto anónimo con la parte 
     *            entera y el propio valor real de la secuencia. 
     *            Ej: 2.8 → new { e = 2, r = 2.8 } 
     *          ◦ Filter: Filtro aquellas partes enteras que cumplen el 
     *            predicado:  o.e % 3 == 0 
     *          ◦ Reduce: Suma todos los o.r de la secuencia resultante. 
     *      4. Calcular el máximo valor de la secuencia cuya parte decimal es 
     *         mayor que 0.5 
     *          ◦ Map: Mapea el valor real a un objeto anónimo con la parte 
     *            decimal y el propio valor real de la secuencia. 
     *            Ej: 2.8 → new { d = 0.8, r = 2.8 } 
     *          ◦ Filter: Filtro aquellas partes decimales que cumplen el 
     *            predicado: o.d < 0.5 
     *          ◦ Reduce: Me quedo con el máximo de todos los o.r de la 
     *            secuencia resultante. 
     *      5. Ampliación: Muestra aquellos elementos de la secuencia cuya parte 
     *         entera es un valor primo. Nota: Seguramente has de hacer más de
     *         un Filter e incluso otro Filter dentro de uno de ellos. Además,
     *         para crear un predicado que me diga si un número primo de forma
     *         funcional (pero poco eficiente) puedes hacer lo siguiente … 
     *          1. Generar una secuencia entre 2 y la parte entera menos uno 
     *             con Enumerable.Range() 
     *          2. Filtrar aquellos valores divisibles por la parte entera. 
     *          3. Preguntar si la secuencia resultante tiene 0 elementos. 
     *      Una posible salida del programa debería ser... */
    class Program
    {
        static void Main(string[] args)
        {

            #region parte1
            List<double> reales = new List<double> { 0.5, 1.6, 2.8, 3.9, 4.1, 5.2, 6.3, 7.4, 8.1, 9.2 };

            string texto = "";

            reales.ForEach(numero => texto += $"{numero} ");

            Console.WriteLine(texto);
            #endregion

            #region parte2
            int numElementos = reales.Select(x => x % 1)
                  .Where(x => x < 0.5)
                  .Aggregate(0,(suma, numeros) => suma + 1);

            Console.WriteLine(numElementos);


            #endregion

            #region parte3

            double sumaValoresMultiplo3 = reales.Select(x => new { Entera = Math.Truncate(x), Real = x })
                                             .Where(y=> y.Entera>0 && y.Entera%3==0)
                                             .Aggregate(0d, (suma,o) => suma+ o.Real);

            Console.WriteLine(sumaValoresMultiplo3);

            #endregion

            #region parte4

            double maximoValorSecuencia = reales.Select(x => new { d = x % 1, r = x })
                                                .Where(x => x.d > 0.5)
                                                .Aggregate(0d, (maximo, n) => maximo>n.r? maximo : n.r);

            Console.WriteLine(maximoValorSecuencia);

            #endregion

            #region parte5
            
            reales.Select(x => new { e = Math.Truncate(x), r = x })
                  .Where(o => o.e>=2)
                  .Where(o => 
                  {                     
                    var lista = Enumerable.Range(2, (int)(o.e - 1));

                    int elementos = lista.ToList().Where(e => o.e % e == 0).Aggregate(0, (sum, x) => sum + 1);
                    
                    return elementos == 1;                                   
                  })
                  .ToList().ForEach(x=> Console.Write($"{x.r} "));
            
            #endregion


        }
    }
}
