using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio09
    {
        public Exercicio09()
        {
            Console.WriteLine("Digite Disciplina: ");
            string discilina = Console.ReadLine();

            double[] notas = new double[4];
            double soma = 0, media = 0;
           


            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota" + i + ": ");
                notas[i] = Convert.ToInt32(Console.ReadLine());

                soma = soma + notas[i];
                media = soma / notas.Length;
            }
            Console.WriteLine("Média: " + media);



















        }
    }
}
