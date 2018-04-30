using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio10
    {
        public Exercicio10()
        {
            string[] nomes = new string[5];
            int nomeauxA = 0;
            int nomeauxS = 0;
            int nomeSilva = 0;
            int maiorNome = 0;
            int menorNome = 0;


            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome" + i + ": ");
                nomes[i] = Console.ReadLine().ToLower().Trim();

                if (nomes[i] == "s")
                {
                    nomeauxS++; 
                }
                if(nomes[i] == "a")
                {
                    nomeauxA++;
                }

                if (nomes[i] == "silva")
                {
                    nomeSilva++;
                }
                if (nomes[i].Length > maiorNome)
                {
                    maiorNome++;
                }
                if (nomes[i].Length < menorNome)
                {
                    menorNome++;
                }

            }
            Console.WriteLine("Quantidade de pessoas que começam com a letra A: " + nomeauxA);
            Console.WriteLine("Quantidade de pessoa que começam com a letra S: " + nomeauxS);
            Console.WriteLine("Nomes: " + nomes[0] + ", " + nomes[1] + ", " + nomes[2] + ", " + nomes[3] + ", " + nomes[4]);
            Console.WriteLine("Quantidade de nomes que o ultimo sobrenome é silva: " + nomeSilva);
            Console.WriteLine("Menor nome: " + maiorNome);
            Console.WriteLine("Maior nome: " + menorNome);
















        }
    }
}
