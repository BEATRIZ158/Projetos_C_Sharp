using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto_Questionário.Controller;
using Projeto_Questionário.Model;
using Npgsql;

namespace Projeto_Questionário.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void logar(object sender, EventArgs e)
        {
            // Instância de bojeto de classe dá acesso aos dados do usuário
            modelUsuario mUsuario = new modelUsuario();
            controllerUsuario cUsuario = new controllerUsuario();

            mUsuario.Email = textBox1.Text;
            mUsuario.Senha = textBox2.Text;

            // DataReader é como uma tabela
            NpgsqlDataReader usuario = cUsuario.login(mUsuario);

            if (usuario.Read())
            {
                //Armazena os dados do usuário no controleLogin
                controleLogin.idUsuario = Convert.ToInt32(usuario.GetValue(0));
                controleLogin.nomeUsuario = usuario.GetValue(1).ToString();
                controleLogin.idTipoUsuario = Convert.ToInt32(usuario.GetValue(2));

                this.Close();//Fecha o form de Login
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }
    }
}
