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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        //Método para retorna a comboBoxTipo
        public ComboBox ComboBoxTipoPublic
        {
            get { return comboBoxTipo; }
        }

        int idusuario = 0;

        private void novoUsuario(object sender, EventArgs e)
        {
            // Criando uma nova instância de objeto da classe modelUsuario, para usar seus atributos
            modelUsuario mUsuario = new modelUsuario();
            controllerUsuario cUsuario = new controllerUsuario();

            mUsuario.NomeUsuario = txbNomeUser.Text;
            mUsuario.Email = txbEmail.Text;
            mUsuario.Senha = txbSenhaUser.Text;
            mUsuario.IdTipoUsuario = Convert.ToInt32(comboBoxTipo.SelectedValue);

            // Verificar se as senhas coincidem antes de continuar
            if (txbSenhaUser.Text != txbConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas precisam ser iguais!");
                return; // Interrompe a execução se as senhas não forem iguais
            }

            // Se as senhas forem iguais, prossegue com o cadastro
            string res = cUsuario.cadastraUsuario(mUsuario);
            MessageBox.Show(res);
        }

        private void listaUsuario(object sender, EventArgs e)
        {
            modelUsuario mUsuario = new modelUsuario();
            controllerUsuario cUsuario = new controllerUsuario();

            mUsuario.NomeUsuario = txbPesquisaUser.Text + "%";

            NpgsqlDataReader usuario = cUsuario.listaUsuarios(mUsuario);

            // Verifica se o DataReader é nulo
            if (usuario == null)
            {
                MessageBox.Show("Erro: Não foi possível obter os dados de usuário.");
                return;
            }

            // Configurar e exibir o resultado na DataGridView
            if (usuario.HasRows)
            {
                // Limpa a Grid a cada novo SELECT
                dataGridViewUser.Columns.Clear();

                // Define quantas colunas de dados a Grid terá
                dataGridViewUser.ColumnCount = usuario.FieldCount;

                // Vetor que irá armazenar temporariamente os dados de uma linha
                string[] linha = new string[usuario.FieldCount];

                // Usando Laço de repetição para percorrer o DataReader
                while (usuario.Read())
                {
                    // Le os dados das colunas do DataReader
                    for (int i = 0; i < usuario.FieldCount; i++)
                    {
                        linha[i] = usuario.IsDBNull(i) ? "" : usuario.GetValue(i).ToString();
                    }
                    // Insere a linha lida na DataGrid
                    dataGridViewUser.Rows.Add(linha);
                }
            }
        }

        private void configFormUsuario(object sender, EventArgs e)
        {
            modelTipoUsuario mTipoUsuario = new modelTipoUsuario();
            controllerTipoUsuario cTipoUsuario = new controllerTipoUsuario();

            mTipoUsuario.NomeTipo = "%";
            NpgsqlDataReader dados = cTipoUsuario.listaTipoUsuario(mTipoUsuario);

            DataTable tipousuarios = new DataTable();
            tipousuarios.Load(dados);

            comboBoxTipo.DataSource = tipousuarios;
            comboBoxTipo.DisplayMember = "nometipousuario";
            comboBoxTipo.ValueMember = "idtipousuario";

            //desabilita a combobox se o usuário não for admin
            if (controleLogin.idTipoUsuario > 1)
            {
                //Oculta a combo box
                //labelTipo.Visible = false;
                //comboBoxTipo.Visible = false;

                //se o usuário for professor
                if (controleLogin.idTipoUsuario == 3)
                {
                    //define que o tipo de novo usuário será ALUNO (2)
                    comboBoxTipo.SelectedIndex = 1;
                    comboBoxTipo.Enabled = false;//Deixa vísivel mas desabilitado
                }
            }
        }

        private void selecionaLinha(object sender, DataGridViewCellEventArgs e)
        {
            //dialogResult - retorna qual botão foi clicado em uma mensagem
            DialogResult botao =
            MessageBox.Show("Deseja editar este usuário?", "Editar conteúdo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            modelUsuario mUsuario = new modelUsuario();
            modelTipoUsuario mTipoUsuario = new modelTipoUsuario();
            controllerTipoUsuario cTipoUsuario = new controllerTipoUsuario();

            mUsuario.Senha = txbSenhaUser.Text;
            mTipoUsuario.NomeTipo = "%";
            NpgsqlDataReader dados = cTipoUsuario.listaTipoUsuario(mTipoUsuario);

            //DataTable - armazena dados em forma da tabela (tipousuarios)
            DataTable tipousuarios = new DataTable();
            tipousuarios.Load(dados);

            //preencher a ComboBox com os dados do banco de dados (listagem)
            comboBoxTipo1.DataSource = tipousuarios;

            //define qual coluna será exibida na Combobox
            comboBoxTipo1.DisplayMember = "nometipousuario";

            //define qual valor será usado ao selecionar um item
            comboBoxTipo1.ValueMember = "idtipousuario";

            //define qual item será selecionado por padrão
            comboBoxTipo1.SelectedIndex = 0;

            if (botao == DialogResult.Yes)
            {
                //Armazena na variavel idusuario o valor da coluna 0, na linha
                //selecionada na dataGridView
                idusuario = Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value);
                txbEditarUser.Text =
                    dataGridViewUser.CurrentRow.Cells[1].Value.ToString();

                txbEditarEmail.Text =
                    dataGridViewUser.CurrentRow.Cells[2].Value.ToString();

                //Seleciona o tabPage especificado
                tabUsuario.SelectedTab = tabEditar;
            }
        }

        private void atualizaUsuario(object sender, EventArgs e)
        {
            modelUsuario mUsuario = new modelUsuario();
            controllerUsuario cUsuario = new controllerUsuario();

            mUsuario.NomeUsuario = txbEditarUser.Text;
            mUsuario.Email = txbEditarEmail.Text;
            mUsuario.Senha = txbEditarSenha.Text;
            mUsuario.IdTipoUsuario = Convert.ToInt32(comboBoxTipo1.SelectedValue);
            mUsuario.IdUsuario = idusuario;

            string res = cUsuario.atualizaUsuarios(mUsuario);

            MessageBox.Show(res);
        }

        private void btnCancelarUser_Click(object sender, EventArgs e)
        {

        }
    }
}
