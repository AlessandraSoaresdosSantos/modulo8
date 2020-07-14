using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.InterfaceSegregationPrinciple.PraticaRuim
{
    class Produto : ICadastro
    {
        public void ValidarDados()
        { }
        public void PersistirBanco()
        { }
        public void MandarEmail()
        {
            // apenas criamos o metodo mas deixamos vazio.
        }
    }
}
