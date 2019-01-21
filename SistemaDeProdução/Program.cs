using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDeProducao
{
    class Program
    {
        public static List<Vendedores> vendedores = new List<Vendedores>();
        public static List<Produtos> produtos = new List<Produtos>();
        public static Produtos eletronicos;
        public static Produtos moveis;
        public static int n;
        static void Main(string[] args)
        {
            
            do
            {
                /*
                    Este programa, consiste em criar uma estrutura de dados em vetor ou lista para cadastrar produtos eletrônicos e vendedores
                    armazena - los.
                    Realizar uma consulta, retirar um item do estoque, atualizar e depois inserir um item.
                    Após isto imprimir um relatório de vendedores e produtos.
                */



                Tela.mural();
                Tela.menuPrincipal();
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("----------------Bem vindo ao cadastro de vendedores-----------------");
                        Console.WriteLine("--------------------------------------------------------------------");

                        try
                        {
                           
                            vendedores.Add(Tela.Menu1());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ERRO INESPERADO, VOCÊ DIGITOU UM COMANDO INVÁLIDO!" + e.Message);
                        }
                        break;

                    case 2:

                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("----------------Bem vindo ao cadastro de Produtos-------------------");
                        Console.WriteLine("--------------------------------------------------------------------");

                        try
                        {
                            Console.Write(" Tecle 1 para móveis e 2 para eletrônicos: ");
                            int resposta = int.Parse(Console.ReadLine());

                            if (resposta == 2)
                            {
                                eletronicos = Tela.Menu2();
                                produtos.Add(eletronicos);
                                
                            }
                            else if (resposta == 1)
                            {
                                moveis = Tela.Menu22();
                                produtos.Add(moveis);
                            }
                            

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ERRO INESPERADO, VOCÊ DIGITOU UM NUMERO INVÀLIDO!" + e.Message);
                        }


                        break;

                    case 3:

                        Tela.Menu3();

                        break;

                    case 4:

                        Tela.Menu4();

                        break;

                    case 5:

                        Tela.Menu5();

                        break;
                }
            }
            while (n != 0);
            
            
        }
    }
}
