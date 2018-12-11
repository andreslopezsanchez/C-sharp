using System;
using MisInterfaces;

namespace Ejercicio2INT
{
    /* A partir del siguiente UML crea las clases e Interfaces necesarias 
     * para implementar un editor de figuras geométricas. 
     * Crea además, un programa principal que te permita probarlo correctamente.*/
    class Circulo : IFigura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public float Area()
        {
          
                return (float)(2 * Math.PI * radio);
            
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujando círculo...");
        }

        public float Perimetro()
        {
            return (float)(Math.PI * Math.Pow(radio, 2));
        }
    }

    class Cuadrado : IFigura
    {
        private float lado;

        public Cuadrado(float lado)
        {
            this.lado = lado;
        }

        public float Area()
        {
            return lado * 2;
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujando cuadrado...");
        }

        public float Perimetro()
        {
            return lado * 4;
        }
    }

    class Rectangulo : IFigura
    {
        private float @base;
        private float altura;

        public Rectangulo(float @base, float altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public float Area()
        {
            return @base * altura;
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujando Rectángulo...");
        }

        public float Perimetro()
        {
            return (@base * 2) + (altura * 2);
        }
    }

    class Program
    {
       static void MostrarAreas(IFigura mArea)
        {
            Console.WriteLine($"Area:{mArea.Area()}");

        }

        static void Dibujar(IFigura dibuja)
        {
            dibuja.Dibujar();
        }

       static void MostrarPerimetro(IFigura mPerimetro)
        {
            Console.WriteLine($"Perimetro:{mPerimetro.Perimetro()}");

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangulo");
            Rectangulo re = new Rectangulo(3, 2);
            MostrarAreas(re);
            MostrarPerimetro(re);
            Dibujar(re);
            
            Console.WriteLine("Circulo");
            Circulo ci = new Circulo(4.21f);
            MostrarAreas(ci);
            MostrarPerimetro(ci);
            Dibujar(ci);

            Console.WriteLine("Cuadrado");
            Cuadrado cu = new Cuadrado(5.7f);
            MostrarAreas(cu);
            MostrarPerimetro(cu);
            Dibujar(cu);

        }
    }
}
