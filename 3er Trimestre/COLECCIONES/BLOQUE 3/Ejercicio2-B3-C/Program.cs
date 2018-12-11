using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_B3_C
/*
        • Crea una clase Automóvil, con los datos básicos de los automóviles (marca,
        modelo, cilindrada, año de fabricación, etc) y los métodos necesarios para poder
        usarla posteriormente con comodidad.
        
        • Crea una clase program con una serie de métodos que nos permitan trabajar con
        una lista genérica de automóviles.
        
        • Necesitaremos un Método AñadirAutomovil que a partir de una lista y un automóvil,
        añadirá este a la lista.
        
        • EliminarAutomovil que eliminará el automóvil con el índice X que se haya pasado
        como argumento.
        
        • Crea un método que te permita encontrar en la lista, los coches con fecha de
        fabricación 2020, y el último coche de la lista que sea de color rojo y con fecha
        2020. 
*/
{
    class Automovil
    {
        public enum Colores { rojo, blanco, azul, verde, negro, gris};

        private string marca;
        private string modelo;
        private string cilindrada;
        private int añoFabricacion;
        private Colores color;
        
        public int AñoFabricacion
        {
            get
            {
                return añoFabricacion;
            }

            set
            {
                añoFabricacion = value;
            }
        }
        internal Colores Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Automovil(string marca, string modelo, string cilindrada, int añoFabricacion, string color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.añoFabricacion = añoFabricacion;
            if (Enum.IsDefined(typeof(Colores), color))
            {
                this.color =(Colores) Enum.Parse(typeof(Colores), color);
            }
            else
                throw new Exception("El color no corresponde con nuestros colores establecidos");
        }

        public override string ToString()
        {
            return $"{marca} - {modelo} - {cilindrada} - {añoFabricacion} - {color}";
        }


    }

    class Program
    {
        public static void AñadirAutomovil(List<Automovil> listaAutomoviles, Automovil automovil)
        {
            listaAutomoviles.Add(automovil);
        }
        public static void EliminarAutomovil(List<Automovil> listaAutomoviles, int posicion)
        {
            listaAutomoviles.Remove(listaAutomoviles[posicion - 1]);
        }
        public static void EncontrarAutomovil(List<Automovil> listaAutomoviles,int añofabricacion)
        {
            int encontrados = 0;
            for (int i = 0; i < listaAutomoviles.Count; i++)
            {
                if (listaAutomoviles[i].AñoFabricacion == añofabricacion)
                {
                    Console.WriteLine(listaAutomoviles[i]);
                    encontrados++;
                }

            }
            if (encontrados==0)
            {
                Console.WriteLine($"No hemos encontrado ningun vehiculo del {añofabricacion}");
            }

        }
        public static void EncontrarAutomovil(List<Automovil> listaAutomoviles,int añoFabricacion, string color)
        {
            int encontrado = 0;
            for (int i = 0; i < listaAutomoviles.Count; i++)
            {
                if (listaAutomoviles[i].AñoFabricacion == añoFabricacion && 
                    listaAutomoviles[i].Color == (Automovil.Colores) Enum.Parse(typeof(Automovil.Colores),color))
                {
                    Console.WriteLine(listaAutomoviles[i]);
                    encontrado++;
                }
            }
            if (encontrado==0)
            {
                Console.WriteLine("No se ha encontrado ningun coche con esas caracteristicas");
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                List<Automovil> listaAutomoviles = new List<Automovil>();

                Automovil coche1 = new Automovil("Seat", "Ibiza", "50cv", 2012, "rojo");
                Automovil coche2 = new Automovil("Ford", "Mustang", "90cv", 2020, "negro");
                Automovil coche3 = new Automovil("Citroen", "Picasso", "60cv", 2007, "rojo");

                AñadirAutomovil(listaAutomoviles, coche1);
                AñadirAutomovil(listaAutomoviles, coche2);
                AñadirAutomovil(listaAutomoviles, coche3);

                EncontrarAutomovil(listaAutomoviles, 2020);

                EncontrarAutomovil(listaAutomoviles, 2020, "rojo");

                EliminarAutomovil(listaAutomoviles, 2);

                foreach (Automovil coche in listaAutomoviles)
                {
                    Console.WriteLine(coche);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
