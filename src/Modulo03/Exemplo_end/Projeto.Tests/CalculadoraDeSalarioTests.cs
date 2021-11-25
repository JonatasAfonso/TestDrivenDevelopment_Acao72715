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
    public class CalculadoraDeSalarioTests
    {
        [TestMethod()]
        public void CalculaSalaDeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimiterioTest()
        {
            //Arrange
            var calculadora = new CalculadoraDeSalario();
            var desenvolvedor = new Funcionario("Joao", 1500.0, Cargo.DESENVOLVEDOR);

            //Act
            var salario = calculadora.CalculaSalario(desenvolvedor);


            //Assert
            Assert.AreEqual(1500.0 * 0.9, salario);
        }


        [TestMethod]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            //Arrange
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Joao", 4000.0, Cargo.DESENVOLVEDOR);

            //Act
            double salario = calculadora.CalculaSalario(desenvolvedor);


            //Assert
            Assert.AreEqual(4000.0 * 0.8, salario);
        }


        [TestMethod]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            //Arrange
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Joao", 500.0, Cargo.DBA);

            //Act
            double salario = calculadora.CalculaSalario(dba);


            //Assert
            Assert.AreEqual(500.0 * 0.85, salario);
        }
    }
}