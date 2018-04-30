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
                numeros[i] = random.Next(-200,200);
            }
            double media = 0;
            double mediaReal = media / numeros.Length;
            int numeroPar = 0, numeroImpar = 0, neutro = 0, numeroPositivo = 0, numeroNegativo = 0;



            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    numeroPar++;
                }
                if (numeros[i] % 2 != 0)
                {
                    numeroImpar++;
                }
                if (numeros[i] == 0)
                {
                    neutro++;
                }
                if (numeros[i] > 0)
                {
                    numeroPositivo++;
                }
                if (numeros[i] < 0)
                {
                    numeroNegativo++;
                }
                
                
                media = media + numeros[i];
                mediaReal = media / numeros.Length;
            Console.WriteLine("Números: " + numeros[i]);
            }
            
            Console.WriteLine("Média: " + mediaReal);
            Console.WriteLine("Quantidade de Números positivos: " + numeroPositivo);
            Console.WriteLine("Quantiadde de Números negativos: " + numeroNegativo);
            Console.WriteLine("Quantidade de Números neutros: " + neutro);
            Console.WriteLine("Quantidade de Números pares: " + numeroPar);
            Console.WriteLine("Quantidade de Números Ímpares: " + numeroImpar);





        }
    }
}
