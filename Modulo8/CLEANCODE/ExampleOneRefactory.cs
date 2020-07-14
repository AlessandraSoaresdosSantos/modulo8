using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.CLEANCODE
{
    public class ExampleOneRefactory
    {
        public double EfetuarDivisao(double dividendo, double divisor)
        {
            double resultado = dividendo / divisor;

            ValorNegativo(resultado);

            return resultado;
        }

        private static void ValorNegativo(double resultado)
        {
            if (resultado < 0)
                throw new Exception("Não pode ter resultado negativo");
        } 
    }
}
