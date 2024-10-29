using Projeto_Questionário.Controller;
using Projeto_Questionário.Model;
using Projeto_Questionário.View;

namespace Projeto_Questionário
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }
        private void loadPrincipal(object sender, EventArgs e)
        {

        }
        // Executa o form de login a 1 vez que o form principal dor aberto
        private void formLogin(object sender, EventArgs e)//Shown
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void frmCategoria(object sender, EventArgs e)
        {
            CATEGORIA frm = new CATEGORIA();
            frm.ShowDialog();
        }

        private void formPergunta(object sender, EventArgs e)
        {
            Pergunta frm = new Pergunta();
            frm.ShowDialog();
        }

        private void formUsuario(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.ComboBoxTipoPublic.Items.Clear();
            frm.ShowDialog(); // Mostra o formulário com as mudanças aplicadas
        }

        private void habilitarBotoes(object sender, EventArgs e)
        {
            string idTipo = Convert.ToString(controleLogin.idTipoUsuario);
            MessageBox.Show("Seja Bem vindo(a)", controleLogin.nomeUsuario);

            #region usuarioAluno
            if (controleLogin.idTipoUsuario == 2)
            {
                // Enabled = false; Fica visível porém desabilitado
                // Visible = false; Fica invisivel para o usuário
                novoAluno.Visible = false;
                novoProfessor.Visible = false;
                novaPergunta.Visible = false;

                // Menu horizontal
                novoPergunta.Visible = false;
                novoCategoria.Visible = false;

                editarCategoria.Visible = false;
                editarPergunta.Visible = false;

                pesqCategoria.Visible = false;
                pesqPergunta.Visible = false;
                pesqUsuario.Visible = false;
            }
            #endregion

            #region usuarioProfessor
            else if (controleLogin.idTipoUsuario == 3)
            {
                //novoAluno.Visible = false;
                novoProfessor.Visible = false;
                novoUsuario.Visible = false;
                editarUsuario.Visible = false;
            }
            #endregion
        }
    }
}
