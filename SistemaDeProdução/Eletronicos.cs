using System;
using System.Collections.Generic;

namespace SistemaDeProducao
{
    class Eletronicos : Produtos
    {
        public string name { get; set; }
        public int id { get; set; }
        public double preco { get; set; }
        public int quantidadeEmEstoque { get; set; }

        public Eletronicos(string name, int id, double preco, int quantidadeEmEstoque)
        {
            this.name = name;
            this.id = id;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Eletronicos(string name, int id, double preco)
        {
            this.name = name;
            this.id = id;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }

        public  double valorDeCompra(int quantidade)
        {
            return preco * quantidade;
        }

        public  void entradaEstoque(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public  void saidaEstoque(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

        public override string ToString()
        {
            return "Nome do produto: " + name +
                ", ID: " + id +
                ", Preço: " + preco +
                ", Quantidade em estoque: " + quantidadeEmEstoque;
        }
    }
}
