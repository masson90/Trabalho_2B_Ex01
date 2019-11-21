using System;
using System.Collections.Generic;

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

            List<Produtos> xpto = new List<Produtos>();
            int opc = 0, tam = 0;
            Console.WriteLine("##########################################");
            Console.WriteLine("Escolha uma das 3 opções a Baixo:");
            Console.WriteLine("0 - para SAIR");
            Console.WriteLine("1 - para INCLUIR:");
            Console.WriteLine("2 - para CONSULTAR");
            Console.WriteLine("##########################################\n");
            opc = Convert.ToInt32(Console.ReadLine());


            Console.Clear();

            while (opc == 1 || opc == 2)
            {
                if (opc == 0)
                {
                    Console.WriteLine("A quantidade de produtos cadastrados é: " + tam);
                    break;
                }

                else if (opc == 1)
                {//INCLUIR
                    Console.WriteLine("##########-INCLUIR PRODUTO-##########");
                    var item = new Produtos();
                    //Codigo, 
                    Console.WriteLine("Informe o Código do produto:");
                    item.codigoProduto = Console.ReadLine();

                    //Nome, 
                    Console.WriteLine("Informe o Nome do produto:");
                    item.nomeProduto = Console.ReadLine();

                    //Fornecedor, 
                    Console.WriteLine("Informe o Fornecedor do produto:");
                    item.fornecedor = Console.ReadLine();

                    // Tipo, 
                    Console.WriteLine("Informe o Tipo do produto:");
                    item.TipoProduto = Console.ReadLine();

                    //Garantia, 
                    Console.WriteLine("Informe o tempo de Garantia do produto:");
                    item.garantiaProduto = Console.ReadLine();

                    //DataEntrada, 
                    Console.WriteLine("Informe a Data de Entrada do produto:");
                    item.dataEntradaProduto = Console.ReadLine();

                    //Marca, 
                    Console.WriteLine("Informe a Marca do produto:");
                    item.marcaProduto = Console.ReadLine();

                    //Modelo, 
                    Console.WriteLine("Informe o Modelo do produto:");
                    item.modeloProduto = Console.ReadLine();

                    //Quantidade, 
                    Console.WriteLine("Informe a Quantidade do produto:");
                    item.quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                    //Fabricacao,
                    Console.WriteLine("Informe a Data de Fabricacao do produto:");
                    item.fabricacaolidadeProduto = Console.ReadLine();

                    xpto.Add(item);
                    tam += 1;
                }
                else if (opc == 2)
                {// CONSULTAR - utilizando 5 das 10 propriedades
                    if (tam == 0)
                    {
                        Console.WriteLine("Não há produto cadastrado!");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Escolha uma das opções para consultar um produto: ");
                        Console.WriteLine("0 - para SAIR");
                        Console.WriteLine("1 - CODIGO DO PRODUTO");
                        Console.WriteLine("2 - NOME DO PRODUTO");
                        Console.WriteLine("3 - FORNECEDOR DO PRODUTO");
                        Console.WriteLine("4 - TIPO DO PRODUTO");
                        Console.WriteLine("5 - MODELO DO PRODUTO");
                        opc = Convert.ToInt32(Console.ReadLine());
                        string pesquisa = "";
                        if (opc == 1)
                        {
                            Console.WriteLine("1 - CODIGO DO PRODUTO");
                            pesquisa = Console.ReadLine();
                        }
                        else if (opc == 2)
                        {
                            Console.WriteLine("2 - NOME DO PRODUTO");
                            pesquisa = Console.ReadLine();
                        }
                        else if (opc == 3)
                        {
                            Console.WriteLine("3 - FORNECEDOR DO PRODUTO");
                            pesquisa = Console.ReadLine();
                        }
                        else if (opc == 4)
                        {
                            Console.WriteLine("4 - TIPO DO PRODUTO");
                            pesquisa = Console.ReadLine();
                        }
                        else if (opc == 5)
                        {
                            Console.WriteLine("5 - MODELO DO PRODUTO");
                            pesquisa = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor incorreto!!");
                        }
                        int cont = 0;
                        foreach (var item in xpto)
                        {

                            if (pesquisa == item.codigoProduto || pesquisa == item.nomeProduto || pesquisa == item.fornecedor || pesquisa == item.TipoProduto || pesquisa == item.modeloProduto)
                            {
                                //Codigo, 
                                Console.WriteLine("Código do produto:");
                                Console.WriteLine(item.codigoProduto);

                                //Nome, 
                                Console.WriteLine("Nome do produto:");
                                Console.WriteLine(item.nomeProduto);

                                //Fornecedor, 
                                Console.WriteLine("Fornecedor do produto:");
                                Console.WriteLine(item.fornecedor);

                                // Tipo, 
                                Console.WriteLine("Tipo do produto:");
                                Console.WriteLine(item.TipoProduto);

                                //Garantia, 
                                Console.WriteLine("Garantia do produto:");
                                Console.WriteLine(item.garantiaProduto);


                                //DataEntrada, 
                                Console.WriteLine("Data de entrada do produto:");
                                Console.WriteLine(item.dataEntradaProduto);

                                //Marca, 
                                Console.WriteLine("Marca do produto:");
                                Console.WriteLine(item.marcaProduto);

                                //Modelo, 
                                Console.WriteLine("Modelo do produto:");
                                Console.WriteLine(item.modeloProduto);

                                //Quantidade, 
                                Console.WriteLine("Quantidade do produto:");
                                Console.WriteLine(item.quantidadeProduto);

                                //Fabricacao,
                                Console.WriteLine("Data de Fabricacao do produto:");
                                Console.WriteLine(item.fabricacaolidadeProduto);

                                Console.WriteLine("------------------------");
                                Console.ReadLine();
                            }
                            cont += 1;
                        }
                        if (cont == xpto.Count)
                        {
                            Console.WriteLine("Produto não encontrado, tente novamente!");
                        }


                    }
                }
                Console.Clear();
                Console.WriteLine("##########################################");
                Console.WriteLine("Escolha uma das 3 opções a Baixo:");
                Console.WriteLine("0 - para SAIR");
                Console.WriteLine("1 - para INCLUIR:");
                Console.WriteLine("2 - para CONSULTAR");
                Console.WriteLine("##########################################\n");
                opc = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\nA quantidade de produtos cadastrados é: " + tam);

        }
    }
}
