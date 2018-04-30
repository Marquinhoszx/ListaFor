using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.WriteLine("Quantos jogos você deseja cadastrar: ");
            int quantidadeDeJogos = Convert.ToInt32(Console.ReadLine());
            string[] jogos = new string[quantidadeDeJogos];
            int[] unidades = new int[quantidadeDeJogos];

            for (int i = 0; i < quantidadeDeJogos; i++)
            {
                Console.WriteLine("Nome do jogo: ");
                jogos[i] = Console.ReadLine();

                Console.WriteLine("Quantidade de Unidades: ");
                unidades[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < quantidadeDeJogos; i++)
            {
                string final = string.Format("Jogo: {0}    possui: {1}   unidades", jogos[i], unidades[i]);
                Console.WriteLine(final);
            }

















        }
    }
}
