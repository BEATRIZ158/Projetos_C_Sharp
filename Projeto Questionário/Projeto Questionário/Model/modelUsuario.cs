using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Questionário.Model
{
    internal class modelUsuario
    {
        private int idUsuario;//autoincremento
        private long cpf; //Inteiro grande
        private string nomeUsuario;
        private string email;
        private string senha;
        private int idTipoUsuario; //combobox

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }

        //Criar o cadastro de usuário

    }
}
