using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4IN
{
    /*• Datos línea de detalle: Cantidad, descripción, precio unitario e importe.
     * 
     *  Usa un indizador para acceder a cada una de estas líneas de detalle. */
    class Detalle
    {
        private int cantidad;
        private string descripcion;
        private double precioUnitario;
        private double importe;

        public double Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public double PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }

            set
            {
                precioUnitario = value;
            }
        }

        public Detalle(int cantidad, string descripcion, double precioUnitario, double importe)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.importe = importe;
        }

        
    }
}
