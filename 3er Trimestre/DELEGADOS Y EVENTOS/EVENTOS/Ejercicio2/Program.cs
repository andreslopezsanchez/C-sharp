using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{

    //Tiempo: 26' 48''
    class Cajero
    {
        //private int numCajero; es necesario?

        public delegate void MensajeAEnviar(string dni, double cantidad, DateTime hora);
        public event MensajeAEnviar RetiradaDeEfectivo;

        public void RetirarEfectivo(string dni, double cantidad, DateTime hora)
        {
            Console.WriteLine("Realizando operación...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Operación realizada con éxito");
            RetiradaDeEfectivo.Invoke(dni, cantidad, hora);
        }
    }

    class EnvioMail
    {
        public void EnviarAvisoRetiradaDeEfectivo(string dni, double cantidad, DateTime hora)
        {
            Console.WriteLine($"Buscando datos usuario {dni}...");
            Console.WriteLine($"Enviando Mail al usuario {dni} de retirada de" +
                                $"{cantidad} euros el día {hora.Day} a las {hora.Hour}");
        }
    }
    class EnvioSMS
    {
        public void EnviarAvisoRetiradaDeEfectivo(string dni, double cantidad, DateTime hora)
        {
            Console.WriteLine($"Buscando datos usuario {dni}...");
            Console.WriteLine($"Enviando SMS al usuario {dni} de retirada de" +
                                $"{cantidad} euros el día {hora.Day} a las {hora.Hour}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero = new Cajero();
            EnvioMail envioMail = new EnvioMail();
            EnvioSMS envioSMS = new EnvioSMS();

            cajero.RetiradaDeEfectivo += envioMail.EnviarAvisoRetiradaDeEfectivo;
            cajero.RetiradaDeEfectivo += envioSMS.EnviarAvisoRetiradaDeEfectivo;
            Console.WriteLine("Bienvenido a caja Andres");
            cajero.RetirarEfectivo("48675755G", 20, new DateTime(2018, 4, 20, 20, 35, 20));

        }
    }
}
