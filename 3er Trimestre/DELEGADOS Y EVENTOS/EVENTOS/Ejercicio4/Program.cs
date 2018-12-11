using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{

    /* Invéntate una situación similar a la del ejercicio 2 donde varios objetos suscriptores se suscriban 
     * a otro publicador, realizando una acción determinada cuando este último genere un evento. 
     * 
     * Por ejemplo, el disparo de un evento por parte de un sensor de calor en el núcleo de una central 
     * nuclear que ponga en marcha una turbina y genere una aviso en la consola del operador.*/

    /* Aplicacion que detecta si el usuario estas de paseo y comenzará el recorrido de paseo.
     * te dará ánimos para que llegues a tu objetivo marcado previamente y te avisará si has llegado al objetivo
     * */
    //TIEMPO: 50'
    class UsuarioApp
    {
        private string alias;
        private int objetivoPasos;
        private int pasosRecorridos;

        public UsuarioApp(string alias, int objetivoPasos)
        {
            this.alias = alias;            
            this.objetivoPasos = objetivoPasos;
            pasosRecorridos = 0;
        }

        public string Alias
        {
            get
            {
                return alias;
            }
        }
        public int PasosRecorridos
        {
            get
            {
                return pasosRecorridos;
            }

         
        }
        public int ObjetivoPasos
        {
            get
            {
                return objetivoPasos;
            }

           
        }
     
        public void IncrementaPasos()
        {
            pasosRecorridos++;
        }    
    }

    class Aplicacion
    {
        public delegate void MensajeAEnviar(UsuarioApp usuario);
        public event MensajeAEnviar GestionarPaseo;

       public void detectarPaseo(UsuarioApp usuario)
	    {          
                GestionarPaseo.Invoke(usuario);    
        }
    }

    class EnviarAvisoEmpezar
    {
        public void EmpezarPaseo(UsuarioApp usuario)
        {
            if (usuario.PasosRecorridos == 5)
            {
                Console.WriteLine("Hemos detectado actividad...");
                Console.WriteLine("Activamos paseo en...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("3");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("2");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("1");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("¡YA!");
            }

        }
    }
    class EnviarRecorridoTotal
    {
        public void MostrarRecorrido(UsuarioApp usuario)
        {
            if (usuario.PasosRecorridos == usuario.ObjetivoPasos)
            {
                Console.WriteLine($"Enhorabuena \"{usuario.Alias}\" Has conseguido tu meta diaría " +
                    $"de {usuario.ObjetivoPasos} pasos. ");

            }

        }
    }
    class EnviarAnimos
    {
        public void DarAnimos(UsuarioApp usuario)
        {
            if (usuario.PasosRecorridos == 15)
            {
                Console.Write("¡Ánimo! Lo estas consiguiendo");

            }

        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            UsuarioApp andres = new UsuarioApp("La_liebre24", 20);
            Aplicacion healthyApp = new Aplicacion();
            EnviarAvisoEmpezar avisoStart = new EnviarAvisoEmpezar();
            EnviarAnimos animos = new EnviarAnimos();
            EnviarRecorridoTotal recTotal = new EnviarRecorridoTotal();

           
           
            healthyApp.GestionarPaseo += avisoStart.EmpezarPaseo;
            healthyApp.GestionarPaseo += animos.DarAnimos;
            healthyApp.GestionarPaseo += recTotal.MostrarRecorrido;

            Console.Write("|");

            for (int i = 0; i < 29; i++)
            {
                healthyApp.detectarPaseo(andres);
                andres.IncrementaPasos();
                System.Threading.Thread.Sleep(500);
                Console.Write("_");
                System.Threading.Thread.Sleep(500);
                Console.Write("-");
            }
            Console.Write("|");
        }
    }
}
