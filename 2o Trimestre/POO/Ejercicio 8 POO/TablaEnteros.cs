using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
     /* 
    .  Además, TablaEnterps dispondrá de un método redefinible MostrarTabla para 
     * mostrar la tabla completa por pantalla y decir cuántos elementos tiene y otro SumaPropia que se encargará de comprobar 
     * si existen más números positivos o negativos en la tabla y mostrar la suma de aquellos de los que hay mayor cantidad.*/

    public abstract class TablaEnteros
    {
        private int[] tablaEnteros;


        public TablaEnteros(int[] tablaEnteros)
        {
            this.tablaEnteros = tablaEnteros;
            
        }

        protected abstract int[] GuardarNumerosEnTabla(int[] tablaEnteros);

        public int SumaPropia(int[] tablaEnteros)
        {
            int suma=0;

            for (int i = 0; i < tablaEnteros.Length; i++)
            {
                suma = suma + tablaEnteros[i];
            }
            return suma;
        }

        public virtual void MostrarTabla(int[] tablaEnteros)
        {

            Console.WriteLine($"Elementos en la tabla: {tablaEnteros.Length}");
           
        }


    }
}
