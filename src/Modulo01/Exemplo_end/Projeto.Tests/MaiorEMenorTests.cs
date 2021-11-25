using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.LogicaNegocio.Tests
{
    [TestClass()]
    public class MaiorEMenorTests
    {
        [TestMethod]
        public void DeveEncontrarMaiorEMenorProdutoOrdemAleatoria()
        {
            //Arrange
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0)); //1
            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0)); //2
            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));

            //Act
            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            //Assert
            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }


        [TestMethod]
        public void DeveEncontrarMaiorEMenorProdutoOrdemDecrescente()
        {
            //Arrange
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0)); //1
            carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0)); //2            
            carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));

            //Act
            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            //Assert
            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

    }
}