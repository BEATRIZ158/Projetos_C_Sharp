namespace Projeto_Questionário.View
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            tabUsuario = new TabControl();
            tabNovo = new TabPage();
            txbConfirmarSenha = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnCancelarUser = new Button();
            btnCadastrarUser = new Button();
            txbSenhaUser = new TextBox();
            label4 = new Label();
            txbEmail = new TextBox();
            label3 = new Label();
            comboBoxTipo = new ComboBox();
            labelTipo = new Label();
            label1 = new Label();
            txbNomeUser = new TextBox();
            tabPesquisar = new TabPage();
            dataGridViewUser = new DataGridView();
            colunaid = new DataGridViewTextBoxColumn();
            colunaCategoria = new DataGridViewTextBoxColumn();
            colunaEmail = new DataGridViewTextBoxColumn();
            columnTipoUser = new DataGridViewTextBoxColumn();
            btnPesquisaUser = new Button();
            txbPesquisaUser = new TextBox();
            txtUser = new Label();
            tabEditar = new TabPage();
            txbEditarConfir = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            btnAtualizar = new Button();
            txbEditarSenha = new TextBox();
            label6 = new Label();
            txbEditarEmail = new TextBox();
            label7 = new Label();
            comboBoxTipo1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            txbEditarNomeUser = new TextBox();
            tabUsuario.SuspendLayout();
            tabNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabUsuario
            // 
            tabUsuario.Controls.Add(tabNovo);
            tabUsuario.Controls.Add(tabPesquisar);
            tabUsuario.Controls.Add(tabEditar);
            tabUsuario.Font = new Font("Century", 12F);
            tabUsuario.Location = new Point(5, 5);
            tabUsuario.Name = "tabUsuario";
            tabUsuario.SelectedIndex = 0;
            tabUsuario.Size = new Size(678, 383);
            tabUsuario.TabIndex = 0;
            // 
            // tabNovo
            // 
            tabNovo.Controls.Add(txbConfirmarSenha);
            tabNovo.Controls.Add(label2);
            tabNovo.Controls.Add(pictureBox1);
            tabNovo.Controls.Add(btnCancelarUser);
            tabNovo.Controls.Add(btnCadastrarUser);
            tabNovo.Controls.Add(txbSenhaUser);
            tabNovo.Controls.Add(label4);
            tabNovo.Controls.Add(txbEmail);
            tabNovo.Controls.Add(label3);
            tabNovo.Controls.Add(comboBoxTipo);
            tabNovo.Controls.Add(labelTipo);
            tabNovo.Controls.Add(label1);
            tabNovo.Controls.Add(txbNomeUser);
            tabNovo.Location = new Point(4, 29);
            tabNovo.Name = "tabNovo";
            tabNovo.Padding = new Padding(3);
            tabNovo.Size = new Size(670, 350);
            tabNovo.TabIndex = 0;
            tabNovo.Text = "NOVO USUÁRIO";
            tabNovo.UseVisualStyleBackColor = true;
            // 
            // txbConfirmarSenha
            // 
            txbConfirmarSenha.Location = new Point(229, 247);
            txbConfirmarSenha.Multiline = true;
            txbConfirmarSenha.Name = "txbConfirmarSenha";
            txbConfirmarSenha.Size = new Size(251, 28);
            txbConfirmarSenha.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 224);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 11;
            label2.Text = "CONFIRMAR SENHA:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 228);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnCancelarUser
            // 
            btnCancelarUser.Image = (Image)resources.GetObject("btnCancelarUser.Image");
            btnCancelarUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarUser.Location = new Point(476, 297);
            btnCancelarUser.Name = "btnCancelarUser";
            btnCancelarUser.Size = new Size(128, 37);
            btnCancelarUser.TabIndex = 9;
            btnCancelarUser.Text = "CANCELAR";
            btnCancelarUser.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarUser.UseVisualStyleBackColor = true;
            btnCancelarUser.Click += this.fecharForm;
            // 
            // btnCadastrarUser
            // 
            btnCadastrarUser.Image = (Image)resources.GetObject("btnCadastrarUser.Image");
            btnCadastrarUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarUser.Location = new Point(283, 297);
            btnCadastrarUser.Name = "btnCadastrarUser";
            btnCadastrarUser.Size = new Size(138, 37);
            btnCadastrarUser.TabIndex = 8;
            btnCadastrarUser.Text = "CADASTRAR";
            btnCadastrarUser.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrarUser.UseVisualStyleBackColor = true;
            btnCadastrarUser.Click += novoUsuario;
            // 
            // txbSenhaUser
            // 
            txbSenhaUser.Location = new Point(229, 177);
            txbSenhaUser.Multiline = true;
            txbSenhaUser.Name = "txbSenhaUser";
            txbSenhaUser.Size = new Size(251, 28);
            txbSenhaUser.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 154);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "SENHA:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(229, 115);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(251, 28);
            txbEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 92);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "E-MAIL:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(486, 115);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(172, 28);
            comboBoxTipo.TabIndex = 3;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(486, 92);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(54, 20);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "TIPO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 24);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 1;
            label1.Text = "NOME DO USUÁRIO:";
            // 
            // txbNomeUser
            // 
            txbNomeUser.Location = new Point(229, 47);
            txbNomeUser.Multiline = true;
            txbNomeUser.Name = "txbNomeUser";
            txbNomeUser.Size = new Size(429, 28);
            txbNomeUser.TabIndex = 0;
            // 
            // tabPesquisar
            // 
            tabPesquisar.Controls.Add(dataGridViewUser);
            tabPesquisar.Controls.Add(btnPesquisaUser);
            tabPesquisar.Controls.Add(txbPesquisaUser);
            tabPesquisar.Controls.Add(txtUser);
            tabPesquisar.Location = new Point(4, 29);
            tabPesquisar.Name = "tabPesquisar";
            tabPesquisar.Padding = new Padding(3);
            tabPesquisar.Size = new Size(670, 350);
            tabPesquisar.TabIndex = 1;
            tabPesquisar.Text = "PESQUISAR";
            tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.AllowUserToDeleteRows = false;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { colunaid, colunaCategoria, colunaEmail, columnTipoUser });
            dataGridViewUser.Location = new Point(15, 61);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUser.Size = new Size(639, 277);
            dataGridViewUser.TabIndex = 11;
            dataGridViewUser.CellClick += selecionaLinha;
            // 
            // colunaid
            // 
            colunaid.HeaderText = "ID";
            colunaid.Name = "colunaid";
            // 
            // colunaCategoria
            // 
            colunaCategoria.HeaderText = "NOME";
            colunaCategoria.Name = "colunaCategoria";
            // 
            // colunaEmail
            // 
            colunaEmail.HeaderText = "E-MAIL";
            colunaEmail.Name = "colunaEmail";
            // 
            // columnTipoUser
            // 
            columnTipoUser.HeaderText = "TIPO";
            columnTipoUser.Name = "columnTipoUser";
            // 
            // btnPesquisaUser
            // 
            btnPesquisaUser.BackColor = Color.DarkGray;
            btnPesquisaUser.Image = (Image)resources.GetObject("btnPesquisaUser.Image");
            btnPesquisaUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisaUser.Location = new Point(525, 12);
            btnPesquisaUser.Name = "btnPesquisaUser";
            btnPesquisaUser.Size = new Size(119, 35);
            btnPesquisaUser.TabIndex = 10;
            btnPesquisaUser.Text = "BUSCAR";
            btnPesquisaUser.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisaUser.UseVisualStyleBackColor = false;
            btnPesquisaUser.Click += listaUsuario;
            // 
            // txbPesquisaUser
            // 
            txbPesquisaUser.BorderStyle = BorderStyle.FixedSingle;
            txbPesquisaUser.Location = new Point(101, 12);
            txbPesquisaUser.Multiline = true;
            txbPesquisaUser.Name = "txbPesquisaUser";
            txbPesquisaUser.Size = new Size(406, 35);
            txbPesquisaUser.TabIndex = 9;
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(15, 23);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(80, 21);
            txtUser.TabIndex = 8;
            txtUser.Text = "USUÁRIO:";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(txbEditarConfir);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(pictureBox2);
            tabEditar.Controls.Add(button1);
            tabEditar.Controls.Add(btnAtualizar);
            tabEditar.Controls.Add(txbEditarSenha);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(txbEditarEmail);
            tabEditar.Controls.Add(label7);
            tabEditar.Controls.Add(comboBoxTipo1);
            tabEditar.Controls.Add(label8);
            tabEditar.Controls.Add(label9);
            tabEditar.Controls.Add(txbEditarNomeUser);
            tabEditar.Location = new Point(4, 29);
            tabEditar.Name = "tabEditar";
            tabEditar.Size = new Size(670, 350);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "EDITAR";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // txbEditarConfir
            // 
            txbEditarConfir.Location = new Point(230, 241);
            txbEditarConfir.Multiline = true;
            txbEditarConfir.Name = "txbEditarConfir";
            txbEditarConfir.Size = new Size(251, 28);
            txbEditarConfir.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 218);
            label5.Name = "label5";
            label5.Size = new Size(183, 20);
            label5.TabIndex = 24;
            label5.Text = "CONFIRMAR SENHA:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(11, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 228);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(487, 296);
            button1.Name = "button1";
            button1.Size = new Size(128, 37);
            button1.TabIndex = 22;
            button1.Text = "CANCELAR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.fecharForm;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(294, 296);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(138, 37);
            btnAtualizar.TabIndex = 21;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.TextAlign = ContentAlignment.MiddleRight;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += AtualizarUsuario;
            // 
            // txbEditarSenha
            // 
            txbEditarSenha.Location = new Point(230, 171);
            txbEditarSenha.Multiline = true;
            txbEditarSenha.Name = "txbEditarSenha";
            txbEditarSenha.Size = new Size(251, 28);
            txbEditarSenha.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 148);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 19;
            label6.Text = "SENHA:";
            // 
            // txbEditarEmail
            // 
            txbEditarEmail.Location = new Point(230, 109);
            txbEditarEmail.Multiline = true;
            txbEditarEmail.Name = "txbEditarEmail";
            txbEditarEmail.Size = new Size(251, 28);
            txbEditarEmail.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 86);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 17;
            label7.Text = "E-MAIL:";
            // 
            // comboBoxTipo1
            // 
            comboBoxTipo1.FormattingEnabled = true;
            comboBoxTipo1.Location = new Point(487, 109);
            comboBoxTipo1.Name = "comboBoxTipo1";
            comboBoxTipo1.Size = new Size(172, 28);
            comboBoxTipo1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 86);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 15;
            label8.Text = "TIPO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 18);
            label9.Name = "label9";
            label9.Size = new Size(176, 20);
            label9.TabIndex = 14;
            label9.Text = "NOME DO USUÁRIO:";
            // 
            // txbEditarNomeUser
            // 
            txbEditarNomeUser.Location = new Point(230, 41);
            txbEditarNomeUser.Multiline = true;
            txbEditarNomeUser.Name = "txbEditarNomeUser";
            txbEditarNomeUser.Size = new Size(429, 28);
            txbEditarNomeUser.TabIndex = 13;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 394);
            Controls.Add(tabUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Usuario";
            Text = "Usuario";
            Load += configFormUsuario;
            tabUsuario.ResumeLayout(false);
            tabNovo.ResumeLayout(false);
            tabNovo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPesquisar.ResumeLayout(false);
            tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabUsuario;
        private TabPage tabNovo;
        private TabPage tabPesquisar;
        private TabPage tabEditar;
        private TextBox txbNomeUser;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxTipo;
        private Label labelTipo;
        private TextBox txbSenhaUser;
        private Label label4;
        private TextBox txbEmail;
        private Button btnCancelarUser;
        private Button btnCadastrarUser;
        private DataGridView dataGridViewUser;
        private Button btnPesquisaUser;
        private TextBox txbPesquisaUser;
        private Label txtUser;
        private DataGridViewTextBoxColumn colunaid;
        private DataGridViewTextBoxColumn colunaCategoria;
        private DataGridViewTextBoxColumn colunaEmail;
        private DataGridViewTextBoxColumn columnTipoUser;
        private PictureBox pictureBox1;
        private TextBox txbConfirmarSenha;
        private Label label2;
        private TextBox txbEditarConfir;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button1;
        private Button btnAtualizar;
        private TextBox txbEditarSenha;
        private Label label6;
        private TextBox txbEditarEmail;
        private Label label7;
        private ComboBox comboBoxTipo1;
        private Label label8;
        private Label label9;
        private TextBox txbEditarNomeUser;
    }
}