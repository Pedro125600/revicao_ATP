using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma frase:");
            string frase = Console.ReadLine();
            Console.Write("Escreva um caracter para buscar:");
            char caracter = char.Parse(Console.ReadLine());
            Console.Write("De a posição para começar a busca:");
            int posicao = int.Parse(Console.ReadLine());

            int posicaocaracter = Buscar(frase, caracter, posicao);

            if(posicaocaracter < 1)
            {
                Console.WriteLine($"O caracter esta na posição 0");
            }
            else
            {
                Console.WriteLine($"O caracter esta na posição {posicaocaracter + 1}");

            }


            Console.ReadLine();
        }

        static int Buscar(string S, char C, int I)
        {
            return S.IndexOf(C, I);
        }

    }
}
