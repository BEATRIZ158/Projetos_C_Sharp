using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projeto_Questionário.Controller;
using Projeto_Questionário.Model;

namespace Projeto_Questionário.View
{
    public partial class Pergunta : Form
    {
        public Pergunta()
        {
            InitializeComponent();
        }

        int idpergunta = 0;

        private void configForm(object sender, EventArgs e)
        {
            modelCategoria mCategoria = new modelCategoria();
            controllerCategoria cCategoria = new controllerCategoria();

            mCategoria.NomeCategoria = "%";
            NpgsqlDataReader dados = cCategoria.listaCategorias(mCategoria);

            //DataTable - armazena dados em forma da tabela (categorias)
            DataTable categorias = new DataTable();
            categorias.Load(dados);

            //preencher a ComboBox com os dados do banco de dados (listagem)
            comboBox1.DataSource = categorias;

            //define qual coluna será exibida na Combobox
            comboBox1.DisplayMember = "nomecategoria";

            //define qual valor será usado ao selecionar  um item
            comboBox1.ValueMember = "idcategoria";

            //define qual item será selecionado por padrão
            comboBox1.SelectedIndex = 0;
        }

        private void novaPergunta(object sender, EventArgs e)
        {
            //verificar se os campos estão em branco
            //IsNullOrEmpty - verifica se está nulo ou em branco
            //IsNullOrWhiteSpace - verifica se só contém espaço (barra de espaço)
            if (String.IsNullOrEmpty(txbPergunta.Text) || String.IsNullOrWhiteSpace(txbPergunta.Text))
            {
                txbPergunta.BackColor = Color.Yellow;
                MessageBox.Show("Há campos não preenchidos");
            }
            else if (String.IsNullOrEmpty(txbAlter1.Text) || String.IsNullOrWhiteSpace(txbAlter1.Text))
            {
                MessageBox.Show("Há campos não preenchidos!");
            }
            else if (String.IsNullOrEmpty(txbAlter2.Text) || String.IsNullOrWhiteSpace(txbAlter2.Text))
            {
                MessageBox.Show("Há campos não preenchidos!");
            }
            else if (String.IsNullOrEmpty(txbAlter3.Text) || String.IsNullOrWhiteSpace(txbAlter3.Text))
            {
                MessageBox.Show("Há campos não preenchidos!");
            }
            else if (String.IsNullOrEmpty(txbAlter4.Text) || String.IsNullOrWhiteSpace(txbAlter4.Text))
            {
                MessageBox.Show("Há campos não preenchidos!");
            }
            else if (String.IsNullOrEmpty(txbResposta.Text) || String.IsNullOrWhiteSpace(txbResposta.Text))
            {
                MessageBox.Show("Há campos não preenchidos!");
            }
            else
            {
                modelPergunta mPergunta = new modelPergunta();
                controllerPergunta cPergunta = new controllerPergunta();

                //atribuindo valores dos campos para os atributos
                mPergunta.Pergunta = txbPergunta.Text;
                mPergunta.Alter1 = txbAlter1.Text;
                mPergunta.Alter2 = txbAlter2.Text;
                mPergunta.Alter3 = txbAlter3.Text;
                mPergunta.Alter4 = txbAlter4.Text;
                mPergunta.Resposta = txbResposta.Text;

                //pegando valor de uma combobox com dados selecionados do BD
                mPergunta.IdCategoria = Convert.ToInt32(comboBox1.SelectedValue);

                // Cria uma lista de alternativas
                var alternativas = new[]
                {
                    txbAlter1.Text,
                    txbAlter2.Text,
                    txbAlter3.Text,
                    txbAlter4.Text
                };

                // Verifica se a resposta está nas alternativas
                if (!alternativas.Contains(txbResposta.Text))
                {
                    MessageBox.Show("A resposta precisa ser igual a alguma alternativa!");
                    return;
                }

                //Passando os valores da instância para o método de cadastro
                string resultado = cPergunta.cadastraPergunta(mPergunta);

                //exibir a resposta do método de cadastro
                MessageBox.Show(resultado);

                txbPergunta.Text = "";
                txbAlter1.Text = "";
                txbAlter2.Text = "";
                txbAlter3.Text = "";
                txbAlter4.Text = "";
                txbResposta.Text = "";
            }
        }

        private void selecionaLinha(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult botao = MessageBox.Show(
                "Deseja editar esta pergunta?",
                "Editar conteúdo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (botao == DialogResult.Yes)
            {
                // Obtém o ID da pergunta selecionada na DataGridView
                int idPergunta = Convert.ToInt32(dataGridViewPergunta.CurrentRow.Cells[0].Value);

                // Instancia objetos necessários
                modelPergunta mPergunta = new modelPergunta { IdPergunta = idPergunta };
                controllerPergunta cPergunta = new controllerPergunta();
                modelCategoria mCategoria = new modelCategoria();
                controllerCategoria cCategoria = new controllerCategoria();

                // Preenche o ComboBox com as categorias
                NpgsqlDataReader dadosCategorias = cCategoria.listaCategorias(mCategoria);

                DataTable categorias = new DataTable();
                categorias.Load(dadosCategorias);

                comboBoxEditarCategoria.DataSource = categorias;
                comboBoxEditarCategoria.DisplayMember = "nomecategoria";
                comboBoxEditarCategoria.ValueMember = "idcategoria";
                comboBoxEditarCategoria.SelectedIndex = 0;

                // Busca os detalhes da pergunta no banco
                NpgsqlDataReader dadosPergunta = cPergunta.detalhesPergunta(mPergunta);

                if (dadosPergunta != null && dadosPergunta.HasRows)
                {
                    while (dadosPergunta.Read())
                    {
                        // Preenche os campos da aba de edição
                        rtbEditarPergunta.Text = dadosPergunta["pergunta"].ToString();
                        rtbEditarAlter1.Text = dadosPergunta["alter1"].ToString();
                        rtbEditarAlter2.Text = dadosPergunta["alter2"].ToString();
                        rtbEditarAlter3.Text = dadosPergunta["alter3"].ToString();
                        rtbEditarAlter4.Text = dadosPergunta["alter4"].ToString();
                        rtbEditarResposta.Text = dadosPergunta["resp"].ToString();

                        // Seleciona a categoria correta
                        comboBoxEditarCategoria.SelectedValue = Convert.ToInt32(dadosPergunta["idcategoria"]);
                    }
                }
                // Troca para a aba de edição
                tabPergunta.SelectedTab = abaEditar;
            }
        }

        private void listaPerguntas(object sender, EventArgs e)
        {
            modelPergunta mPergunta = new modelPergunta();
            controllerPergunta cPergunta = new controllerPergunta();

            mPergunta.Pergunta = txbPesquisaPergunta.Text + "%";

            NpgsqlDataReader pergunta = cPergunta.listaPerguntas(mPergunta);

            // Verifica se o DataReader é nulo
            if (pergunta == null)
            {
                MessageBox.Show("Erro: Não foi possível obter os dados da pergunta.");
                return;
            }

            // Configurar e exibir o resultado na DataGridView
            if (pergunta.HasRows)
            {
                // Limpa a Grid a cada novo SELECT
                dataGridViewPergunta.Columns.Clear();
                dataGridViewPergunta.Rows.Clear();

                // Configura as colunas da DataGridView
                dataGridViewPergunta.Columns.Add("ID", "ID");
                dataGridViewPergunta.Columns.Add("PERGUNTA", "PERGUNTA");
                dataGridViewPergunta.Columns.Add("RESPOSTA", "RESPOSTA");
                dataGridViewPergunta.Columns.Add("CATEGORIA", "CATEGORIA");

                // Usando Laço de repetição para percorrer o DataReader
                while (pergunta.Read())
                {
                    // Criar a linha com apenas as colunas relevantes
                    string[] linha = new string[]
                    {
                        pergunta["idpergunta"].ToString(),   // ID
                        pergunta["pergunta"].ToString(),     // Pergunta
                        pergunta["resp"].ToString(),         // Resposta
                        pergunta["nomecategoria"].ToString() // Categoria
                    };

                    // Adicionar a linha ao DataGridView
                    dataGridViewPergunta.Rows.Add(linha);
                }
            }
        }

        private void atualizaPerguntas(object sender, EventArgs e)
        {
            // Criando uma nova instância de objeto da classe modelUsuario, para usar seus atributos
            modelPergunta mPergunta = new modelPergunta();
            controllerPergunta cPergunta = new controllerPergunta();

            mPergunta.Pergunta = rtbEditarPergunta.Text;
            mPergunta.Alter1 = rtbEditarAlter1.Text;
            mPergunta.Alter2 = rtbEditarAlter2.Text;
            mPergunta.Alter3 = rtbEditarAlter3.Text;
            mPergunta.Alter4 = rtbEditarAlter4.Text;
            mPergunta.Resposta = rtbEditarResposta.Text;
            mPergunta.IdCategoria = Convert.ToInt32(comboBoxEditarCategoria.SelectedValue);
            mPergunta.IdPergunta = Convert.ToInt32(dataGridViewPergunta.CurrentRow.Cells[0].Value);

            // Cria uma lista de alternativas
            var alternativas = new[]
            {
                rtbEditarAlter1.Text,
                rtbEditarAlter2.Text,
                rtbEditarAlter3.Text,
                rtbEditarAlter4.Text
            };

            // Verifica se a resposta está nas alternativas
            if (!alternativas.Contains(rtbEditarResposta.Text))
            {
                MessageBox.Show("A resposta precisa ser igual a alguma alternativa!");
                return;
            }

            // Se as senhas forem iguais, prossegue com o cadastro
            string res = cPergunta.atualizaPerguntas(mPergunta);
            MessageBox.Show(res);

            rtbEditarPergunta.Text = "";
            rtbEditarAlter1.Text = "";
            rtbEditarAlter2.Text = "";
            rtbEditarAlter3.Text = "";
            rtbEditarAlter4.Text = "";
            rtbEditarResposta.Text = "";
        }
    }
}
