using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2RO
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

        public static bool operator ==(Cuenta c1, Cuenta c2)
        {
            return c1.numero == c2.numero && c1.titular == c2.titular && c1.saldo == c2.saldo;
        }

        public static bool operator!=(Cuenta c1, Cuenta c2)
        {
            return !(c1 == c2);
        }

        public void Ingreso(double cantidad)
        {
            saldo += cantidad;
        }

        public void Reintegro(double cantidad)
        {
           
                saldo -= cantidad;
            if (saldo < 0)
                throw new SaldoInsuficienteException("Saldo insuficiente");
           
        }

        public override string ToString()
        {
            return $"Titular:{titular} \n\nNumero de cuenta:\n{numero} \n\nSaldo:{saldo}";
        }
    }
}
