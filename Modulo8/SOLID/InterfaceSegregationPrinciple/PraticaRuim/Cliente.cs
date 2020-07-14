using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.InterfaceSegregationPrinciple.PraticaRuim
{
    public class Cliente : ICadastro
    {
        public void ValidarDados()
        { }
        public void PersistirBanco()
        { }
        public void MandarEmail()
        { }
    }
}
