using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_B4_C
{/*  Crea una clase llamada DatosContacto con los siguientes campos:
        • El DNI de la persona (string)
        • El nombre completo de la persona (string)
        • La dirección completa de la persona (string)
        • Telefono (string)
*/
    class DatosContacto
    {
        private string dni;
        private string nombreCompleto;
        private string direccion;
        private string telefono;

        public string Dni//mirar si uso el get y el set y el que no lo borro
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public DatosContacto(string dni, string nombreCompleto, string direccion, string telefono)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return $"DNI:{dni}\nNombre Completo:{nombreCompleto}\n" +
                   $"Direccion:{direccion}\nTelefono{telefono}\n\n";
        }
    }
}
