using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.LiskovSubstitutionPrinciple.PraticaRuim
{
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
