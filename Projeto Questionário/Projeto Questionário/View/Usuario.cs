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
using static Projeto_Questionário.View.Pergunta;

namespace Projeto_Questionário.View
{
    public partial class Usuario : Form
    {
        public enum EstadoUsuario
        {
            CriarNovoAluno,
            CriarNovoProf,
            EditarPropPerfil,
            PesqUsuario,
            Excluir,
            EditarUsuario
        }

        private EstadoUsuario estadoUsuario;

        public void DefinirEstadoUsuario(EstadoUsuario estado)
        {
            estadoUsuario = estado;
        }

        public enum EstadoCancelarUsuario
        {
            Criacao,
            Edicao
        }

        private EstadoCancelarUsuario estadoAtual;

        //Métodos públicos para chamar métodos privados
        public TabControl TabControlUsuario
        {
            get { return tabUsuario; } // Retorna o TabUsuario do formulário
        }

        public enum TipoUsuario
        {
            Admin = 1,
            Aluno = 2,
            Professor = 3
        }

        public Usuario(int idUsuario)
        {
            InitializeComponent();
            CarregarDadosUsuario(idUsuario);
        }

        private void CarregarDadosUsuario(int idUsuario)
        {
            controllerUsuario cUsuario = new controllerUsuario();
            NpgsqlDataReader dados = cUsuario.ObterUsuarioPorId(idUsuario);

            if (dados != null && dados.Read())
            {
                // Preenchendo os campos com os dados retornados
                txbEditarNomeUser.Text = dados["nomeusuario"].ToString();
                txbEditarEmail.Text = dados["email"].ToString();

                // Obter o tipo de usuário específico
                int idTipoUsuario = Convert.ToInt32(dados["idtipousuario"]);

                // Preencher a ComboBox com o tipo de usuário correspondente
                controllerTipoUsuario cTipoUsuario = new controllerTipoUsuario();
                NpgsqlDataReader tipoUsuarioDados = cTipoUsuario.ObterTipoUsuarioPorId(controleLogin.idUsuario);

                DataTable tipoUsuarioTabela = new DataTable();
                tipoUsuarioTabela.Load(tipoUsuarioDados);

                comboBoxTipo1.DataSource = tipoUsuarioTabela;
                comboBoxTipo1.DisplayMember = "nometipousuario";
                comboBoxTipo1.ValueMember = "idtipousuario";

                // Definir o valor selecionado
                comboBoxTipo1.SelectedValue = idTipoUsuario;
                comboBoxTipo1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não foi possível carregar os dados do usuário.");
            }
        }

        //Método para retornar a comboBoxTipo
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

            estadoAtual = EstadoCancelarUsuario.Criacao;
            cancelarUsuario();
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

                // Define as colunas que deseja exibir no DataGridView
                dataGridViewUser.Columns.Add("ID", "ID");
                dataGridViewUser.Columns.Add("NOME", "NOME");
                dataGridViewUser.Columns.Add("E-MAIL", "E-MAIL");
                dataGridViewUser.Columns.Add("TIPO", "TIPO");

                // Usando Laço de repetição para percorrer o DataReader
                while (usuario.Read())
                {
                    // Obtem o tipo de usuário da consulta
                    int idTipoUsuarioBanco = int.Parse(usuario["idtipousuario"].ToString());

                    // Filtra de acordo com o tipo do usuário logado
                    if (controleLogin.idTipoUsuario == 3 || estadoUsuario == EstadoUsuario.CriarNovoAluno) // Se for Professor
                    {
                        if (idTipoUsuarioBanco != 2) // Mostrar apenas Alunos
                        {
                            continue; // Ignora registros que não são alunos
                        }
                    }
                    else if (estadoUsuario == EstadoUsuario.CriarNovoProf)
                    {
                        if (idTipoUsuarioBanco != 3) // Mostrar apenas Professor
                        {
                            continue;
                        }
                    }
                    else if (estadoUsuario == EstadoUsuario.Excluir)
                    {
                        int idUsuario = int.Parse(usuario["idusuario"].ToString());
                        if (controleLogin.idUsuario == idUsuario)
                        {
                            continue;
                        }
                    }

                    // Criar a linha ignorando o campo idtipousuario
                    string[] linha = new string[]
                    {
                        usuario["idusuario"].ToString(),      // ID
                        usuario["nomeusuario"].ToString(),   // Nome
                        usuario["email"].ToString(),         // Email
                        usuario["nometipousuario"].ToString()// Tipo (Nome do Tipo)
                    };

                    // Insere a linha na DataGrid
                    dataGridViewUser.Rows.Add(linha);
                }
            }
        }

        //Função para limpar o EditarUsuário
        public void LimparUsuario()
        {
            txbEditarNomeUser.Text = "";
            txbEditarEmail.Text = "";
            comboBoxTipo1.DataSource = null;
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
                //se o usuário for professor
                if (controleLogin.idTipoUsuario == (int)TipoUsuario.Professor)
                {//Alterar aqui!
                    if (estadoUsuario != EstadoUsuario.EditarPropPerfil)
                    {
                        //define que o tipo de novo usuário será ALUNO (2)
                        comboBoxTipo.SelectedIndex = 1;
                        comboBoxTipo.Enabled = false;//Deixa vísivel mas desabilitado
                    }
                }
            }//Alterar aqui!
            else if (estadoUsuario == EstadoUsuario.CriarNovoAluno)
            {
                comboBoxTipo.SelectedIndex = 1;
                comboBoxTipo.Enabled = false;
            }//Alterar aqui!
            else if (estadoUsuario == EstadoUsuario.CriarNovoProf)
            {
                comboBoxTipo.SelectedIndex = 2;
                comboBoxTipo.Enabled = false;
            }
            else if(estadoUsuario == EstadoUsuario.EditarUsuario)
            {
                comboBoxTipo.Enabled = true;
            }
        }

        private void selecionaLinha(object sender, DataGridViewCellEventArgs e)
        {
            //Alterar aqui!
            if (estadoUsuario == EstadoUsuario.Excluir)
            {
                DialogResult botao =
                MessageBox.Show("Deseja excluir este usuário?", "Excluir conteúdo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (botao == DialogResult.Yes)
                {
                    modelUsuario mUsuario = new modelUsuario();
                    controllerUsuario cUsuario = new controllerUsuario();

                    mUsuario.IdUsuario = Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value);
                    string res = cUsuario.excluirUsuario(mUsuario);
                    MessageBox.Show(res);
                }
            }
            //Alterar aqui!
            else if (estadoUsuario != EstadoUsuario.PesqUsuario)
            {
                //dialogResult - retorna qual botão foi clicado em uma mensagem
                DialogResult botao1 =
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

                if (botao1 == DialogResult.Yes)
                {
                    //Armazena na variavel idusuario o valor da coluna 0, na linha
                    //selecionada na dataGridView
                    idusuario = Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value);
                    txbEditarNomeUser.Text =
                        dataGridViewUser.CurrentRow.Cells[1].Value.ToString();

                    txbEditarEmail.Text =
                        dataGridViewUser.CurrentRow.Cells[2].Value.ToString();

                    string tipoUsuario = dataGridViewUser.CurrentRow.Cells[3].Value.ToString();

                    //Converte o texto para o enum
                    if (Enum.TryParse<TipoUsuario>(tipoUsuario, out TipoUsuario tipoEnum))
                    {
                        comboBoxTipo1.SelectedValue = (int)tipoEnum;
                        if (controleLogin.idTipoUsuario == (int)TipoUsuario.Admin)
                        {
                            comboBoxTipo1.Enabled = true;
                        }
                        else
                        {
                            comboBoxTipo1.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tipo de usuário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Seleciona o tabPage especificado
                    tabUsuario.SelectedTab = tabEditar;
                }
            }
        }

        public void AtualizarUsuario(object sender, EventArgs e)
        {
            modelUsuario mUsuario = new modelUsuario();
            controllerUsuario cUsuario = new controllerUsuario();
            //Alterar aqui!
            if (estadoUsuario == EstadoUsuario.EditarPropPerfil)
            {
                mUsuario.IdUsuario = controleLogin.idUsuario; // ID do próprio usuário
            }
            else
            {
                if (dataGridViewUser.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um usuário na lista para atualizar.");
                    return;
                }
                mUsuario.IdUsuario = Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value);

            }

            // Preenche os outros campos
            mUsuario.NomeUsuario = txbEditarNomeUser.Text;
            mUsuario.Email = txbEditarEmail.Text;
            mUsuario.Senha = txbEditarSenha.Text;
            mUsuario.IdTipoUsuario = Convert.ToInt32(comboBoxTipo1.SelectedValue);

            // Validação de senha
            if (txbEditarSenha.Text != txbEditarConfir.Text)
            {
                MessageBox.Show("As senhas precisam ser iguais!");
                return;
            }

            // Atualização
            string resultado = cUsuario.atualizaUsuarios(mUsuario);
            MessageBox.Show(resultado);

            estadoAtual = EstadoCancelarUsuario.Edicao;
            cancelarUsuario();
        }

        private void cancelarUsuario()
        {
            switch (estadoAtual)
            {
                case EstadoCancelarUsuario.Criacao:
                    txbNomeUser.Text = "";
                    txbEmail.Text = "";
                    txbSenhaUser.Text = "";
                    txbConfirmarSenha.Text = "";
                    break;

                case EstadoCancelarUsuario.Edicao:
                    txbEditarNomeUser.Text = "";
                    txbEditarEmail.Text = "";
                    txbEditarSenha.Text = "";
                    txbEditarConfir.Text = "";
                    break;
            }
        }

        private void btnCancelarCriacao(object sender, EventArgs e)
        {
            estadoAtual = EstadoCancelarUsuario.Criacao; // Define o estado para criação
            cancelarUsuario(); // Chama o método reutilizado
        }

        private void btnCancelarEdicao(object sender, EventArgs e)
        {
            estadoAtual = EstadoCancelarUsuario.Edicao; // Define o estado para edição
            cancelarUsuario();
        }
    }
}
