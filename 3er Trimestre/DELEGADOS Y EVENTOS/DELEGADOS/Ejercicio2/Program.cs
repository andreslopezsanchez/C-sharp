using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /*• Crea un tipo delegado denominado Infinitivo para métodos que 
     *  no reciban, ni devuelvan nada. 
     *  
     *• Define ahora los métodos Ser, Correr, Ver, Pensar, Comer los cuales 
     *  mostrarán por consola los infinitivos en inglés de dichos verbos. 
     *  
     *• Crea un programa principal donde se instancie un objeto del delegado definido y … 
     *      1. Le asociemos Ser, Correr y Ver y realicemos una llamada al delegado. 
     *      2. Desasocia ahora Ser y Ver y asocia Pensar y Comer y vuleve ha hacer una llamada
     */


    //RESPUESTA 2: No te lo vincula con el objeto delegado.
    //TIEMPO: 7' 10''    

    class Program
    {
        public delegate void Infinitivo();

        //Prueba para desasociar
        //static int Ser() 
        //{
        //    Console.WriteLine("Be");
        //    return 3;
        //}
        static void Ser()
        {
            Console.WriteLine("Be");
         
        }
        static void Correr()
        {
            Console.WriteLine("Run");
        }
        static void Ver()
        {
            Console.WriteLine("See");
        }
        static void Pensar()
        {
            Console.WriteLine("Think");
        }
        static void Comer()
        {
            Console.WriteLine("Eat");
        }

        static void Traduccion(Infinitivo verbo)
        {
            verbo();
        }

        static void Main(string[] args)
        {
            Traduccion(Ser);
        }
    }
}
