using System;
using System.Collections.Generic;
using System.Linq;
 

namespace SistemaDeProducao
{
    class Tela
    {
        public static void mural()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("--------------------------Sistema de Produção----------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
        }
        public static void menuPrincipal()
        {
            Console.WriteLine("1 - Cadastrar vendedor ");
            Console.WriteLine("2 - Cadastrar produto ");
            Console.WriteLine("3 - Relatorio de produtos ");
            Console.WriteLine("4 - Relatorio de vendedores ");
            Console.WriteLine("5 - Cadastrar entrada no estoque ");
            Console.WriteLine("6 - Cadastrar saída no estoque ");
            Console.WriteLine("7 - Realizar pedido ");
            Console.WriteLine("0 - Sair ");
            Console.WriteLine();
        }

        public static Vendedores Menu1()
        {
            Console.Write("Digite o nome do vendedor : ");
            string nameVendedor = Console.ReadLine();
            Console.Write("Digite o id do vendedor : ");
            int idVendedor = int.Parse(Console.ReadLine());
            Console.Write("Digite o email do vendedor : ");
            string emailVendedor = Console.ReadLine();
            Console.Write("Digite o CPF do vendedor : ");
            string CPFvendedor = Console.ReadLine();

            return new Vendedores(nameVendedor, idVendedor, emailVendedor, CPFvendedor);
        }



        public static Eletronicos Menu2()
        {
            Console.Write("Digite o nome do eletronico : ");
            string nameEletronicos = Console.ReadLine();
            Console.Write("Digite o id do eletronico : ");
            int idEletronicos = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço do eletronico : ");
            double precoEletronicos = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade em estoque do eletronico : ");
            int quantidadeEmEstoqueEletronicos = int.Parse(Console.ReadLine());

            return new Eletronicos(nameEletronicos,idEletronicos,precoEletronicos,quantidadeEmEstoqueEletronicos);
            
        }

        public static Moveis Menu22()
        {
            Console.Write("Digite o nome do Movel : ");
            string nameMoveis = Console.ReadLine();
            Console.Write("Digite o id do Movel : ");
            int idMoveis = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço do Movel : ");
            double precoMoveis = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade em estoque do produto : ");
            int quantidadeEmEstoqueMoveis = int.Parse(Console.ReadLine());

            return new Moveis(nameMoveis, idMoveis, precoMoveis, quantidadeEmEstoqueMoveis);

        }

        public static void Menu3()
        {
            for (int i =0;i<Program.produtos.Count;i++)
            {
                Console.WriteLine("Eletrônicos: " + Program.eletronicos);
                Console.WriteLine("Móveis: " + Program.moveis);
                Console.WriteLine();

            }
        }

        public static void Menu4()
        {
            for (int i =0;i<Program.vendedores.Count;i++)
            {
                Console.WriteLine(Program.vendedores[i]);
                
            }
            Console.WriteLine();
        }

        public static void Menu5()
        {
            Console.Write("-------------------------------------------------------------------");
            Console.Write("------------Bem vindo ao sistema de entrada no estoque-------------");
            Console.Write("-------------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Digite o ID : ");
            int idSearch = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade : ");
            int quantidade = int.Parse(Console.ReadLine());

            Produtos search = Program.produtos.Find(x => x.idEletronicos == idSearch);

            if (search != null)
            {
                
            }
            else
            {
                Console.Write("This id does not exist!");
            }






        }

    }
}
