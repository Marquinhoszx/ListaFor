using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio011
    {
        public Exercicio011()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome" + i + ": ");
                nomes[i] = Console.ReadLine();

            }
            Console.WriteLine("Nomes: " + nomes[0]+ ", " + nomes[1] + ", " + nomes[2] + ", " + nomes[3] + ", " + nomes[4]);












        }
    }
}
