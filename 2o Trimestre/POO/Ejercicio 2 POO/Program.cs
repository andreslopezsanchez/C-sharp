using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /* Crear un programa que permita guardar información sobre pantallas 
     * gráficas de ordenador. La información relevante es: 
     * 
     * • Número de pulgadas. 
     * • Controlador gráfico. 
     * • Número de colores. 
     * • Pixels eje x. 
     * • Pixels eje y. 
     * 
     * Debe ser posible cambiar el número de colores, la resolución de 
     * la pantalla y el controlador en cualquier momento, así como consultar 
     * la información concerniente a una pantalla. Crear alguna instancia de 
     * pantalla y prueba el funcionamiento.*/

    class Program
    {
        static void Main(string[] args)
        {
            Pantalla pantalla = new Pantalla(3.2f, "funciona", 16, 4.1f, 1026);

            pantalla.MostrarInformacion();
        }
    }
}
