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
            string[] tamanho = new string[3];
            string[] totalCamisas = new string[tamanho.Length];

            for (int i = 0; i < tamanho.Length; i++)
            {
                Console.WriteLine("Tamanho" + i + ": ");
                tamanho[i] = Console.ReadLine().ToLower();

                Console.WriteLine();
            }

            for (int i = 0; i < tamanho.Length; i++)
            {
                string quantidadePP = tamanho[i];
                string quantidadeP = tamanho[i];
                string quantidadeM = tamanho[i];
                string quantidadeG = tamanho[i];
                string quantidadeGG = tamanho[i];
                string quantidadeXG = tamanho[i];
                string quantidadeXGG = tamanho[i];
                


                if (quantidadePP == "pp")
                {
                    Console.Write("Quantidade de camisas PP: " + quantidadePP);
                }
                if (quantidadeP == "p")
                {
                    Console.WriteLine("Quantidade de camisa P: " + quantidadeP);
                }
                if (quantidadeM == "m")
                {
                    Console.WriteLine("Quantidade de camisa M: " + quantidadeM);
                }
                if (quantidadeG == "g")
                {
                    Console.WriteLine("Quantidade de camisa G: " + quantidadeG);
                }
                if (quantidadeGG == "gg")
                {
                    Console.WriteLine("Quantidade de camisa GG: " + quantidadeGG);
                }
                if (quantidadeXG == "xg")
                {
                    Console.WriteLine("Quantidade de camisa XG: " + quantidadeXG);
                }
                if (quantidadeXGG == "xgg")
                {
                    Console.WriteLine("Quantidade de camisas XGG: " + quantidadeXGG);
                }
            }






        }










    }
}

