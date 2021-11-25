using Projeto.LogicaNegocio;
using System;

namespace Projeto.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrinho = new CarrinhoDeCompras();            
            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0)); //1
            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0)); //2
            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            // Executará sem problemas
            Console.WriteLine("O menor produto " + algoritmo.Menor.Nome);
            Console.WriteLine("O maior produto " + algoritmo.Maior.Nome);

            Console.ReadKey();
        }
    }
}
