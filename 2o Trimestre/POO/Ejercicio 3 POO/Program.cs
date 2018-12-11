using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /*A partir del siguiente texto: 
     * 
     * Una cadena de muebles a nivel nacional tiene tiendas ubicadas por toda
     *  la geografía española. Cada una de estas tiendas de muebles almacena información 
     *  sobre: sofás, sillas y mesas. De todos ellos es común como mínimo, color(enumeración), 
     *  peso, dimensiones (estructura), fabricante, y precio.  
     *  
     *  En cambio los sofás incluye información de la tela con el que está tapizado y si es 
     *  abatible o no, las sillas la longitud del respaldo y las mesas el tipo de madera 
     *  que está hecho. 
     *  
     *  
     *  
     *  
     *  Crea una clase mueble que contenga los campos, constructores y los métodos necesarios para 
     *  recoger la información de un mueble común a todos ellos y mostrar esa información.*/

    class Program
    {
        static void Main(string[] args)
        {

            Mueble.Color color = Mueble.Color.Blanco;
            Mueble.Dimensiones dimensiones;

            dimensiones.Ancho_m = 20;
            dimensiones.Alto_m = 3;
            dimensiones.Profundo_m = 1;

            Mueble mueble = new Mueble(color, 13.5f, dimensiones , "IKEA", 20.4f);

            mueble.MostrarInformacion();
        }
    }
}
