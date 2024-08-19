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
        //region serve para esconder o código, cria uma região nomeada
        #region idUsuario
        public int getidUsuario()
        {
            return this.idUsuario;
        }
        public void setidusuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        #endregion

        #region cpf
        private long getCpf()
        {
            return this.cpf; //Retorna valor cpf
        }

        private void setCpf(long cpf)
        {
            this.cpf = cpf;//A variável que recebe o valor
        }
        #endregion

        #region nomeUsurio
        private string getnomeUsuario()
        {
            return this.nomeUsuario;
        }
        private void setnomeUsuario(string nomeUsuario)
        {
            this.nomeUsuario = nomeUsuario;
        }
        #endregion

        #region email
        private string getEmail()
        {
            return this.email;
        }
        private void setEmail(string email)
        {
            this.email = email;
        }
        #endregion
        
        #region senha
        private string getSenha()
        {
            return this.senha;
        }
        private void setSenha(string senha)
        {
            this.senha = senha;
        }
        #endregion

        #region idTipousuario
        private int getidTipoUsuario()
        {
            return this.idTipoUsuario; 
        }
        private void setidTipoUsuario(int idTipoUsuario)
        {
            this.idTipoUsuario = idTipoUsuario;
        }
        #endregion
    }
}
