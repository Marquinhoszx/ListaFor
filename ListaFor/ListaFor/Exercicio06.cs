using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Random random = new Random();
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next();
            }
            double media = 0;
            double mediaReal = media / numeros.Length;
            int numeroSoma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeroSoma = 0;
                media = numeros[i] + numeroSoma;
                mediaReal = media / numeros.Length;
            }
            Console.WriteLine("Média: " + mediaReal);

            for (int i = 0; i < numeros.Length; i++)
            {
              
            }








        }
    }
}
