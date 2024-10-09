using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projeto_Questionário.Controller;
using Projeto_Questionário.Model;

namespace Projeto_Questionário.View
{
    public partial class CATEGORIA : Form
    {
        public CATEGORIA()
        {
            InitializeComponent();
        }

        // Variáveis globais
        int idcategoria = 0;

        private void novaCategoria(object sender, EventArgs e)
        {
            // Criando uma nova instância de objeto da classe modelCategoria, para usar seus atributos
            modelCategoria mCategoria = new modelCategoria();
            mCategoria.NomeCategoria = txbNomeCategoria.Text.ToUpper();// Converte a string para MAIUSCULO

            // Criando uma nova instância de objeto da classe controllerCategoria, para usar seus métodos
            controllerCategoria cCategoria = new controllerCategoria();

            // Variável que guarda o resultado que retorna da função cadastraCategoria
            // que recebe o como argumento o objeto mCategoria e executa
            string res = cCategoria.cadastraCategoria(mCategoria);

            // Imprimo o resultado da execução do método
            MessageBox.Show(res);
        }

        private void fecharForm(object sender, EventArgs e)
        {
            this.Close();
        }
        //Evento de pesquisar as categorias
        private void listaCategoria(object sender, EventArgs e)
        {
            modelCategoria mCategoria = new modelCategoria();
            controllerCategoria cCategoria = new controllerCategoria();

            //Passando o nome da categoria digitada no campo de texto
            mCategoria.NomeCategoria = txbPesquisaCategoria.Text.ToUpper() + "%";

            // Executa a listagem e armazena no objeto categoria
            NpgsqlDataReader categoria = cCategoria.listaCategorias(mCategoria);

            // Configurar e exibir o resultado na DataGridView
            if (categoria.HasRows)
            {
                // Limpa a Grid a cada novo SELECT
                dataGridView1.Columns.Clear();

                // Define quantas colnas de dados a Grid terá
                dataGridView1.ColumnCount = categoria.FieldCount;

                // Vetor que irá armazenar temporariamente os dados de uma linha
                // propriedade FieldCount -> Retorna a qtd de colunas no DataReader
                string[] linha = new string[categoria.FieldCount];

                // Usando Laço de repetição para percorrer o DataReader de categorias(categoria) enquanto tiver registros
                while (categoria.Read())
                {
                    // Le os dados das colunas do DataReader
                    for (int i = 0; i < categoria.FieldCount; i++)
                    {
                        linha[i] = categoria.GetValue(i).ToString();
                    }
                    // Insere a linha lida na DataGrid
                    dataGridView1.Rows.Add(linha);

                }
            }
        }

        private void selecionaLinha(object sender, DataGridViewCellEventArgs e)
        {
            //dialogResult - retorna qual botão foi clicado em uma mensagem
            DialogResult botao =
            MessageBox.Show("Deseja editar esta categoria?", "Editar conteúdo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (botao == DialogResult.Yes)
            {
                //Armazena na variavel idcategoria o valor da coluna 0, na linha
                //selecionada na dataGridView
                idcategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txbEditarCategoria.Text =
                    dataGridView1.CurrentRow.Cells[1].Value.ToString();

                //Seleciona o tabPage especificado
                tabCategoria.SelectedTab = abaEditar;

            }
        }

        private void atualizaCategoria(object sender, EventArgs e)
        {
            modelCategoria mCategoria = new modelCategoria();
            controllerCategoria cCategoria = new controllerCategoria();

            mCategoria.NomeCategoria = txbEditarCategoria.Text;
            mCategoria.IdCategoria = idcategoria;

            string res = cCategoria.atualizaCategorias(mCategoria);

            MessageBox.Show(res);
        }
    }
}
