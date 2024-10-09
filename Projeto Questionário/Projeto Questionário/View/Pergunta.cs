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
        }
    }
}
