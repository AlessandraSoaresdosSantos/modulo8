using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.LiskovSubstitutionPrinciple.PraticaCorreta
{
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
}
