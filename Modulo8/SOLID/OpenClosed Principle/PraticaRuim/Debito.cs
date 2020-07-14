using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.OpenClosed_Principle.PraticaRuim
{
    public enum TipoDebito { ContaCorrente, Poupanca }

    public class Debito
    {
        public void Debitar(int valor, TipoDebito tipo)
        {
            if (tipo == TipoDebito.Poupanca)
            {
                // Debita Poupanca
            }

            if (tipo == TipoDebito.ContaCorrente)
            {
                // Debita ContaCorrente
            }
        }
    }
}
