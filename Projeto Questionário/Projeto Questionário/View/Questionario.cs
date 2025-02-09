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
    public partial class Questionario : Form
    {
        public Questionario()
        {
            InitializeComponent();
        }

        //Componentes Globais
        NpgsqlDataReader perguntas = null;
        int acertos = 0;
        int numeroPerguntas = 0;

        private void configForm(object sender, EventArgs e)
        {
            modelCategoria mCategoria = new modelCategoria();
            controllerCategoria cCategoria = new controllerCategoria();

            mCategoria.NomeCategoria = "%";
            NpgsqlDataReader dados = cCategoria.listaCategorias(mCategoria);

            DataTable categorias = new DataTable();
            categorias.Load(dados);

            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "nomecategoria";
            comboBox1.ValueMember = "idcategoria";
            comboBox1.SelectedIndex = 0;
        }

        private void buscarPerguntas(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int idcategoria = Convert.ToInt32(comboBox1.SelectedValue);
            int quantidade = Convert.ToInt32(numericUpDown1.Value);

            controllerPergunta cPergunta = new controllerPergunta();
            perguntas = cPergunta.buscaPerguntaPorCategoria(idcategoria, quantidade);

            if (perguntas != null)
            {
                MessageBox.Show("Perguntas Carregadas");
                btnIniciar.Text = "INICIAR";
                btnIniciar.Enabled = true;
            }
        }

        private void proximaPergunta(object sender, EventArgs e)
        {
            btnIniciar.Text = "PRÓXIMA PERGUNTA";
            btnIniciar.Enabled = false;
            if (perguntas.Read())
            {
                //Carregar a pergunta nos campos de texto
                txbPergunta.Text = perguntas.GetValue(1).ToString();
                txbAlter1.Text = perguntas.GetValue(2).ToString();
                txbAlter2.Text = perguntas.GetValue(3).ToString();
                txbAlter3.Text = perguntas.GetValue(4).ToString();
                txbAlter4.Text = perguntas.GetValue(5).ToString();

                btnVerificar.Enabled = true; //habilita botão verificar
            }
            else
            {
                MessageBox.Show("Você já respondeu todas as perguntas!");
                //Bloquear botão de próxima pergunta
                btnIniciar.Enabled = false;
                btnGravar.Enabled = true; //habilita o botão gravar
            }
        }

        private void verificarResposta(object sender, EventArgs e)
        {
            btnIniciar.Enabled = true;
            btnVerificar.Enabled = false;
            numeroPerguntas++;
            lbNumPerguntas.Text = numeroPerguntas.ToString();

            // Armazena na variavel resposta a opção escolhida pelo usuário
            string resposta;
            if (rbAlter1.Checked)
            {
                resposta = txbAlter1.Text;
            }
            else if (rbAlter2.Checked)
            {
                resposta = txbAlter2.Text;
            }
            else if (rbAlter3.Checked)
            {
                resposta = txbAlter3.Text;
            }
            else
            {
                resposta = txbAlter4.Text;
            }

            //compara se a alternativa é igual a resposta correta
            if (resposta == perguntas.GetValue(6).ToString())
            {
                acertos++;
                lbNumAcertos.Text = acertos.ToString();
                MessageBox.Show("ACERTOU!");
            }
            else
            {
                MessageBox.Show("ERROU!");
            }
        }

        private void gravarPontuacao(object sender, EventArgs e)
        {
            modelPontuacao mPontuacao = new modelPontuacao();
            controllerPontuacao cPontuacao = new controllerPontuacao();

            // Acessar o texto do Label e convertê-lo para inteiro
            mPontuacao.IdUsuario = controleLogin.idUsuario;
            mPontuacao.TotalAcertos = int.Parse(lbNumAcertos.Text); // Conversão do texto do Label para int
            mPontuacao.TotalErros = int.Parse(lbNumPerguntas.Text) - mPontuacao.TotalAcertos;
            mPontuacao.DataTentativa = DateTime.Now;

            string res = cPontuacao.gravarPontuacao(mPontuacao);
            MessageBox.Show(res);
            btnGravar.Enabled = false;
        }
    }
}
