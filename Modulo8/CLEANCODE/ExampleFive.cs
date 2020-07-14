using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.CLEANCODE
{
    public class ExampleFive
    {
        //Utilizar regiões

        #region Divisao
        public double EfetuarDivisao(double dividendo, double divisor)
        {
            double resultado = dividendo / divisor;

            ValorNegativo(resultado);

            return resultado;
        }
        #endregion

        #region Multiplicacao
        public double EfetuarMultiplicacao(double valorA, double valorB)
        {
            double resultado = valorA * valorB;

            return resultado;
        }
        #endregion

        #region Privados
        private static void ValorNegativo(double resultado)
        {
            if (resultado < 0)
                throw new Exception("Não pode ter resultado negativo");
        }
        #endregion
    }
}
