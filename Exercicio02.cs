using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] idade = new int[7];

            for (int i = 0; i <= 6; i++)
            {
                Console.Write("Idade" + i + ": ");
                idade[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

                for (int i = 0; i < idade[i]; i++)
                {
                    Console.WriteLine("idade"+ i + ": " +idade[i]);
                }

                





        }
    }
}
