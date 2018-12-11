using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Mueble
    {
        public enum Color
        {
            Rojo,
            Blanco,
            Verde,
            Azul
        };
        public struct Dimensiones
        {
            public float Ancho_m;
            public float Alto_m;
            public float Profundo_m;
        };

        private Color color;
        private Dimensiones dimensiones;
        private float peso;
        private string fabricante;
        private float precio;



        public Mueble(Color color,
                       float peso,
                       Dimensiones dimensiones,
                       string fabricante,
                       float precio)
        {
            this.color = color;
            this.peso = peso;
            this.dimensiones = dimensiones;
            this.fabricante = fabricante;
            this.precio = precio;
        }

     

        public float GetCalcularPrecioTransporte(float peso,
                                                Dimensiones dimensiones,
                                                string fabricante)
        {
            float precioTransporte = 0;

            if (fabricante=="IKEA")
            {
                precioTransporte = peso * (dimensiones.Alto_m + dimensiones.Ancho_m) - 10;
            }
            else
            {
                precioTransporte = peso * (dimensiones.Alto_m + dimensiones.Ancho_m);
            }
            return precioTransporte;

        }

        public  virtual void MostrarInformacion()
        {
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Dimensiones:\n \tAlto:{dimensiones.Alto_m}\n" +
                                             $"\tAncho:{dimensiones.Ancho_m}\n" +
                                             $"\tProfundo:{dimensiones.Profundo_m}");
            Console.WriteLine($"Fabricante: {fabricante}");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Precio del transporte: {GetCalcularPrecioTransporte(peso, dimensiones, fabricante)}");
        }
    }
}
