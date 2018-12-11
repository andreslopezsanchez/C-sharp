using System;


namespace pruebas
{

   
    class program

    {
        static void Main()
        {

            string mensaje;

            Console.Write("Peso en kg: ");
            double peso_kg = double.Parse(Console.ReadLine());

            Console.Write("Altura en m: ");
            double altura_m = double.Parse(Console.ReadLine());

            double imc =(double) peso_kg / (altura_m*altura_m );

            if (imc >= 18 && imc <= 25)
            {
               mensaje = "Estas saludable";

            }
            else if (imc < 18)
            {
               mensaje = "Estas muy delgado";
            }
            else if (imc > 25 && imc <= 30)
            {
                mensaje = "Tienes sobrepeso";
            }
            else if (imc > 30 && imc <= 40)
            {
                mensaje ="Estas obeso";
            }
            else
                mensaje= "Tienes obesidad morbida";
            Console.WriteLine($"Tu imc es {imc:F2} y {mensaje}");
        }
    }
}