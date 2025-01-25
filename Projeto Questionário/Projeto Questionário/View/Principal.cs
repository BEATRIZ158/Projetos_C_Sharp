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
            frm.TabControlCategoria.TabPages.RemoveAt(2);
            frm.TabControlCategoria.TabPages.RemoveAt(1);
            frm.ShowDialog();
        }

        private void formPergunta(object sender, EventArgs e)
        {
            Pergunta frm = new Pergunta();
            frm.SetPergunta(true);
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

                menuExcluir.Visible = false;
            }
            #endregion

            #region usuarioProfessor
            else if (controleLogin.idTipoUsuario == (int)TipoUsuario.Professor)
            {
                //novoAluno.Visible = false;
                verPontos.Visible = false;
                novoProfessor.Visible = false;
                novoUsuario.Visible = false;

                MenuExcluirPontuacao.Visible = false;
                MenuExcluirUsuario.Visible = false;

                pesqUsuario.Visible = false;
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
            if (controleLogin.idTipoUsuario == 2 || controleLogin.idTipoUsuario == 3)
            {
                frm.SetEditandoProprioPerfil(true); // Método para configurar o estado
                frm.TabControlUsuario.TabPages.RemoveAt(1);
                frm.TabControlUsuario.TabPages.RemoveAt(0);
            }
            if (controleLogin.idTipoUsuario == 1)
            {
                frm.TabControlUsuario.TabPages.RemoveAt(0);
            }
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
            frm.TabControlUsuario.TabPages.RemoveAt(2);
            frm.TabControlUsuario.TabPages.RemoveAt(1);
            frm.ShowDialog();
        }

        private void chamarExcluirPergunta(object sender, EventArgs e)
        {
            Pergunta frm = new Pergunta();
            frm.TabControlPergunta.TabPages.RemoveAt(0);
            frm.TabControlPergunta.TabPages.RemoveAt(1);
            frm.SetExcluirPergunta(true); //Passando um valor true para meu bool, para não prencher a comboBox
            frm.ShowDialog();
        }

        private void chamarExcluirPontuacao(object sender, EventArgs e)
        {
            Pontuacao frm = new Pontuacao();
            frm.SetExcluirPontuacao(true);
            frm.ShowDialog();
        }

        private void formEditarPergunta(object sender, EventArgs e)
        {
            Pergunta frm = new Pergunta();
            frm.TabControlPergunta.TabPages.RemoveAt(0);
            frm.SetEditarPergunta(true);
            frm.ShowDialog();
        }

        private void formPesquisarPergunta(object sender, EventArgs e)
        {
            Pergunta frm = new Pergunta();
            frm.TabControlPergunta.TabPages.RemoveAt(2);
            frm.TabControlPergunta.TabPages.RemoveAt(0);
            frm.ShowDialog();
        }

        private void formNovaPergunta(object sender, EventArgs e)
        {
            Pergunta frm = new Pergunta();
            frm.TabControlPergunta.TabPages.RemoveAt(2);
            frm.TabControlPergunta.TabPages.RemoveAt(1);
            frm.ShowDialog();
        }

        private void chamarEditarCategoria(object sender, EventArgs e)
        {
            CATEGORIA frm = new CATEGORIA();
            frm.TabControlCategoria.TabPages.RemoveAt(0);
            frm.SetEditarCategoria(true);
            frm.ShowDialog();
        }

        private void chamarPesqCategoria(object sender, EventArgs e)
        {
            CATEGORIA frm = new CATEGORIA();
            frm.TabControlCategoria.TabPages.RemoveAt(2);
            frm.TabControlCategoria.TabPages.RemoveAt(0);
            frm.ShowDialog();
        }

        private void chamarPesquisarUsuario(object sender, EventArgs e)
        {
            Usuario frm = new Usuario(controleLogin.idUsuario);
            frm.TabControlUsuario.TabPages.RemoveAt(2);
            frm.TabControlUsuario.TabPages.RemoveAt(0);
            frm.SetpesqUsuario(true);
            frm.ShowDialog();
        }

        private void chamarExcluirUsuario(object sender, EventArgs e)
        {
            Usuario frm = new Usuario(controleLogin.idUsuario);
            frm.TabControlUsuario.TabPages.RemoveAt(2);
            frm.TabControlUsuario.TabPages.RemoveAt(0);
            frm.SetExcluirUsuario(true);
            frm.ShowDialog();
        }
    }
}
