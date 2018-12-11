using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PEP
{
    class Alarma
    {
        private int umbral;
        private Timbre timbre;
        private Sensor sensor;

        public Alarma(int umbral, Timbre timbre, Sensor sensor)
        {
            this.umbral = umbral;
            this.timbre = timbre;
            this.sensor = sensor;
        }

        public void Comprobar()
        {
            if (umbral>sensor.ValorActual)
            {
                Activar();
            }
            else
            {
                Desactivar();
                Console.WriteLine("Todo en orden");
            }
        }

        public virtual void Activar()
        {
            Console.WriteLine("¡ALARMA ACTIVADA!");
            timbre.Activar();
        }
        public virtual void Desactivar()
        {
            Console.WriteLine("...alarma desactivada...");
            timbre.Desactivar();
        }
    }
}
