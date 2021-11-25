using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projeto.LogicaNegocio.Tests
{
    [TestClass()]
    public class NumeroIdentificacaoFiscalTests
    {
        [TestMethod()]
        public void DeveValidarSeTem9Digitos()
        {
            //Arrange
            var nif = new NumeroIdentificacaoFiscal();
            nif.NumeroFiscal = "123456789";

            //Action
            var estaValido = nif.EhNumeroValido();

            //Assert
            Assert.AreEqual(true, estaValido);
        }


        [TestMethod]
        public void DeveValidarSeComecaComDigitoValido()
        {
            //Arrange
            var nif = new NumeroIdentificacaoFiscal();
            nif.NumeroFiscal = "123456789";
            nif.PessoaSingular = true;

            //Action
            var estaValido = nif.EhNumeroValido();

            //Assert
            Assert.AreEqual(true, estaValido);
        }
    }
}