using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio3
{
    /* Cuando en un programa de consola pulsamos Control + C se produce un evento de cancelación 
     * y un programa finaliza. Además, esta combinación de teclas no es detectada por un Console.ReadKey(...) 
     * o un Console.ReadLine(), etc. 
     * 
     * Existe un evento especial de Consola llamado CancelKeyPress, al que podremos suscribirnos 
     * para detectar dicha pulsación. 
     * 
     *      • Vamos a crear un clase denominada ConsoleKeyLog que contendrá un lista de cadenas privada. 
     *        Donde cada cadena contendrá una pulsación de tecla. 
     *        
     *      • Además definirá un evento GestionTeclasPulsadasTrasFinalizar al que podremos suscribirnos y 
     *        que se generará cuando el usuario pulse Control + C para finalizar el programa. Dicho evento 
     *        pasará al suscriptor la lista de cadenas con las pulsaciones de tecla hasta que se pulso Control + C. 
     *        
     *      • Definiremos un método público denominado BucleLogConsola que se suscribirá al evento de cancelación 
     *        de la consola mencionado al principio y que irá leyendo pulsaciones de tecla en la consola y las 
     *        añadirá a la lista, a través del  siguiente método de utilidad.
     *        
     * Crea un programa principal que, a través de un objeto instanciado de ConsoleKeyLog leerá la teclas pulsadas 
     * del teclado mediante el método BucleLogConsola y además definirá un manejador para el evento 
     * GestionTeclasPulsadasTrasFinalizar que guarde en un fichero de texto denominado teclas.log la lista con las 
     * teclas pulsadas. (Una por línea). 
     */
     

    //tiempo 2º 15' 27''

    class ConsoleKeyLog
    {
        private List<string> pulsacionTecla = new List<string>();

        public delegate void ManejadorEvento(List<string> pulsacionTecla);
        public event ManejadorEvento GestionTeclasPulsadasTrasFinalizar;

        public void BucleLogConsola()
        {
            Console.CancelKeyPress += Console_CancelKeyPress;

            while (true)
            {
                ConsoleKeyInfo leer = Console.ReadKey();
                pulsacionTecla.Add(TextoTecla(leer.Modifiers, leer.Key));
            }        
     
        }

        private void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            GestionTeclasPulsadasTrasFinalizar.Invoke(pulsacionTecla);
        }

        static string TextoTecla(ConsoleModifiers m, ConsoleKey t)
        {
            string txt = "";
            if ((m & ConsoleModifiers.Alt) == ConsoleModifiers.Alt)
                txt += "Alt + ";
            if ((m & ConsoleModifiers.Control) == ConsoleModifiers.Control)
                txt += "Control + ";
            if ((m & ConsoleModifiers.Shift) == ConsoleModifiers.Shift)
                txt += "Shift + ";
            txt += t.ToString();

            return txt;
        }
    }

    class Program
    {
        static void Main()
        {
            ConsoleKeyLog ckl = new ConsoleKeyLog();

            ckl.GestionTeclasPulsadasTrasFinalizar += ImprimirEnFichero;

            ckl.BucleLogConsola();            
           
        }

        private static void ImprimirEnFichero(List<string> pulsacionTecla)
        {
            FileStream archivo = new FileStream(@"C:\pruebas1\teclas.log", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter adaptadorEscribir = new StreamWriter(archivo, Encoding.UTF8);

            for (int i = 0; i < pulsacionTecla.Count; i++)
            {
                adaptadorEscribir.WriteLine(pulsacionTecla[i]);
            }
            adaptadorEscribir.Close();
        }
    }
}
