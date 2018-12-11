using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4IN
{
    /*Por otra parte, tienes que tener presente que en una misma factura puede
         * haber una o varias líneas de detalle.
         * 
         La clase factura, además, debe ofrecer propiedades que devuelvan la base imponible, 
         *   la cuota de IVA y el total a pagar. 
         */
    class Factura
    {
        private string nombreCliente;
        private int telefono;
        private string direccion;
        private string poblacion;
        private string provincia;
        private int codigoPostal;
        private string nifCif;
        private int porcentajeIVA;
        private Detalle[] lineasDeDetalle;

        public int PorcentajeIVA
        {
            get
            {
                return porcentajeIVA;
            }

            set
            {
                porcentajeIVA = value;
            }
        }

        public Factura(string nombreCliente, int telefono, 
                            string direccion, string poblacion, 
                            string provincia, int codigoPostal, 
                            string nifCif, int porcentajeIVA, Detalle detalle)
        {
            this.nombreCliente = nombreCliente;
            this.telefono = telefono;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.codigoPostal = codigoPostal;
            this.nifCif = nifCif;
            this.porcentajeIVA = porcentajeIVA;
            this.lineasDeDetalle = new Detalle[] { detalle };
        }

        public Detalle this[int d]
        {
            get
            {
                return lineasDeDetalle[d];
            }
            set
            {
                lineasDeDetalle[d] = value;
            }
        }
        public double BaseImponible()
        {
            double suma = 0;
            for (int i = 0; i < lineasDeDetalle.Length; i++)
            {
                suma += lineasDeDetalle[i].Importe;
            }
            return suma;
        }
        public double TotalAPagar()
        {
            double total = BaseImponible() + (BaseImponible()*(double)PorcentajeIVA);

            return total;
        }

        public static Factura operator +(Factura f, Detalle d)
        {
            Array.Resize(ref f.lineasDeDetalle, f.lineasDeDetalle.Length + 1);
            f.lineasDeDetalle[f.lineasDeDetalle.Length -1] = d;
            return f;
        }
    }
}
