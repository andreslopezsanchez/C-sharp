using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_B4_C
/*
    Crea una clase llamada DatosContacto con los siguientes campos:
        • El DNI de la persona (string)
        • El nombre completo de la persona (string)
        • La dirección completa de la persona (string)
        • Telefono (string)

En la clase del programa principal:
        • Crea un diccionario llamdo AgendaContactos con una clave de tipo string y el
        valor de la clase DatosContacto.
        
        • Añade un método estático CreaContactos que devuelva el diccionario rellenado
        por el usuario, hasta que se introduzca un DNI vacio.
        Nota: Como clave para cada contacto utiliza su DNI.
        
        • Añade el método estático BorraContacto que reciba como parámetros un DNI
        (como cadena) y el diccionario. Borrará deel mismo, el dato cuya clave coincida
        con el DNI que se le pasa.
        
        • Añade un método estático AñadeContacto que reciba como parámetro un dato de
        tipo DatosContacto, y el diccionario con la agenda de contactos, y añada a la tabla
        la persona indicada.
        
        • Crea MuestraAgenda que reciba como parámetro el diccionario y muestre su
        contenido.
        
        • Crea un programa principal que te permita probar todos los métodos.*/
{
    //tiempo en tardar en hacerlo 32' 28'' 
    class Program
    {
        public static void CreaContactos(Dictionary<string,DatosContacto> AgendaContactos)
        {
            string dni="", nombre, direccion, telefono;
            do
            {
                Console.WriteLine("¡NUEVO CONTACTO!");
                Console.Write("Dime su DNI: ");
                dni = Console.ReadLine();
                if (dni == "")
                    break;

                if (!AgendaContactos.ContainsKey(dni))
                {
                    Console.Write("Dime su nombre: ");
                    nombre = Console.ReadLine();

                    Console.Write("Dime su direccion: ");
                    direccion = Console.ReadLine();

                    Console.Write("Dime su telefono: ");
                    telefono = Console.ReadLine();

                    AgendaContactos.Add(dni, new DatosContacto(dni, nombre, direccion, telefono));
                }
                else
                    Console.WriteLine("Ya hemos apuntado a ese contacto!");
                Console.Clear();               
            } while (dni != "");
        }
        public static void BorraContacto(string dni, Dictionary<string, DatosContacto> AgendaContactos)
        {
            if (AgendaContactos.ContainsKey(dni))
            {
                Console.WriteLine("Borrando...");
                AgendaContactos.Remove(dni);
            }
            else
                Console.WriteLine("Lo siento pero no esta ese contacto");
        }
        public static void AñadeContacto(DatosContacto contacto, Dictionary<string, DatosContacto> AgendaContactos)
        {
            
            if (!AgendaContactos.ContainsKey(contacto.Dni))
            {
                Console.WriteLine("Añadiendo Contacto...");
                AgendaContactos.Add(contacto.Dni, contacto);
            }
            else
                Console.WriteLine("Ya esta introducido este usuario");
        }
        public static void MuestraAgenda(Dictionary<string, DatosContacto> AgendaContactos)
        {
            foreach (var contacto in AgendaContactos)
            {
                Console.WriteLine(contacto.Value);
            }
        }


        static void Main(string[] args)
        {
            Dictionary<string, DatosContacto> AgendaContactos = new Dictionary<string, DatosContacto>();

            CreaContactos(AgendaContactos);
            BorraContacto("123", AgendaContactos);
            BorraContacto("123", AgendaContactos);
            AñadeContacto(new DatosContacto("321", "Felipe", "Madrid", "654123987"), AgendaContactos);
            AñadeContacto(new DatosContacto("321", "Felipe", "Madrid", "654123987"), AgendaContactos);
            MuestraAgenda(AgendaContactos);
        }
    }
}
