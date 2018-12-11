using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PEP
{
    /* Crea una clase denominada Alarma cuyos objetos activen un objeto de tipo 
     * Timbre cuando el valor medido por un Sensor supere un umbral preestablecido. 
     * Implementa en C# todo el código necesario para el funcionamiento de la alarma,
     * suponiendo que la alarma comprueba si debe activar o desactivar el timbre 
     * cuando se invoca el método comprobar(). Crea una subclase de Alarma denominada 
     * AlarmaLuminosa que, además de activar el timbre, encienda una luz 
     * (que representaremos con un objeto de tipo Bombilla). 
     * El siguiente UML te puede ayudar a entender lo que se pide.*/
    class Program
    {
        static void Main(string[] args)
        {
            Alarma alarma = new AlarmaLuminosa(50, new Timbre(20), new Sensor(40), new Bombilla());

            alarma.Comprobar();
        }
    }
}
