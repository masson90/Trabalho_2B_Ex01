using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_02
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Utilizando um List<T>; em uma classe de Produtos com pelo menos 10
            propriedades, elabore uma aplicação que contenha um menu com três opções,
            sendo elas, INCLUIR, CONSULTAR e SAIR. O usuário poderá incluir quantos
            produtos julgar necessário. A Consulta poderá ser feita utilizando 5 opções de
            propriedade (Ex: Código, Nome, Fornecedor, etc). A opção Sair, além de
            encerrar a aplicação deve apresentar a quantidade de produtos cadastrados.
             */
            List<Produtos> produtos = new List<Produtos>();
            int opc = 1, tam = 0;
            while (opc != 0)
            {
                
                PrintMenuSistema();
                try { 
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e) 
                {
                    Console.WriteLine($"Opção inválida - {e.ToString()}");
                    opc = 99;
                }
                var teste = new Produtos();
                switch (opc)
                {
                    case 1:
                        IncluirDados(produtos);                        
                        break;
                    case 2:
                        ConsultarDados(produtos, opc);
                        break;
                    case 0:
                        Console.WriteLine("Byeeeee");
                        Console.WriteLine("\nA quantidade de produtos cadastrados é: " + produtos.Count());
                        Console.WriteLine("\n\n");                        
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Aperte uma tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void PrintMenuSistema()
        {
            Console.WriteLine("##########################################");
            Console.WriteLine("Escolha uma das 3 opções a Baixo:");
            Console.WriteLine("0 - para SAIR");
            Console.WriteLine("1 - para INCLUIR:");
            Console.WriteLine("2 - para CONSULTAR");
            Console.WriteLine("##########################################\n");
        }

        private static void ConsultarDados(List<Produtos> produtos, int opc)
        {
            // CONSULTAR
            if (produtos.Count == 0)
            {
                Console.WriteLine("Não há produto cadastrado!");
                Console.ReadLine();
            }

            else
            {
                List<Produtos> listProduto = new List<Produtos>();
                PrintMenuConsulta();
                opc = Convert.ToInt32(Console.ReadLine());
                string pesquisa;

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("1 - CODIGO DO PRODUTO");
                        pesquisa = Console.ReadLine().ToUpper();
                        listProduto = produtos.Where(q => q.codigoProduto.Equals(pesquisa)).ToList();
                        break;
                    case 2:
                        Console.WriteLine("2 - NOME DO PRODUTO");
                        pesquisa = Console.ReadLine().ToUpper();
                        listProduto = produtos.Where(q => q.nomeProduto.Equals(pesquisa)).ToList();
                        break;
                    case 3:
                        Console.WriteLine("3 - FORNECEDOR DO PRODUTO");
                        pesquisa = Console.ReadLine().ToUpper();
                        listProduto = produtos.Where(q => q.fornecedor.Equals(pesquisa)).ToList();
                        break;
                    case 4:
                        Console.WriteLine("4 - TIPO DO PRODUTO");
                        pesquisa = Console.ReadLine().ToUpper();
                        listProduto = produtos.Where(q => q.TipoProduto.Equals(pesquisa)).ToList();
                        break;
                    case 5:
                        Console.WriteLine("5 - MODELO DO PRODUTO");
                        pesquisa = Console.ReadLine().ToUpper();
                        listProduto = produtos.Where(q => q.modeloProduto.Equals(pesquisa)).ToList();
                        break;
                    //case 0:
                    //    opc = 1;
                    //    break;
                    default:
                        Console.WriteLine($"{opc} - Opção inválida");
                        break;
                }
                if (listProduto.Count() == 0)
                {
                    Console.WriteLine("Produto não encontrado, tente novamente!");
                }
                else
                {
                    foreach (var item in produtos)
                    {
                        printProduto(item);
                    }                    
                }
            }
        }

        private static void PrintMenuConsulta()
        {
            Console.WriteLine("Escolha uma das opções para consultar um produto: ");
            Console.WriteLine("0 - para SAIR");
            Console.WriteLine("1 - CODIGO DO PRODUTO");
            Console.WriteLine("2 - NOME DO PRODUTO");
            Console.WriteLine("3 - FORNECEDOR DO PRODUTO");
            Console.WriteLine("4 - TIPO DO PRODUTO");
            Console.WriteLine("5 - MODELO DO PRODUTO");
        }

        private static void printProduto(Produtos item)
        {
            Console.WriteLine("Código do produto:");
            Console.WriteLine(item.codigoProduto);
            Console.WriteLine("Nome do produto:");
            Console.WriteLine(item.nomeProduto);
            Console.WriteLine("Fornecedor do produto:");
            Console.WriteLine(item.fornecedor);
            Console.WriteLine("Tipo do produto:");
            Console.WriteLine(item.TipoProduto);
            Console.WriteLine("Garantia do produto:");
            Console.WriteLine(item.garantiaProduto);
            Console.WriteLine("Data da entrega do produto:");
            Console.WriteLine(item.dataEntradaProduto);
            Console.WriteLine("Marca do produto:");
            Console.WriteLine(item.marcaProduto);
            Console.WriteLine("Modelo do produto:");
            Console.WriteLine(item.modeloProduto);
            Console.WriteLine("Quantidade do produto:");
            Console.WriteLine(item.quantidadeProduto);
            Console.WriteLine("Fabricante do produto:");
            Console.WriteLine(item.fabricacaolidadeProduto);
            Console.ReadLine();
        }

        private static void IncluirDados(List<Produtos> produtos)
        {
            //INCLUIR
            Console.WriteLine("##########-INCLUIR PRODUTO-##########");
            var item = new Produtos();
            //Codigo, 
            Console.WriteLine("Informe o Código do produto:");
            item.codigoProduto = Console.ReadLine().ToUpper();
            //Nome, 
            Console.WriteLine("Informe o Nome do produto:");
            item.nomeProduto = Console.ReadLine().ToUpper();
            //Fornecedor, 
            Console.WriteLine("Informe o Fornecedor do produto:");
            item.fornecedor = Console.ReadLine().ToUpper();
            // Tipo, 
            Console.WriteLine("Informe o Tipo do produto:");
            item.TipoProduto = Console.ReadLine().ToUpper();
            //Garantia, 
            Console.WriteLine("Informe o tempo de Garantia do produto:");
            item.garantiaProduto = Console.ReadLine().ToUpper();
            //DataEntrada, 
            Console.WriteLine("Informe a Data de Entrada do produto:");
            item.dataEntradaProduto = Console.ReadLine().ToUpper();
            //Marca, 
            Console.WriteLine("Informe a Marca do produto:");
            item.marcaProduto = Console.ReadLine().ToUpper();
            //Modelo, 
            Console.WriteLine("Informe o Modelo do produto:");
            item.modeloProduto = Console.ReadLine().ToUpper();
            //Quantidade, 
            Console.WriteLine("Informe a Quantidade do produto:");
            item.quantidadeProduto = Convert.ToInt32(Console.ReadLine().ToUpper());
            //Fabricacao,
            Console.WriteLine("Informe a Data de Fabricacao do produto:");
            item.fabricacaolidadeProduto = Console.ReadLine().ToUpper();
            produtos.Add(item);           
        }
    }
}
