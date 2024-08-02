using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] x = new int[5];
            int[] y = new int[5];
            int[] soma = new int[5];
            int[] produto = new int[5];
            int[] diferenca = new int[5];

            for (int i = 0; i < 5; i++)
            {
                x[i] = r.Next(0, 101);
                y[i] = r.Next(0, 101);

            }

            Console.Write("Vetor x: ");
            Imprimir(x);
            Console.Write("\nVetor y: ");
            Imprimir(y);

            for (int i = 0; i < 5; i++)
            {
                soma[i] = x[i] + y[i];
                produto[i] = x[i] * y[i];
                diferenca[i] = x[i] - y[i];
            }

            Console.Write("\nSoma:");
            Imprimir(soma);
            Console.Write("\nPeoduto:");
            Imprimir(produto);
            Console.Write("\nDiferença:");
            Imprimir(diferenca);

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
