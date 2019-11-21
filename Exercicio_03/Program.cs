using System;
using System.Collections.Generic;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Utilizando o conceito de SORT elabore uma aplicação que faça o cadastro de
            fornecedores. Os fornecedores devem possuir o mínimo de 10 propriedades. O
            usuário poderá cadastrar a quantidade de fornecedores que julgar necessário.
            Ao final apresente os dados ordenados por ordem alfabética do nome do
            fornecedor. (1,0 pto)
             */

            List<Fornecedores> fornecedor = new List<Fornecedores>();
            int opc = 0;
            

            do
            {
                var item = new Fornecedores();
                Console.WriteLine("Bem vindo(a) ao cadastro de FORNECEDORES\n");

                // Nome, 
                Console.WriteLine("Digite o Nome do fornecedor");
                item.nome = Console.ReadLine();

                
                /*
                //CNPJ, 
                Console.WriteLine("Digite o CNPJ do fornecedor:");
                item.cnpj = Console.ReadLine();

                //Razão Soscial, 
                Console.WriteLine("Digite a Razão Social do fornecedor:");
                item.razaoSocial = Console.ReadLine();

                //IE, 
                Console.WriteLine("Difite a Inscrição Estadual do fornecedo:");
                item.ie = Console.ReadLine();

                //Endereço, 
                Console.WriteLine("Digite o Endereço do fornecedor:");
                item.endereco = Console.ReadLine();

                //CEP,
                Console.WriteLine("Digite o CEP do fornecedor:");
                item.cep = Console.ReadLine();

                //Cidade, 
                Console.WriteLine("Digite a Cidade do fornecedor:");
                item.cidade = Console.ReadLine();

                //Telefone, 
                Console.WriteLine("Digit o telefone do fornecedor:");
                item.telefone = Console.ReadLine();

                //E-mail, 
                Console.WriteLine("Digite o E-mail do fornecedor:");
                item.email = Console.ReadLine();

                //Responsável
                Console.WriteLine("Digite o nome do contato responsável do fornecedor em questão");
                item.responsavel = Console.ReadLine();
                */
                fornecedor.Add(item);

                Console.Clear();

                Console.WriteLine("Digite a opção desejada\n");
                Console.WriteLine("0 - Para SAIR");
                Console.WriteLine("1 - Para cadastrar um novo fornecedor");
                opc = Convert.ToInt32(Console.ReadLine());
                fornecedor.Sort();

                if (opc == 0)
                {
                    Console.WriteLine("Fornecedores de A -> Z");
                    foreach (var i in fornecedor)
                    {
                        Console.WriteLine(i.nome);
                        
                    }
                    
                    
                    break;
                }
            } while (opc == 1);

           
        }
      
    }
}
