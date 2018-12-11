using System;
using System.Diagnostics;

namespace Ejercicio1
{
    public  class Escritor
    {
        private string nombre;
        private string alias;
        private DateTime nacimiento;
        private DateTime muerte;

        public Escritor()
           
        {
            nombre = "";
            alias = "";
            nacimiento = new DateTime();
            muerte = new DateTime();
        }
        public Escritor(string nombre,
                        string alias,
                        DateTime nacimiento, 
                        DateTime muerte)
        {
            this.nombre = nombre;
            this.nacimiento = nacimiento;
            this.muerte = muerte;
           
        }
        public Escritor(Escritor escritor)
        {
            nombre = escritor.nombre;
            nacimiento = escritor.nacimiento;
            muerte = escritor.muerte;
        }


        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetAlias()
        {
            return alias;
        }
        public void SetAlias(string alias)
        {
            this.alias = alias;
        }
        public DateTime GetNacimiento()
        {
            return nacimiento;
        }
        public void SetNacimiento(DateTime nacimiento)
        {
            this.nacimiento = nacimiento;
        }
        public DateTime GetMuerte()
        {
            return muerte;
        }
        public void SetMuerte(DateTime muerte)
        {
            this.muerte = muerte;
        }

       public ushort GetAñosFallecidos(DateTime muerte)
        {
            ushort añosFallecidos = (ushort)(DateTime.Today.Year - muerte.Year);
            return añosFallecidos;
        }
    }
}
