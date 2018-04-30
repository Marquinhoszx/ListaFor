using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            string[] tamanho = new string[40];
            string[] totalCamisas = new string[tamanho.Length];

                int quantidadePP = 0;
                int quantidadeP = 0;
                int quantidadeM = 0;
                int quantidadeG = 0;
                int quantidadeGG = 0;
                int quantidadeXG = 0;
                int quantidadeXGG = 0;

            for (int i = 0; i < tamanho.Length; i++)
            {
                Console.WriteLine("Tamanho" + i + ": ");
                tamanho[i] = Console.ReadLine().ToLower();

                Console.WriteLine();
            }

            for (int i = 0; i < tamanho.Length; i++)
            {
                


                if (tamanho[i] == "pp")
                {
                    quantidadePP ++;
                }
                if (tamanho[i] == "p")
                {
                    quantidadeP ++;
                }
                if (tamanho[i] == "m")
                {
                    quantidadeM ++;
                }
                if (tamanho[i] == "g")
                {
                    quantidadeG ++;
                }
                if (tamanho[i] == "gg")
                {
                    quantidadeGG ++;
                }
                if (tamanho[i] == "xg")
                {
                    quantidadeXG++;
                }
                if (tamanho[i] == "xgg")
                {
                    quantidadeXGG ++;
                }
            }
            Console.WriteLine("QuantidadeP: " + quantidadeP);
            Console.WriteLine("QuantidadePP: " + quantidadePP);
            Console.WriteLine("QuantidadeM: " + quantidadeM);
            Console.WriteLine("QuantidadeG: " + quantidadeG);
            Console.WriteLine("QuantidadeGG: " + quantidadeGG);
            Console.WriteLine("QuantidadeXG: " + quantidadeXG);
            Console.WriteLine("QuantidadeXGG: " + quantidadeXGG);
        }










    }
}

