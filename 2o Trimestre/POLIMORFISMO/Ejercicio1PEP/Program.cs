using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PEP
{
    /*Para dar nuestros primeros pasos con el polimorfismo de datos, vamos a recordar el
    cálculo de factorial y de número primo. Vamos a necesitar una clase padre
    ElNoCalculador con los métodos virtuales Factorial() y Primo() que devolverán en ambos
    casos 0, y una clase hija ElCalculador que sí implementa estos métodos de forma
    correcta. Se deberá controlar las excepciones necesarias (desbordamiento, etc). Para
    probar el funcionamiento del polimorfismo nos crearemos un objeto de la manera:
    ElNoCalculador obj=new ElCalculador(num);
    Y llamaremos a los métodos correspondientes. ¿A qué métodos se llama, a los de la clase
    padre o a los de la clase hija?
    Crea en la clase hija un método MostrarResultado y llámalo con el obj. ¿Qué ocurre?
    Y si comentas el método Primo de la hija, ¿que ocurre?*/
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ElNoCalculador obj = new ElCalculador(6);
               obj.
                
            }
            catch(StackOverflowException)
            {

            } 
        }
    }
}
