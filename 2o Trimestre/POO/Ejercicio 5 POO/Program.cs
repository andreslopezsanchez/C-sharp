using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    /* 
     * Crea las clases silla, mesa y armario derivadas de la clase mueble del ejercicio número 3. 
     * Pero a cada una de ellas le deberás de añadir los campos y métodos necesarios que identifiquen a dichos elementos 
     * según el texto del ejercicio 3. Crea un método común para todos los muebles que nos permita calcular el precio del 
     * transporte según su peso, dimensiones y fabricante. Finalmente, haz un programa principal que nos cree instancias de 
     * los tres tipos de muebles, que llame a los métodos de las clases para mostrar la información 
     * y que llame al método para calcular el precio del transporte y lo muestre */
    class Program
    {
        static void Main(string[] args)
        {
         
            Mueble.Dimensiones dimensionesSilla;
            dimensionesSilla.Ancho_m = 20;
            dimensionesSilla.Alto_m = 3;
            dimensionesSilla.Profundo_m = 1;

            Mueble.Dimensiones dimensionesMesa;
            dimensionesMesa.Ancho_m = 10;
            dimensionesMesa.Alto_m = 30;
            dimensionesMesa.Profundo_m = 6;

            Mueble.Dimensiones dimensionesSofa;
            dimensionesSofa.Ancho_m = 20;
            dimensionesSofa.Alto_m = 3;
            dimensionesSofa.Profundo_m = 1;

          

            Silla silla = new Silla(Mueble.Color.Azul, 11f, dimensionesSilla, "IKEA", 15.7f, 0.2f);
            Mesa mesa = new Mesa(Mueble.Color.Rojo, 13f, dimensionesMesa, "bululu", 43f, Mesa.TipoMadera.Caoza);
            Sofa sofa = new Sofa(Mueble.Color.Rojo, 5f, dimensionesSofa, "IKEA", 33f, Sofa.TipoTela.Licra, false);


            silla.MostrarInformacion();
            mesa.MostrarInformacion();
            sofa.MostrarInformacion();
        }
    }
}
    