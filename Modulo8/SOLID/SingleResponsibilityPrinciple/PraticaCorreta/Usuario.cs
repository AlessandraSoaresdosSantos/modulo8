using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.SOLID.SingleResponsibilityPrinciple.PraticaCorreta
{
  public class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
