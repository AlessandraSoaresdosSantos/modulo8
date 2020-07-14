using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.InterfaceSegregationPrinciple.PraticaCorreta
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void PersistirBanco();
        void MandarEmail();
    }
}
