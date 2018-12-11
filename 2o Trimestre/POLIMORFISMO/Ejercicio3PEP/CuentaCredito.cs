using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PEP
{
    class CuentaCredito : Cuenta
    {
        private double interes_tpu;
        private double creditoMaximo_Euros;

        public class CreditoMaximoExcedidoException : Exception
        {
            public CreditoMaximoExcedidoException(string message) :
                                            base(message)
            {
                ;
            }
        }

        public CuentaCredito(string numero, string titular, double interes_tpu, double creditoMaximo_Euros) 
             : base(numero, titular)
        {
            this.interes_tpu = interes_tpu;
            this.creditoMaximo_Euros = creditoMaximo_Euros;
        }

        public override void Reintegro(double cantidad)
        {
            if (Math.Abs(Saldo - cantidad) > creditoMaximo_Euros)
            {
                throw new CreditoMaximoExcedidoException($"Tu crédito máximo es de {creditoMaximo_Euros:G} "+
                                                         $"del cual se te ha concedido ya...");
            }
            else if ((Saldo - cantidad) < 0)
            {
                throw new SaldoInsuficienteException(
                    $"Saldo {Saldo} insuficiente para reintegro de {cantidad}e"
                    + $" En cuenta{getNumero().ToString()}");
            }
            else
                Saldo = Saldo - cantidad;

        }

        public double CargoInteresesMes()
        {

            double cargo = (Saldo >= 0) ? 0 : Math.Abs(Saldo) * interes_tpu;
           
            Saldo -= cargo;
            return cargo;
        }

        public override string ToString()
        {
            return "Cuenta Crédito:\n" + base.ToString();
        }
    }
}
