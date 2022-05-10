using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Usuario
    {
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string dataDeNascimento, string nomeUsuario, string email, string senha)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            NomeUsuario = nomeUsuario;
            Email = email;
            Senha = senha;
        }
    }
}
