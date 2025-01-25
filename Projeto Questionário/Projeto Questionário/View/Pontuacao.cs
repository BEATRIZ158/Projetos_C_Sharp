using Npgsql;
using Projeto_Questionário.Controller;
using Projeto_Questionário.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Questionário.View
{
    public partial class Pontuacao : Form
    {
        public Pontuacao()
        {
            InitializeComponent();
        }

        private bool excluirPontuacao = false;

        public void SetExcluirPontuacao(bool valor)
        {
            excluirPontuacao = valor;
        }

        private void listaPontuacao(object sender, EventArgs e)
        {
            controllerPontuacao cPontuacao = new controllerPontuacao();

            // Verifica se é um aluno
            bool isAluno = controleLogin.idTipoUsuario == 2;

            // Nome digitado
            string nomeUsuario = txbUsuarioPont.Text;

            // Busca as pontuações
            NpgsqlDataReader pontuacao = cPontuacao.listaPontuacao(nomeUsuario, controleLogin.idUsuario, isAluno);

            if (pontuacao == null)
            {
                MessageBox.Show("Erro ao buscar pontuações.");
                return;
            }

            if (pontuacao.HasRows)
            {
                dataGridViewPontuacao.Columns.Clear();
                dataGridViewPontuacao.Columns.Add("ID", "ID");
                dataGridViewPontuacao.Columns.Add("NOME", "NOME");
                dataGridViewPontuacao.Columns.Add("ACERTOS", "ACERTOS");
                dataGridViewPontuacao.Columns.Add("ERROS", "ERROS");
                dataGridViewPontuacao.Columns.Add("DATA", "DATA");

                while (pontuacao.Read())
                {
                    string[] linha = new string[]
                    {
                        pontuacao["idtentativa"].ToString(),
                        pontuacao["nomeusuario"].ToString(),
                        pontuacao["totalacertos"].ToString(),
                        pontuacao["totalerros"].ToString(),
                        pontuacao["datatentativa"].ToString()
                    };
                    dataGridViewPontuacao.Rows.Add(linha);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pontuação encontrada.");
            }
        }

        private void excluirPont(object sender, DataGridViewCellEventArgs e)
        {
            if(excluirPontuacao == true)
            {
                DialogResult botao = MessageBox.Show(
                "Deseja excluir esta Pontuação?",
                "Excluir conteúdo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (botao == DialogResult.Yes)
                {
                    modelPontuacao mPontuacao = new modelPontuacao();
                    controllerPontuacao cPontuacao = new controllerPontuacao();

                    mPontuacao.IdTentativa = Convert.ToInt32(dataGridViewPontuacao.CurrentRow.Cells[0].Value);
                    string res = cPontuacao.excluirPontuacao(mPontuacao);
                    MessageBox.Show(res);
                }
            }
        }
    }
}
