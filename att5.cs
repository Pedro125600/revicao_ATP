using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavrasCensuradas = { "porra", "pau no cu", "caralho", "filho da puta" };
            Console.Write("Digite um texto:");
            string texto = Console.ReadLine();

            Console.WriteLine(censura(texto, palavrasCensuradas));
            Console.ReadLine();
        }

        static string censura(string texto , string[] palavrasCensuradas)
        {
            string novotexto = "";
            novotexto = texto.Replace(palavrasCensuradas[0], "[censurado]");
            for (int i = 1; i < palavrasCensuradas.Length; i++)
            {
                novotexto = novotexto.Replace(palavrasCensuradas[i], "[censurado]");

            }

            return novotexto;
        }

    }
}
