using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PEP
{
    class CuentaDeposito : CuentaAhorro
    {
        private double recargo_tpu;
        private bool vencimiento;

        public CuentaDeposito(string numero, string titular, double interes_tpu, double recargo_tpu) 
                       : base(numero, titular, interes_tpu)
        {
            this.recargo_tpu = recargo_tpu;
            //this.vencimiento = vencimiento;
        }

   

      

        private double _recargo_tpu
        {            
            get
            {
                return recargo_tpu;
            }
        }

        public bool Vencimiento
        {
            set
            {
                vencimiento = value;
            }
            get
            {
                return vencimiento;
            }
        }


        public override void Reintegro(double cantidad)
        {
            if (!Vencimiento)
                cantidad = cantidad - (cantidad * _recargo_tpu);

            if ((Saldo-cantidad) < 0)
            {
                throw new SaldoInsuficienteException(
                    $"Saldo {Saldo:G} insuficiente para reintegro de {cantidad:G}e"
                    + $"\nEn cuenta{getNumero().ToString()}");
            }
            else
                Saldo = Saldo - cantidad;
        }



        public override string ToString()
        {
            return "Cuenta Depósito:\n" + base.ToString();
        }
    }
}
