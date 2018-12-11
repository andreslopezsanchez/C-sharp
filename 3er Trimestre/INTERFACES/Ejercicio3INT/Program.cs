using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio3INT
{
    /* • Tendremos una clase Estudios que implementará los interfaces IEstudios e IVisualiza. 
     * 
     * • La interfaz IEstudios deberá asegurarse de que las clases implementen un método que diga 
     *   por pantalla la edad mínima para terminar esos estudios.  • La interfaz IVisualiza deberá 
     *   asegurarse de que las clases implementen un método,que presente por pantalla información. 
     *   (Nota: En nuetro caso relativa a los estudios). 
     *   
     * • La clase Estudios no podrá ser instanciada y derivarán de ella las clases Superior, Medio y Elemental. 
     *          ◦ Los estudios superiores, medios y elementales, tendrán como edades de acceso 
     *            18, 16 y 12 años respectivamente. 
     *            
     *          ◦ Para todos los estudios nos interesará ver en pantalla su nombre y duración. 
     *          
     *          ◦ Para los estudios superiores nos interesará el lugar donde se realizan. 
     *          
     *          ◦ Para los Medios nos interesa ver por pantalla el nombre de un estudio superior al que den acceso. 
     *          
     * • Crear al menos un objeto de cada una de las clases y comprobar su funcionamiento. 
     * 
     * • Comprueba si a las clases derivadas de Estudios son a su vez derivadas de IEstudios e Ipresentable.*/
    class Program
    {
        static void MostrarEdadMinima(IEstudios estudio)
        {
            estudio.EdadMinima();
        }

        static void Visualiza(IVisualiza infoestudio)
        {
            infoestudio.Visualiza();
        }


        static void Main(string[] args)
        {
            Estudios e1 = new Elemental("tecnologia", 12);
            
            Visualiza(e1);
            MostrarEdadMinima(e1);


            Estudios e2 = new Medio("Mecánico", 12, null);
            Visualiza(e2);
            MostrarEdadMinima(e2);

            Estudios e3 = new Superior("Biologo", 15, "Alicante");
            
            Visualiza(e3);
            MostrarEdadMinima(e3);

            Estudios e4 = new Medio("ciencias ambientales", 12, (Superior)e3);
            Visualiza(e4);
            MostrarEdadMinima(e4);
        }
    }
}
