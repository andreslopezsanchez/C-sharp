using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Ex
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
