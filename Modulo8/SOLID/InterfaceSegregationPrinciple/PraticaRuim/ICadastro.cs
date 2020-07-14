using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.InterfaceSegregationPrinciple.PraticaRuim
{
    public interface ICadastro
    {
        void ValidarDados();
        void PersistirBanco();
        void MandarEmail();
    }
}
