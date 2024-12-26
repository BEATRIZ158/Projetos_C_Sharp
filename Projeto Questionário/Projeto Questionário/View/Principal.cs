using Projeto_Questionário.Controller;
using Projeto_Questionário.Model;
using Projeto_Questionário.View;

namespace Projeto_Questionário
{
    public partial class Principal : Form
    {
        public bool editandoOutroPerfil = false;
        public bool editandoProprioPerfil = false; // Por padrão, assume que está editando outro usuário.

        public enum TipoUsuario
        {
            Admin = 1,
            Aluno = 2,
            Professor = 3
        }

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
            Usuario frm = new Usuario(controleLogin.idUsuario);
            frm.LimparUsuario();
            frm.ComboBoxTipoPublic.Items.Clear();
            //Liberando para criar um novo Aluno
            if (controleLogin.idTipoUsuario == (int)TipoUsuario.Admin)
            {
                frm.SetCriarNovoAluno(true);
            }
            frm.ShowDialog();
        }

        private void habilitarBotoes(object sender, EventArgs e)
        {
            string idTipo = Convert.ToString(controleLogin.idTipoUsuario);
            MessageBox.Show("Seja Bem vindo(a)", controleLogin.nomeUsuario);

            #region usuarioAluno
            if (controleLogin.idTipoUsuario == (int)TipoUsuario.Aluno)
            {
                // Enabled = false; Fica visível porém desabilitado
                // Visible = false; Fica invisivel para o usuário
                novoAluno.Visible = false;
                novoProfessor.Visible = false;
                novaPergunta.Visible = false;

                // Menu horizontal
                novoPergunta.Visible = false;
                novoCategoria.Visible = false;
                novoUsuario.Visible = false;

                editarCategoria.Visible = false;
                editarPergunta.Visible = false;

                pesqCategoria.Visible = false;
                pesqPergunta.Visible = false;
                pesqUsuario.Visible = false;
            }
            #endregion

            #region usuarioProfessor
            else if (controleLogin.idTipoUsuario == (int)TipoUsuario.Professor)
            {
                //novoAluno.Visible = false;
                verPontos.Visible = false;
                novoProfessor.Visible = false;
                novoUsuario.Visible = false;
            }
            #endregion
        }

        private void formQuestionario(object sender, EventArgs e)
        {
            Questionario frm = new Questionario();
            frm.ShowDialog();
        }

        private void formDesempenho(object sender, EventArgs e)
        {
            Pontuacao frm = new Pontuacao();
            frm.ShowDialog();
        }

        private void formEditarUsuario(object sender, EventArgs e)
        {
            Usuario frm = new Usuario(controleLogin.idUsuario);
            frm.SetEditandoProprioPerfil(true); // Método para configurar o estado
            frm.TabControlUsuario.TabPages["tabNovo"].Enabled = false;
            frm.TabControlUsuario.TabPages["tabPesquisar"].Enabled = false;
            frm.ShowDialog();
        }

        private void formUsuarioProfe(object sender, EventArgs e)
        {
            Usuario frm = new Usuario(controleLogin.idUsuario);
            frm.LimparUsuario();
            frm.ComboBoxTipoPublic.Items.Clear();
            //Liberando para criar um novo Professor
            if (controleLogin.idTipoUsuario == (int)TipoUsuario.Admin)
            {
                frm.SetCriarNovoAProfessor(true);
            }
            frm.ShowDialog();
        }

        private void formQualquerUsuario(object sender, EventArgs e)
        {
            Usuario frm = new Usuario(controleLogin.idUsuario);
            frm.LimparUsuario();
            frm.ComboBoxTipoPublic.Items.Clear();
            frm.ShowDialog();
        }
    }
}
