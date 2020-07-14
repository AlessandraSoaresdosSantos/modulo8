using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.CLEANCODE
{
    public class ExampleOne
    {
        //Nome significativos para os métodos, variáveis e funções

        public double d(double a, double b) 
        {
            return a / b;
        }

        public double EfetuarDivisao(double dividendo, double divisor)
        {
            double resultado = dividendo / divisor;
            
            if (resultado < 0)
                throw new Exception("Resultado negativo");

            return resultado;

        }

    }
}
