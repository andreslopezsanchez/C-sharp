using System;

namespace EjerciciosCondicionalesP2
{
    class EjerciciosCondicionalesP2
    {

        #region Ejercicio1
        /*Se pide una cantidad y un precio por teclado, si la cantidad es mayor o igual a 1000 
         * unidades se le aplica un 12% de IVA, si la cantidad es menor de 1000 se le aplica un 15% de IVA.*/
        class Ejercicio1

        {
            /* static void Main()
             {
                float cantidad, precio, iva=0;
              

                Console.Write("Dime cuantos tomates compras: ");
                cantidad = float.Parse(Console.ReadLine());

                Console.Write("Dime a cuanto te sale: ");
                precio = float.Parse(Console.ReadLine());

                if(cantidad>=1000)
                {
                    iva =  0.12f;
                }
                else
                {
					iva = 0.15f;
				}
				  
				float precioConIva= cantidad*(precio + (precio*iva));
				
				Console.WriteLine($"Se te aplicara un {iva*100}% de iva y te saldra por un total de {precioConIva}");
             }*/
        }

        #endregion

        #region Ejercicio2
        /*Se pide una nota. Si la nota es menor que 5 se visualizará el texto SUSPENSO,
         *  si la nota está entre 5 y 6 (sin incluirlo) se visualizará el texto APROBADO, 
         *  si la nota está entre 6 y 7 (sin incluirlo) se visualizará el texto BIEN, si la 
         *  nota está entre 7 y 9 (sin incluirlo) se visualizará el texto NOTABLE, en otro caso
         *   visualizará el texto SOBRESALIENTE. */
        class Ejercicio2

        {
          /* static void Main()
           {
				float nota;
				string mensaje;

                Console.Write("Dime cuanto has sacado en el examen: ");
                nota = float.Parse(Console.ReadLine());

                if (nota<=5)
					mensaje= "Suspenso";
				else if(nota>5 && nota<6)
					mensaje= "Aprobado";
				else if (nota>= 6 && nota<7)
					mensaje= "Bien";
				else if (nota>=7 && nota<9)
					mensaje= "Notable";
				else
					mensaje= "Sobresaliente"; 
					//Habría puesto la condicion de si es mayor o igual que 9 hsta 10, pero asi lo pide el ejericico
					
				Console.WriteLine(mensaje);
           }*/
        }

        #endregion

        #region Ejercicio3
        /*Una persona debe P euros. Propone devolver esa cantidad en n pagos anuales. 
         *Si la tasa de interés que se le aplica es i, el pago anual se calcula mediante 
         *la formula de la derecha. Se desea un programa que lea P, n e i, y calcule la 
         *cantidad A que debe pagar cada año y los intereses totales que ha pagado. */
        class Ejercicio3

        {
            /*static void Main()
            {
				double p, n, i, a;
				

                Console.Write("Dime cuanto debes en euros: ");
                p = double.Parse(Console.ReadLine());
            
                Console.Write("Dime en cuantos pagos anuales puedes pagarlos: ");
                n = double.Parse(Console.ReadLine());

                Console.Write("Dime que tasa de interes se te aplica: ");
                i = double.Parse(Console.ReadLine());  
                
                a= (p*i*Math.Pow(1+i,n))/(Math.Pow(1+i,n)-1);
                
                Console.WriteLine($"La cantidad que debes pagar cada año es: {a:F2} y los intereses totales pagados son: {i*n}");
                          
            }*/
        }

        #endregion

        #region Ejercicio4
        /*Se pide una letra, si la letra es d o D, se escribirá en la pantalla DESCUENTO, 
         * si la letra es I o i, se escribirá IVA en la pantalla, si la letra es P o p, 
         * se escribirá PORCENTAJE , en otro caso se escribirá DATO ERRONEO. Realiza el ejercicio con switch. */
        class Ejercicio4

        {
			/*static void Main()
            {
				
				char letra;
				string mensaje;
				
				Console.Write("Escribe d o D/i o I/p o P : ");
                letra = char.Parse(Console.ReadLine());
                
                switch(letra)
                {
					case 'd':
					case 'D': mensaje = "DESCUENTO";
					break;
					
					case 'i':
					case 'I': mensaje = "IVA";
					break;
					
					case 'p':
					case 'P': mensaje = "PORCENTAJE";
					break;
				
					default: mensaje = "Dato erroneo";
					break;
                 }
					Console.WriteLine(mensaje);
            }*/
        }

        #endregion

        #region Ejercicio5
        /*Se piden cuatro números. Calcula el máximo */
        class Ejercicio5

        {
            /*static void Main()
            {
				int numero1, numero2, numero3, numero4, maximo;
						

                Console.Write("Dime un numero: ");
                numero1 = int.Parse(Console.ReadLine());
            
				Console.Write("otro más: ");
                numero2 = int.Parse(Console.ReadLine());

				Console.Write("otro más: ");
                numero3 = int.Parse(Console.ReadLine());

				Console.Write("y el último: ");
                numero4 = int.Parse(Console.ReadLine());

				if(numero1>numero2 && numero1>numero3 && numero1>numero4)
					maximo=numero1;
				else if(numero2>numero1 && numero2>numero3 && numero2>numero4)
					maximo=numero2;
				else if(numero3>numero1 && numero3>numero2 && numero3>numero4)
					maximo=numero3;
				else
					maximo=numero4;
					
				Console.WriteLine($"El máximo es {maximo}");
                
            }*/
        }

        #endregion

        #region Ejercicio6
        /*Gestionamos un hotel. Se pide el número de noches y si quieren habitación individual (I) 
         *o habitación doble (D).  Si el número de noches es mayor de 2 y la habitación es individual 
         *cobraremos 25€ pero si la habitación es doble cobraremos 40€. Si el número de noches es menor o igual 
         * a 2 y la habitación individual cobraremos 27€, pero si la habitación es doble cobraremos 44€.*/
        class Ejercicio6

        {
           /* static void Main()
            {
				int numeroNoches, precio;
				char habitacion;		

				Console.WriteLine("BIENVENIDO AL HOTEL ANDRES");
				
                Console.Write("Dime cuantas noches te vas a quedar: ");
                numeroNoches = int.Parse(Console.ReadLine());
				
				Console.Write("¿Habitación individual o doble? I/D: ");
                habitacion = char.Parse(Console.ReadLine());
				
				if(numeroNoches>2 && (habitacion=='i' || habitacion == 'I'))
					precio=25;
				else if(numeroNoches>2 && (habitacion=='d' || habitacion == 'D'))
					precio=40;
				else if(numeroNoches<=2 && (habitacion=='i' || habitacion == 'I'))
					precio=27;
				else
					precio=44;
					
				Console.WriteLine($"Genial entonces te saldra a {precio}e la noche haciendo un total de {precio*numeroNoches}e");
            }*/
        }

        #endregion

        
    }
}
