using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.InterfaceSegregationPrinciple.PraticaCorreta
{
    class Cliente : ICadastroCliente
    {
        public void ValidarDados()
        { }
        public void PersistirBanco()
        { }
        public void MandarEmail()
        { }
    }
}
