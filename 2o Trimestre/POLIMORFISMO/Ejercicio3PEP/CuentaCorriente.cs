using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PEP
{
    class CuentaCorriente : Cuenta 
    {
        private int maximoTrasaccionesGratuitasPorMes;
        private int numeroTrasaccionesMesActual;
        private double recargo;


        public CuentaCorriente(string numero, string titular, int maximoTrasaccionesGratuitasPorMes, double recargo)
            : base(numero, titular)
        {
            this.maximoTrasaccionesGratuitasPorMes = maximoTrasaccionesGratuitasPorMes;
            this.recargo = recargo;
            reinicaTransacciones();
        }

        private void reinicaTransacciones()
        {
            numeroTrasaccionesMesActual = 0;
        }


        public override void Ingreso(double cantidad)
        {
            Saldo += cantidad;
        }

        public override void Reintegro(double cantidad)
        {
            if ((Saldo - cantidad) < 0)
            {
                throw new SaldoInsuficienteException(
                    $"Saldo {Saldo:G} insuficiente para reintegro de {cantidad:G}e"
                    + $"\nEn cuenta{getNumero().ToString()}");
            }
            else
                Saldo = Saldo - cantidad;
        }

        public void AplicaRecargoMes()
        {
            if (numeroTrasaccionesMesActual > maximoTrasaccionesGratuitasPorMes)
                Saldo = Saldo - (numeroTrasaccionesMesActual - maximoTrasaccionesGratuitasPorMes) * recargo;
            reinicaTransacciones();
        }

        public override string ToString()
        {
            return "Cuenta corriente\n" + base.ToString();
        }
    }
}
