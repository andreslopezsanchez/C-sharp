using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejercicio5Ex
{
    class NumeroCuenta
    {
        private string entidad;
        private string sucursal;
        private string dcEntSuc;
        private string dcNumero;
        private string cuenta;

        public NumeroCuenta(string numero)
        {
            string entidad, sucursal, dcEntSuc, dcNumero, cuenta;

            if (formatoCorrrecto(numero, out entidad, out sucursal,
                                 out dcEntSuc, out dcNumero, out cuenta))
            {
                this.entidad = entidad;
                this.sucursal = sucursal;
                this.cuenta = cuenta;
                this.dcEntSuc = dcEntSuc;
                this.dcNumero = dcNumero;
            }

            bool esValido=true;
            if (esValido)
            {
                int[] pesosEntSuc = new int[] { 4, 8, 5, 10, 9, 7, 3, 6 };
                esValido = dcCorrecto(int.Parse(dcEntSuc), entidad + sucursal, pesosEntSuc);
            }
            else
                throw new FormatoCorrecto("DC Entidad-Sucursal incorrecto");
            
            if (esValido)
            {
                int[] pesosCuenta = new int[] { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
                esValido = dcCorrecto(int.Parse(dcNumero), cuenta, pesosCuenta);
            }
            else
                throw new FormatoCorrecto("DC Cuenta incorrecto");

                     
        }

        private bool formatoCorrrecto(string numero, out string entidad, out string sucursal,
                                       out string dcEntSuc, out string dcNumero, out string cuenta )
        {
            string patronCuenta = @"^(?<Entidad>\d{4})[\s-](?<Sucursal>\d{4})[\s-](?<DC1>\d)(?<DC2>\d)[\s-](?<Cuenta>\d{10})$";

            Regex patron = new Regex(patronCuenta);
            Match coincidencia = patron.Match(numero);
            entidad = coincidencia.Groups["Entidad"].Value;
            sucursal = coincidencia.Groups["Sucursal"].Value;
            dcEntSuc = coincidencia.Groups["DC1"].Value;
            dcNumero = coincidencia.Groups["DC2"].Value;
            cuenta = coincidencia.Groups["Cuenta"].Value;
            return true;
        }



        private bool dcCorrecto(int dc, string digitos, int[] peso)
        {

            
            int suma=0;
        
            for (int i = 0; i < digitos.Length; i++)
            {
                suma += (int)char.GetNumericValue(digitos[i]) * peso[i];
            }
            int resultado = 11 - suma % 11;

            if (resultado == 10)
            {
                resultado = 1;
            }
            if(resultado ==11)
            {
                resultado = 0;

            }


            if (resultado==dc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{entidad} {sucursal} {dcEntSuc}{dcNumero} {cuenta}";
        }
    }
}
