using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[,] matriz = new int[4, 4];


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(0, 2);
                }
                
            }

            Imprimir(matriz);

            int contlinhas = 0, contcolunas = 0,contzeroLinhas = 0 , contzerocolunas = 0 ;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
               contzeroLinhas = 0; 
               contzerocolunas = 0;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        contzeroLinhas++;
                    }
                    if (matriz[j,i] == 0)
                    {
                        contzerocolunas++;
                    }

                }

                if(contzeroLinhas == 4)
                {
                    contlinhas++;
                }
                if (contzerocolunas == 4)
                {
                    contcolunas++;
                }


            }


            Console.WriteLine($"Esta matriz tem {contlinhas} linha(s) nula(s)");
            Console.WriteLine($"Esta matriz tem {contcolunas} colunas(s) nula(s)");

            Console.ReadLine();
        }
        static void Imprimir(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

       
    }

