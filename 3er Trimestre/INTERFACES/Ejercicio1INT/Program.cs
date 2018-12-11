using System;
using MisInterfaces;

namespace Ejercicio1INT
{

    /*Para entender mejor las Interfaces, te pongo un ejemplo 
     * sencillo. Fíjate, sobre todo, en el programa principal 
     * para comprender mejor su utilidad.
     * 
     * Crea una librería de interfaces llamada MisInterfaces a la 
     * que le irás añadiendo todas las interfaces que implementes 
     * en los ejercicios.Para poder usarla deberás incluirla en tus proyectos.*/

    class Triangulo : IVisualiza
    {
        private double @base;
        private double altura;
        public Triangulo(double base_, double altura)
        {
            @base = base_;
            this.altura = altura;
        }
        private double area
        {
            get
            {
                return @base * altura / 2;
            }
        }
        public void Visualiza()
        {
            Console.WriteLine($"Base del triángulo: {@base}");
            Console.WriteLine($"Altura del triángulo: {altura}");
            Console.WriteLine($"Área del triángulo: {area}");
        }
    }

    class Proveedor : IVisualiza
    {
        private string nombre;
        private string apellidos;
        public Proveedor(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        public void Visualiza()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellidos: {apellidos}");
        }
    }

    class Program
    {
        static void VerDatos(IVisualiza oVisualizable)
        {
            oVisualizable.Visualiza();
        }

        static void Main()
        {
            Triangulo t = new Triangulo(10, 5);
            VerDatos(t);
            Proveedor p = new Proveedor("Erik", "Su casa");
            VerDatos(p);
        }
    }
}
