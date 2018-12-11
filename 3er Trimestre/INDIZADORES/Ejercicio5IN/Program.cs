using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5IN
{
    /* • Vamos a encapsular en una clase denominada Presupuestos una matriz cruzada de 
     *   presupuestos donde las filas sean los conceptos las cuales podrán ser: 
     *   Comida, Casa y Entretenimiento (enumeración). 
     *  
     * • Las columnas se corresponderán con los 12 meses del año (enumeración). 
     *   De tal manera que el contenido de una celda me indicará el presupuesto 
     *   de un concepto para un determinado mes. 
     *   
     * • Inicializaremos la matriz de tal manera que en cada mes para comida 
     *   tendremos un presupuesto de 300 € para la casa de 500 € y para 
     *   entretenimiento de 200 €. Esto lo haremos usando un for para recorrer 
     *   la enumeración meses. 
     *   
     * • Deberemos, además, crear un indizador para la clase Presupuestos que 
     *   me devuelva el presupuesto para un objeto de esta clase indexado por 
     *   dos enteros, dos valores enumerados de concepto y mes, y dos cadenas 
     *   indicando también el concepto y el mes. Además, la clase presupuesto 
     *   redefinirá el método ToString() para devolverme una cadena que me 
     *   muestre mis presupuestos por meses en un primer nivel y en un segundo 
     *   nivel por conceptos. 
     *   
     * • Usa la implementación de estos indizadores para la inicialización en 
     *   el Constructor (utilizando this) y el recorrido para visualización en el método ToString();*/
    class Program
    {
        static void Main(string[] args)
        {
            Presupuestos p = new Presupuestos();
        }
    }
}
