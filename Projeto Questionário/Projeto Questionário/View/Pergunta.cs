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

                //Passando os valores da instância para o método de cadastro
                string resultado = cPergunta.cadastraPergunta(mPergunta);

                //exibir a resposta do método de cadastro
                MessageBox.Show(resultado);
            }
        }

        private void selecionaLinha(object sender, DataGridViewCellEventArgs e)
        {

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

                // Define quantas colunas de dados a Grid terá
                dataGridViewPergunta.ColumnCount = pergunta.FieldCount;

                // Vetor que irá armazenar temporariamente os dados de uma linha
                string[] linha = new string[pergunta.FieldCount];

                // Usando Laço de repetição para percorrer o DataReader
                while (pergunta.Read())
                {
                    // Le os dados das colunas do DataReader
                    for (int i = 0; i < pergunta.FieldCount; i++)
                    {
                        linha[i] = pergunta.IsDBNull(i) ? "" : pergunta.GetValue(i).ToString();
                    }
                    // Insere a linha na DataGrid
                    dataGridViewPergunta.Rows.Add(linha);
                }
            }
        }

        private void atualizaPerguntas(object sender, EventArgs e)
        {

        }
    }
}
