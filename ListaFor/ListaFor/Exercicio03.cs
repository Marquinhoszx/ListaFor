using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.WriteLine("Quantidade de registros: ");
            int quantidadeRegistros = Convert.ToInt32(Console.ReadLine());
            
            double[] precos = new double[quantidadeRegistros];

            for (int i = 0; i < quantidadeRegistros; i++)
            {
                Console.Write("Preços" + i + ": ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            
            for (int i = 0; i < quantidadeRegistros; i++)
            {
                Console.WriteLine("Preços: " + precos[i]);

            }











        }
    }
}
