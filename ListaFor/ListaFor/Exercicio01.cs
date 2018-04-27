using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            string[] nomes = new string[25];

            for (int i = 0; i <= nome.Length; i++)
            {
                Console.WriteLine(i + " " + nome);
            }
           












        }
    }
}
