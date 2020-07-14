using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.CLEANCODE
{
    public class ExampleThree
    {
        //Ordem dos métodos: 
        //A execução deve ser de cima para baixo
        //Método principal primeiro

        public double EfetuarDivisao(double dividendo, double divisor)
        {
            double resultado = dividendo / divisor;

            ValorNegativo(resultado);

            return resultado;
        }

        public double EfetuarMultiplicacao(double valorA, double valorB)
        {
            double resultado = valorA * valorB;
              
            return resultado;
        }

        private static void ValorNegativo(double resultado)
        {
            if (resultado < 0)
                throw new Exception("Não pode ter resultado negativo");
        }
    }
}
