using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main()
        {

            string txtPatronByte = @"(2[0-5]{2}|1[0-9]{2}|[1-9][0-9]|[0-9])";
            string patron =
            "(?<ip>" +
                txtPatronByte +
                "\\." +
                txtPatronByte +
                "\\." +
                txtPatronByte +
                "\\." +
                $"(?<equipos>{txtPatronByte})" +
             ")";

            for (;;)
            {
                Console.Write("Introduce un texto con IPs: ");
                string IP = Console.ReadLine();

                Match m = Regex.Match(IP, patron);
                do
                {
                    if (m.Success)
                    {
                        Console.WriteLine($"IP = {m.Groups["ip"].Value}");
                        Console.WriteLine($"Equipos = {m.Groups["equipos"].Value}");
                        m = m.NextMatch();
                    }
                }
                while (m.Success);
            }
        }
    }
}

string patronCuenta = @"^(?<>$";
Regex patron = new Regex(patronCuenta);