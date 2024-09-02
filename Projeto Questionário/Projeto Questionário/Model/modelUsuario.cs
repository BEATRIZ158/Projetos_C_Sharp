using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Questionário.Model
{
    internal class modelUsuario
    {
        private int idUsuario;
        private long cpf; //Inteiro grande
        //Está reclamando em string para colocar null ou "" 
        private string nomeUsuario;
        private string email;
        private string senha;
        private int idTipoUsuario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
    }
}
