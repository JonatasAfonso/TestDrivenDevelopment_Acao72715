using System;

namespace Projeto.LogicaNegocio
{
    public class NumeroIdentificacaoFiscal
    {
        public string NumeroFiscal { get; set; }
        public bool PessoaSingular { get; set; }


        public bool EhNumeroValido()
        {
            return Possui9Digitos() && ComecaDigitoCorreto();
        }


        private bool Possui9Digitos()
        {
            return NumeroFiscal.Length == 9;
        }

        private bool ComecaDigitoCorreto()
        {
            if (PessoaSingular)
            {
                return NumeroFiscal.StartsWith("1") || NumeroFiscal.StartsWith("2") || NumeroFiscal.StartsWith("3");
            }
            else
            {
                return NumeroFiscal.StartsWith("5") || NumeroFiscal.StartsWith("6") || NumeroFiscal.StartsWith("8") || NumeroFiscal.StartsWith("9");
            }
        }

    }
}
