using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PEP
{
    class Cuenta
    {
        private string titular;
        private double saldo;
        NumeroCuenta numero;

        public Cuenta(string numero, string titular)
        {
            this.titular=titular;
            saldo = 0;
            this.numero = new NumeroCuenta(numero);
        }

        public virtual void Ingreso(double cantidad)
        {
            saldo += cantidad;
        }

        public virtual void Reintegro(double cantidad)
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

        public double GetSaldo()
        {
            return saldo;
        }


        public double Saldo
            {
            set
            {
                saldo = value;
            }
           protected get
            {
                return saldo;
            }
        }

        protected NumeroCuenta getNumero()
        {
            return numero;
        }

        private void setNumero(NumeroCuenta numero)
        {
            this.numero = numero;
        }

        public override string ToString()
        {
            return $"Numero de cuenta:{numero} \nTitular:{titular} \nSaldo:{saldo}";
        }
    }
}
