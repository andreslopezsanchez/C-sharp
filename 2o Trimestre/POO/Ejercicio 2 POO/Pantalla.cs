using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Pantalla
    {
        private float numeroPulgadas;
        private string controladorGrafico;
        private int numeroColores;
        private float pixelX;
        private float pixelY;

        public Pantalla()
        {
            numeroPulgadas = 0;
            controladorGrafico = "";
            numeroColores = 0;
            pixelX = 0;
            pixelY = 0;
        }
        public Pantalla(float numeroPulgadas, 
                        string controladorGrafico,
                        int numeroColores, 
                        float pixelX, 
                        float pixelY)
        {
            this.numeroPulgadas = numeroPulgadas;
            this.controladorGrafico = controladorGrafico;
            this.numeroColores = numeroColores;
            this.pixelX = pixelX;
            this.pixelY = pixelY;
        }
        public Pantalla(Pantalla pantalla)
        {
            pantalla.numeroPulgadas = numeroPulgadas;
            pantalla.controladorGrafico = controladorGrafico;
            pantalla.numeroColores = numeroColores;
            pantalla.pixelX = pixelX;
            pantalla.pixelY = pixelY;
        }


        public void SetNumeroPulgadas(float numeroPulgadas)
        {
            this.numeroPulgadas = numeroPulgadas;
        }
        public void SetControladorGrafico(string controladorGrafico)
        {
            this.controladorGrafico = controladorGrafico;
        }
        public void SetNumeroColores(int numeroColores)
        {
            this.numeroColores = numeroColores;
        }
        public void SetPixelX(float pixelX)
        {
            this.pixelX = pixelX;
        }
        public void SetPixelY(float pixelY)
        {
            this.pixelY = pixelY;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Numero de pulgadas: {numeroPulgadas}");
            Console.WriteLine($"Controlador gráfico: {controladorGrafico}");
            Console.WriteLine($"Numero de colores: {numeroColores}");
            Console.WriteLine($"Pixels eje X: {pixelX}");
            Console.WriteLine($"Pixels eje Y: {pixelY}");
        }
    }
}
