using System;

namespace AmpliacionCondicionales
{
    class AmpliacionCondicionales
    {

        #region Ejercicio1
        /*Prepara un programa que lea el importe de la venta y la cantidad entregada por el comprador y 
         * calcule los billetes de 100, 50 , 20, 10 , 5 y las monedas de 2 y 1 euros y las de  50, 20, 10,  
         * 5, 2 y 1 céntimos que se necesitan para efectuar la devolución*/
        class Ejercicio1

        {
            /* static void Main()
             {
                double importeVenta, cantidadEntregada, devolucion;
                double billete100=0, billete50=0, billete20=0, billete10=0, billete5 = 0;
                double moneda2=0, moneda1=0, moneda05=0, moneda02=0, moneda01=0, moneda005=0;
                double moneda002=0, moneda001=0;

                Console.Write("Dime cuanto  te cuestan los tomates: ");
                importeVenta = double.Parse(Console.ReadLine());

                Console.Write("Dime cuanto le entregas: ");
                cantidadEntregada  = double.Parse(Console.ReadLine());


                devolucion = cantidadEntregada - importeVenta;
                Console.WriteLine($"te devolveran {devolucion} de la siguiente manera:"); 
                if(devolucion>=100)
                {
                     billete100 = Math.Floor(devolucion / 100);
                     devolucion = devolucion%100;

                }


                 if (devolucion>=50)
                {
                     billete50 = Math.Floor(devolucion / 50);
                     devolucion = devolucion%50;
                }

                 if (devolucion >= 20)
                 {
                     billete20 = Math.Round(devolucion / 20);
                     devolucion = devolucion%20;
                 }
                 if (devolucion >= 10)
                 {
                     billete10 = Math.Round(devolucion / 10);
                     devolucion = devolucion%10;
                 }
                 if (devolucion >= 5)
                 {
                     billete5 = Math.Round(devolucion / 5);
                     devolucion = devolucion%5;
                 }
                 if (devolucion >= 2)
                 {
                     moneda2 = Math.Round(devolucion / 2);
                     devolucion = devolucion%2;
                 }
                 if (devolucion >= 1)
                 {
                     moneda1 = Math.Round(devolucion / 1);
                     devolucion = devolucion%1;
                 }
                 if (devolucion >= 0.5)
                 {
                     moneda05 = Math.Round(devolucion / 0.5);
                     devolucion = devolucion%0.5;
                 }
                 if (devolucion >= 0.2)
                 {
                     moneda02 = Math.Round(devolucion / 0.2);
                     devolucion = devolucion%0.2;
                 }
                 if (devolucion >= 0.1)
                 {
                     moneda01 = Math.Round(devolucion / 0.1);
                     devolucion = devolucion%01;
                 }
                 if (devolucion >= 0.05)
                 {
                     moneda005 = Math.Round(devolucion / 0.05);
                     devolucion = devolucion%0.05;
                 }
                 if (devolucion >= 0.02)
                 {
                     moneda005 = Math.Round(devolucion / 0.02);
                     devolucion = devolucion%0.02;
                 }
                 if (devolucion >= 0.01)
                 {
                     moneda005 = Math.Round(devolucion / 0.01);
                     devolucion = devolucion%0.01;
                 }

                 Console.WriteLine($" se te devolvera en: \n100:{billete100} \n50:{billete50} \n20:{billete20}" +
                                  $"\n10:{billete10} \n5:{billete5} \n2:{moneda2} \n1:{moneda1} \n0.5:{moneda05}" +
                                  $"\n0.2:{moneda02} \n0.1:{moneda01} \n0.05:{moneda005} \n0.02:{moneda002} \n0.01:{moneda001}");
             }*/
        }

        #endregion

        #region Ejercicio2
        /*Una empresa factura a sus clientes el último día de cada mes. Si el cliente paga del 1 al 10 del mes 
         * siguiente se le hace un descuento de 50 centimos o del 10%, el que sea mayor; si paga entre los días 11
         *  y 20 no se le aplica ningún descuento, y si paga después del día 20 se le penaliza con 1 euro o el 5%, 
         * lo que sea mayor. Se desea un programa que lea los datos del cliente: nombre, dirección y CIF y el importe de la
         *  factura y confeccione una carta dirigida al cliente informándole que  tiene una factura pendiente de ... euros y 
         * lo que deberá pagar según realice el pago del 1 al 10, del 11 al 20 o después del 20 */
        class Ejercicio2

        {
            /* static void Main()
              {
                 float importe1al10=0, importe11al20=0, importeDespues20=0;

               Console.Write("Dime tu nombre: ");
               string  nombre = Console.ReadLine();

               Console.Write("Dime tu direccion: ");
               string direccion = Console.ReadLine();

               Console.Write("Dime tu CIF: ");
               string cif =Console.ReadLine(); 

               Console.Write("Dime el importe de la factura: ");
               float importeFactura =float.Parse(Console.ReadLine());

               if((importeFactura*0.1)>0.5)
                     importe1al10= importeFactura-(importeFactura*0.1f);
              importe1al10= importeFactura-0.50f;

              importe11al20=importeFactura;

              if((importeFactura*0.05)>1)
                 importeDespues20= importeFactura + (importeFactura*0.05f);
             importeDespues20= importeFactura + 1;


               Console.WriteLine($"\nNombre:{nombre} \nDirección: {direccion} \nCIF: {cif} \nTiene una factura pendiente"+ 
               $" de {importeFactura} euros. \nDeberá pagar un importe u otro según la fecha en que realice el pago:"+
               $" \nDel 1 al 10: {importe1al10} \nDel 11 al 20: {importe11al20}  \nDespués del 20: {importeDespues20}");
              }*/
        }

        #endregion

        #region Ejercicio3
        /*Una editorial calcula el precio de coste de un libro del siguiente modo. El coste por página es de 5 cent.
         *  con un mínimo de 3€. El coste de encuadernación depende del número de páginas siendo de 4€ si tiene menos de 
         * 200 páginas, de 5€ si tiene entre 200 y 500 páginas y de 8€ si tiene más de 500 páginas. Cuando el número de 
         * páginas es superior a 800 el libro se publica en varios volúmenes de igual número de páginas no pudiendo exceder
         *  cada volumen de 500 páginas.  Realiza un programa que calcule el precio de un libro sabiendo el número de páginas. */
        class Ejercicio3

        {
            static void Main()
            {
                int numeroPaginas;
                int volumenes = 1;
                float costePagina = 0;
                float costeEncuadernacion = 0;
                int n;


                Console.Write("Dime de cuantas paginas es tu libro: ");
                numeroPaginas = int.Parse(Console.ReadLine());

                costePagina = 0.05f * numeroPaginas;

                if (costePagina < 3)
                    costePagina = 3;

                if (numeroPaginas < 200)
                {
                    costeEncuadernacion = 4;
                }
                else if (numeroPaginas >= 200 && numeroPaginas <= 500)
                {
                    costeEncuadernacion = 5;
                }
                else if (numeroPaginas > 500 && numeroPaginas < 800)
                {
                    costeEncuadernacion = 8;
                }
                else
                {
                    n = numeroPaginas / 2;
                    volumenes = numeroPaginas / (n);
                    if (n < 200)
                    {
                        costeEncuadernacion = 4 * 2;
                    }
                    else if (n >= 200 && n <= 500)
                    {
                        costeEncuadernacion = 5 * 2;
                    }
                    else
                    {
                        volumenes = numeroPaginas / (n / 2);
                        if (n < 200)
                        {
                            costeEncuadernacion = 4 * 3;
                        }
                        else if (n >= 200 && n <= 500)
                        {
                            costeEncuadernacion = 5 * 3;
                        }
                    }
                }
                Console.WriteLine($"Precio páginas: {costePagina} \nPrecio encuadernación: {costeEncuadernacion} \nVolúmenes:{volumenes}");
            }
        }

        #endregion

    }
}