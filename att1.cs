using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];


            Random r = new Random();

            for(int i = 0; i < vetor1.Length;i++)
            {
                vetor1[i] = r.Next(0, 11);
            }

            Imprimir(vetor1);
            int menor = vetor1[0], PMenor = 0;


            for (int i = 0; i < vetor1.Length; i++)
            {
                if (menor > vetor1[i])
                {
                    menor = vetor1[i];
                    PMenor = i;
                }

            }

            vetor2 = vetor1;
            vetor2[PMenor] = vetor1[0];
            vetor2[0] = menor;

            Console.WriteLine();

            Imprimir(vetor2);


            Console.ReadLine();



        }

        static void Imprimir(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");

            }
        }
    }
}
