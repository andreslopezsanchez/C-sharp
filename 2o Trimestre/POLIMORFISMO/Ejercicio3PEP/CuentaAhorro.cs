using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3PEP
{
    class CuentaAhorro : Cuenta
    {
        private double interes_tpu;

        public CuentaAhorro(string numero, string titular, double interes_tpu) : base(numero, titular)
        {
            this.interes_tpu = interes_tpu;
        }

        public  void SumaInteres()
        {
            
            Saldo = Saldo + (Saldo * interes_tpu);
        }

        public override string ToString()
        {
            return "Cuenta de ahorro:\n" + base.ToString();
        }
    }
}
