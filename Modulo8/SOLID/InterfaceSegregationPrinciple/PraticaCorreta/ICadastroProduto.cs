using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.InterfaceSegregationPrinciple.PraticaCorreta
{
    public interface ICadastroProduto
    {
        void ValidarDados();
        void PersistirBanco();
    }
}
