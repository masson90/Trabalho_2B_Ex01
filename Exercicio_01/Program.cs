using System;

namespace Trabalho_2B_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1)
            Em um array bidimensional de 10 linhas por 10 colunas do tipo inteiro, solicite ao
            usuário que preencha este array. Ao final apresente: (1,0 pto)
            a. Média Geral
            b. Maior Número
            c. Menor Número
             */

            int[,] numero = new int[10, 10];
            int maior = 0, menor = 0;
            float media = 0;            

            //ALIMENTANDO ARRAY BIDIMENSIONAL.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Informe o valor:\n");
                    numero[i, j] = Convert.ToInt32(Console.ReadLine());
                    //FORÇA OS PRIMEIROS VALORES SEREM MAIOR E MENOR PARA TER UMA REFERENCIA DENTRO DO ARRAY.
                    if (j == 0)
                    {
                        maior = numero[i, j];
                        menor = numero[i, j];
                    }
                }
            }
            //VERIFICAÇÃO NO RESTO DO ARRAY PARA ACHAR MAIOR E MENOR VALOR.
            foreach (var item in numero)
            {                
                
                if (maior < item)
                {
                    maior = item;
                }
                if (menor > item)
                {
                    menor = item;
                }
                
                //SOMA PARA AO FINAL APRESENTAR MÉDIA.
                media = media + item;
                //

            }
            //A) MÉDIA DOS VALORES EM PONTO FLUTUANTE.
            Console.WriteLine("A MÉDIA geral dos é: " + media / numero.Length);
            //B) MAIOR VALOR DO VETOR.
            Console.WriteLine("O MAIOR numero encontrado foi: " + maior);
            //C) MENOR VALOR DO VETOR.
            Console.WriteLine("O MENOR numero encontrado foi: " + menor);
        }
    }
}
