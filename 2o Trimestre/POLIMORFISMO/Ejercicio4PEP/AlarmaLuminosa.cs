using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PEP
{
    class AlarmaLuminosa : Alarma
    {
        private Bombilla bombilla; 
        public AlarmaLuminosa(int umbral, Timbre timbre, Sensor sensor, Bombilla bombilla) 
                           : base(umbral, timbre, sensor)
        {
           this.bombilla = bombilla ;
        }

        public override void Activar()
        {
            base.Activar();
            bombilla.Encender();
        }

        public override void Desactivar()
        {
            base.Desactivar();
            bombilla.Apagar();
        }
    }
}
