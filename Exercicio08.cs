using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFor
{
    class Exercicio08
    {
        public Exercicio08()
        {
            
            
            Console.WriteLine("Quantos números voce deseja cadastrar: ");
            int cadastro = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[cadastro];
            int[] par = new int[cadastro];
            int[] impar = new int[cadastro];
            int paraux = 0;
            int imparaux = 0;
            var exemplopar = "";
            var exemploimpar = "";
            var exemplodigitados = "";

            for (int i = 0; i < cadastro; i++)
            {
                Console.WriteLine("Número" + i +  ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if(numeros[i] % 2 == 0)
                {
                    par[i] = numeros[i];
                    paraux += numeros[i];
                }
                if (numeros[i] % 2 != 0)
                {
                    impar[i] = numeros[i];
                    imparaux += numeros[i];
                }
                exemplopar = string.Join(",", par);
                exemploimpar = string.Join(",", impar);
                exemplodigitados = string.Join(",", numeros);
            }
                Console.WriteLine("Números digitados: " + exemplodigitados);
                Console.WriteLine("Par: " + exemplopar);
                Console.WriteLine("Ímpar: " + exemploimpar);
                
                












        }
    }
}
