using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Modulo8.SOLID.SingleResponsibilityPrinciple.PraticaRuim
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
        public void PersistirUsuario()
        {
            SqlConnection conexao = new SqlConnection("string de conexao");
            SqlCommand cmd = new SqlCommand();
            // cmd.CommandText...
            // ...
            // ..
            conexao.Close();
        }
    }
}