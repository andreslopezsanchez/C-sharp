using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_B4_C
/*
    Crea una clase Polinomio que guarde los datos de un polinomio con un diccionario
    genérico.
    Por ejemplo el polinomio 9xe7 − 3xe3 −7x + 5 se guardaría ...

    Dictionary<int, int> p = new Dictionary<int, int>()
    { {0, 5}, {1, -7}, {3, -3}, {7, 9} };

    Donde los monomios se guardan en orden inverso y la “llave” es el exponente y el “valor”
    el coeficiente.

    El constructor de la clase polinomio los recibirá como una cadena 9x7 - 3x3 - 7x + 5 de la
    siguiente forma y su método string ToString() lo mostrará de forma idéntica.
    Redefine el operador suma binaria para polinomios para que, por ejemplo, si el usuario ha
    introducido estos 2 polinimios …

                                         9xe7 − 3xe3 −7x +5
                                                     4xe2−1
                                    _______________________
                                    9xe7 − 3xe3 +4xe2 −7x+4


Dictionary<int, int> polinomio1 =
new Dictionary<int, int>() { { 0, 5 }, { 1, -7 }, { 3, -3 }, { 7, 9 } };

Dictionary<int, int> polinomio2 =
new Dictionary<int, int>() { { 0, -1 }, { 2, 4 } };

Dictionary<int, int> polinomioSuma = polinomio1 + polinomio2;
con polinomioSuma = { { 0, 4 }, { 1, -7 }, { 2, 4 }, { 3, -3 }, { 7, 9 } };
*/

//EJERCICIO INACABADO. DURACION: 2* 42' 51''
//PREGUNTAR: for decreciente sin el incrementador--; mirar el tostring y el operador para optimizar o hacerlo mejor
{
    class Polinomio
    {
        private Dictionary<int, int> dictPol;
        protected Dictionary<int, int> DictPol
        {
            get
            {
                return dictPol;
            }

        }

        public Polinomio(string cadena)
        {
            dictPol = new Dictionary<int, int>();

            // cadena.Replace(' ', '\0');
            string[] cadenaArray = cadena.Split(' ');
            string cadenaSE = "";
            for (int i = 0; i < cadenaArray.Length; i++)
            {
                cadenaSE += cadenaArray[i];
            }

            Regex patron = new Regex(@"(?<coeficiente>[+-]?\d*)?(?<equis>x)?(?<exponente>\d*)");
            MatchCollection conjunto = patron.Matches(cadenaSE);
            int posicionUltimoValor = conjunto.Count - 2;

            for (int i = posicionUltimoValor; i >= 0; i--)
            {
                if (conjunto[i].Success)
                {
                    int coeficiente;
                    int exponente;

                    if (conjunto[i].Groups["coeficiente"].Value != "" &&
                        conjunto[i].Groups["coeficiente"].Value != "+" &&
                        conjunto[i].Groups["coeficiente"].Value != "-")
                    {
                        coeficiente = int.Parse(conjunto[i].Groups["coeficiente"].Value);
                    }
                    else if (conjunto[i].Groups["coeficiente"].Value == "+" || 
                             conjunto[i].Groups["coeficiente"].Value == "")
                        coeficiente = 1;
                    else
                        coeficiente = -1;

                    if (conjunto[i].Groups["exponente"].Value != "")
                        exponente = int.Parse(conjunto[i].Groups["exponente"].Value);
                    else
                        exponente = 0;

                    if (conjunto[i].Groups["exponente"].Value == "" && conjunto[i].Groups["equis"].Value == "x")
                        exponente = 1;


                    //if (conjunto[i].Groups["exponente"].Value == "")
                    //{
                    //    if (conjunto[i].Groups["equis"].Value == "x")
                    //        exponente = 1;
                    //    else
                    //        exponente = 0;
                    //}
                    //else
                    //    exponente = int.Parse(conjunto[i].Groups["exponente"].Value);

                    dictPol.Add(exponente, coeficiente);
                }
                else
                {
                    throw new Exception("Expresion regular fallida");
                }
            }
        }

        public Polinomio(Dictionary<int, int> dictPol)
        {
            this.dictPol = dictPol;
        }

        //public static Polinomio operator +(Polinomio p1, Polinomio p2)
        //{
        //    Dictionary<int, int> dictPolNEW = new Dictionary<int, int>();

        //    Polinomio mayor, menor;

        //    if (p1.dictPol.Count > p2.dictPol.Count)
        //    {
        //        mayor = p1;
        //        menor = p2;
        //    }
        //    else
        //    {
        //        mayor = p2;
        //        menor = p1;
        //    }

        //    foreach (var valorMayor in mayor.dictPol)
        //    {
        //        foreach (var valorMenor in menor.dictPol)
        //        {
        //            if (!dictPolNEW.ContainsKey(valorMayor.Key) && !dictPolNEW.ContainsKey(valorMenor.Key))
        //            {
        //                if (valorMayor.Key == valorMenor.Key)
        //                {
        //                    int coeficienteTotal = valorMayor.Value + valorMenor.Value;
        //                    dictPolNEW.Add(valorMayor.Key, coeficienteTotal);
        //                }

        //                else if (valorMayor.Key > valorMenor.Key)
        //                    dictPolNEW.Add(valorMenor.Key, valorMenor.Value);

        //                else
        //                    dictPolNEW.Add(valorMayor.Key, valorMayor.Value);
        //            }
        //        }
        //        if (!dictPolNEW.ContainsKey(valorMayor.Key))
        //            dictPolNEW.Add(valorMayor.Key, valorMayor.Value);
        //    }

        //    return new Polinomio(dictPolNEW);
        //}

        public static Polinomio operator +(Polinomio p1, Polinomio p2)
        {
            Dictionary<int, int> dictPolNEW = new Dictionary<int, int>();

            int expMaximoP1 = new List<int>(p1.dictPol.Keys)[p1.DictPol.Count-1];
            int expMaximoP2 = new List<int>(p2.dictPol.Keys)[p2.DictPol.Count-1];
                        
           int expMaximo = Math.Max(expMaximoP1, expMaximoP2);
       
            for (int i = 0; i <= expMaximo; i++)
            {
                if (p1.DictPol.ContainsKey(i) || p2.DictPol.ContainsKey(i))
                {
                    dictPolNEW.Add(i, 0);
                    if (p1.DictPol.ContainsKey(i))
                        dictPolNEW[i] += p1.DictPol[i];
                    if (p2.DictPol.ContainsKey(i))
                        dictPolNEW[i] += p2.DictPol[i];                    
                }
            }

            return new Polinomio(dictPolNEW);
        }

        public string ACadenaAndres()
        {
            string texto = "";
            string[] txtMonomios = new string[dictPol.Count];
            int elementos = 0;

            foreach (var monomio in dictPol)
            {
                bool noSoyPrimeroIzquierda = elementos != dictPol.Count - 1;
                if (monomio.Value > 0 && noSoyPrimeroIzquierda)
                {
                    if (monomio.Key == 0)
                        txtMonomios[elementos] = $"+{monomio.Value}";
                    else if (monomio.Value == 1 && monomio.Key == 1)
                        txtMonomios[elementos] = $"+x";
                    else if (monomio.Value == 1)
                        txtMonomios[elementos] = $"+x{monomio.Key}";
                    else if (monomio.Key == 1)
                        txtMonomios[elementos] = $"+{monomio.Value}";
                    else
                        txtMonomios[elementos] = $"+{monomio.Value}x{monomio.Key}";
                }
                else
                {
                    if (monomio.Key == 0)
                        txtMonomios[elementos] = $"{monomio.Value}";
                    else if (monomio.Value == -1 && monomio.Key == 1)
                        txtMonomios[elementos] = $"-x";
                    else if (monomio.Value == -1)
                        txtMonomios[elementos] = $"-x{monomio.Key}";
                    else if (monomio.Value == 1)
                        txtMonomios[elementos] = $"x{monomio.Key}";
                    else if (monomio.Key == 1)
                        txtMonomios[elementos] = $"{monomio.Value}x";
                    else
                        txtMonomios[elementos] = $"{monomio.Value}x{monomio.Key}";
                }

                elementos++;
            }

            for (int i = txtMonomios.Length - 1; i >= 0; i--)
            {
                texto += $"{txtMonomios[i]}";
            }

            return texto;
        }

        public override string ToString()
        {
            string texto = "";

            foreach(var monomio in DictPol)
            {
                string signo = (monomio.Value > 0) ? "+" : "-";
                int c = Math.Abs(monomio.Value);
                int e = monomio.Key;
                bool soyElUltimoExposnente = e == new List<int>(DictPol.Keys)[DictPol.Count - 1];

                if (e > 1)
                    texto = $"{e}" + texto;
                if (e > 0)
                    texto = "x" + texto;
                if (e == 0)
                    texto = $"{c}" + texto;
                else if (c < -1 || c > 1)
                    texto = $"{c}" + texto;
                if (signo != "+" || !soyElUltimoExposnente)
                    texto = signo + texto;
            }

            return texto;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Polinomio p1 = new Polinomio("x7-3x3+3x2-2x+5");
                Polinomio p2 = new Polinomio("4x2-x-1");


                //Console.WriteLine($"Polinomio: {p1}");
               // Console.WriteLine($"Polinomio: {p2}");

                Console.WriteLine($"\n({p1}) + ({p2}) = {p1 + p2}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
