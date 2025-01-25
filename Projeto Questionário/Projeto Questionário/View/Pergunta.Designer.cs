namespace Projeto_Questionário.View
{
    partial class Pergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta));
            tabPergunta = new TabControl();
            abaCadastro = new TabPage();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txbAlter4 = new RichTextBox();
            label6 = new Label();
            txbAlter3 = new RichTextBox();
            label4 = new Label();
            txbAlter2 = new RichTextBox();
            label3 = new Label();
            txbAlter1 = new RichTextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            txbPergunta = new RichTextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            txbResposta = new RichTextBox();
            abaPesquisa = new TabPage();
            btnPesquisaUser = new Button();
            txbPesquisaPergunta = new TextBox();
            txtPergunta = new Label();
            dataGridViewPergunta = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnPergunta = new DataGridViewTextBoxColumn();
            ColumnResposta = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            abaEditar = new TabPage();
            groupBox6 = new GroupBox();
            label14 = new Label();
            rtbEditarResposta = new RichTextBox();
            button1 = new Button();
            btnAtualizar = new Button();
            groupBox5 = new GroupBox();
            label10 = new Label();
            rtbEditarAlter4 = new RichTextBox();
            label11 = new Label();
            rtbEditarAlter3 = new RichTextBox();
            label12 = new Label();
            rtbEditarAlter2 = new RichTextBox();
            label13 = new Label();
            rtbEditarAlter1 = new RichTextBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            comboBoxEditarCategoria = new ComboBox();
            label9 = new Label();
            rtbEditarPergunta = new RichTextBox();
            tabPergunta.SuspendLayout();
            abaCadastro.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            abaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPergunta).BeginInit();
            abaEditar.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPergunta
            // 
            tabPergunta.Controls.Add(abaCadastro);
            tabPergunta.Controls.Add(abaPesquisa);
            tabPergunta.Controls.Add(abaEditar);
            tabPergunta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPergunta.Location = new Point(1, 2);
            tabPergunta.Name = "tabPergunta";
            tabPergunta.SelectedIndex = 0;
            tabPergunta.Size = new Size(866, 526);
            tabPergunta.TabIndex = 0;
            // 
            // abaCadastro
            // 
            abaCadastro.Controls.Add(btnCancelar);
            abaCadastro.Controls.Add(btnCadastrar);
            abaCadastro.Controls.Add(groupBox2);
            abaCadastro.Controls.Add(groupBox1);
            abaCadastro.Controls.Add(groupBox3);
            abaCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abaCadastro.Location = new Point(4, 30);
            abaCadastro.Name = "abaCadastro";
            abaCadastro.Padding = new Padding(3);
            abaCadastro.Size = new Size(858, 492);
            abaCadastro.TabIndex = 0;
            abaCadastro.Text = "NOVA PERGUNTA";
            abaCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century", 12F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(721, 411);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Century", 12F);
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(528, 411);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 37);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += novaPergunta;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txbAlter4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txbAlter3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txbAlter2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txbAlter1);
            groupBox2.Location = new Point(6, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(848, 217);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados das Alternativas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(508, 113);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 9;
            label5.Text = "ALTERNATIVA 04";
            // 
            // txbAlter4
            // 
            txbAlter4.Location = new Point(508, 136);
            txbAlter4.Name = "txbAlter4";
            txbAlter4.Size = new Size(323, 55);
            txbAlter4.TabIndex = 8;
            txbAlter4.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 113);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 7;
            label6.Text = "ALTERNATIVA 03";
            // 
            // txbAlter3
            // 
            txbAlter3.Location = new Point(17, 136);
            txbAlter3.Name = "txbAlter3";
            txbAlter3.Size = new Size(323, 55);
            txbAlter3.TabIndex = 6;
            txbAlter3.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(508, 22);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 5;
            label4.Text = "ALTERNATIVA 02";
            // 
            // txbAlter2
            // 
            txbAlter2.Location = new Point(508, 45);
            txbAlter2.Name = "txbAlter2";
            txbAlter2.Size = new Size(323, 55);
            txbAlter2.TabIndex = 4;
            txbAlter2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 22);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 3;
            label3.Text = "ALTERNATIVA 01";
            // 
            // txbAlter1
            // 
            txbAlter1.Location = new Point(17, 45);
            txbAlter1.Name = "txbAlter1";
            txbAlter1.Size = new Size(323, 55);
            txbAlter1.TabIndex = 2;
            txbAlter1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txbPergunta);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Pergunta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 20);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIA";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.Font = new Font("Century", 12F);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(623, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 1;
            label1.Text = "PERGUNTA";
            // 
            // txbPergunta
            // 
            txbPergunta.Location = new Point(6, 43);
            txbPergunta.Name = "txbPergunta";
            txbPergunta.Size = new Size(603, 73);
            txbPergunta.TabIndex = 0;
            txbPergunta.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txbResposta);
            groupBox3.Location = new Point(7, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(505, 116);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados da resposta correta - Valor exatamente igual a alternativa correta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 22);
            label7.Name = "label7";
            label7.Size = new Size(78, 16);
            label7.TabIndex = 1;
            label7.Text = "RESPOSTA";
            // 
            // txbResposta
            // 
            txbResposta.Location = new Point(7, 41);
            txbResposta.Name = "txbResposta";
            txbResposta.Size = new Size(480, 69);
            txbResposta.TabIndex = 0;
            txbResposta.Text = "";
            // 
            // abaPesquisa
            // 
            abaPesquisa.Controls.Add(btnPesquisaUser);
            abaPesquisa.Controls.Add(txbPesquisaPergunta);
            abaPesquisa.Controls.Add(txtPergunta);
            abaPesquisa.Controls.Add(dataGridViewPergunta);
            abaPesquisa.Location = new Point(4, 30);
            abaPesquisa.Name = "abaPesquisa";
            abaPesquisa.Padding = new Padding(3);
            abaPesquisa.Size = new Size(858, 492);
            abaPesquisa.TabIndex = 1;
            abaPesquisa.Text = "PESQUISAR";
            abaPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaUser
            // 
            btnPesquisaUser.BackColor = Color.DarkGray;
            btnPesquisaUser.Image = (Image)resources.GetObject("btnPesquisaUser.Image");
            btnPesquisaUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisaUser.Location = new Point(724, 25);
            btnPesquisaUser.Name = "btnPesquisaUser";
            btnPesquisaUser.Size = new Size(119, 35);
            btnPesquisaUser.TabIndex = 13;
            btnPesquisaUser.Text = "BUSCAR";
            btnPesquisaUser.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisaUser.UseVisualStyleBackColor = false;
            btnPesquisaUser.Click += listaPerguntas;
            // 
            // txbPesquisaPergunta
            // 
            txbPesquisaPergunta.BorderStyle = BorderStyle.FixedSingle;
            txbPesquisaPergunta.Location = new Point(108, 25);
            txbPesquisaPergunta.Multiline = true;
            txbPesquisaPergunta.Name = "txbPesquisaPergunta";
            txbPesquisaPergunta.Size = new Size(597, 35);
            txbPesquisaPergunta.TabIndex = 12;
            // 
            // txtPergunta
            // 
            txtPergunta.AutoSize = true;
            txtPergunta.Location = new Point(11, 32);
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new Size(91, 21);
            txtPergunta.TabIndex = 11;
            txtPergunta.Text = "PERGUNTA:";
            // 
            // dataGridViewPergunta
            // 
            dataGridViewPergunta.AllowUserToAddRows = false;
            dataGridViewPergunta.AllowUserToDeleteRows = false;
            dataGridViewPergunta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPergunta.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPergunta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPergunta.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnPergunta, ColumnResposta, ColumnCategoria });
            dataGridViewPergunta.Location = new Point(11, 77);
            dataGridViewPergunta.Name = "dataGridViewPergunta";
            dataGridViewPergunta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPergunta.Size = new Size(832, 403);
            dataGridViewPergunta.TabIndex = 0;
            dataGridViewPergunta.CellClick += selecionaLinha;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            // 
            // ColumnPergunta
            // 
            ColumnPergunta.HeaderText = "PERGUNTA";
            ColumnPergunta.Name = "ColumnPergunta";
            // 
            // ColumnResposta
            // 
            ColumnResposta.HeaderText = "RESPOSTA";
            ColumnResposta.Name = "ColumnResposta";
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "CATEGORIA";
            ColumnCategoria.Name = "ColumnCategoria";
            // 
            // abaEditar
            // 
            abaEditar.Controls.Add(groupBox6);
            abaEditar.Controls.Add(button1);
            abaEditar.Controls.Add(btnAtualizar);
            abaEditar.Controls.Add(groupBox5);
            abaEditar.Controls.Add(groupBox4);
            abaEditar.Location = new Point(4, 30);
            abaEditar.Name = "abaEditar";
            abaEditar.Padding = new Padding(3);
            abaEditar.Size = new Size(858, 492);
            abaEditar.TabIndex = 2;
            abaEditar.Text = "EDITAR";
            abaEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(rtbEditarResposta);
            groupBox6.Location = new Point(5, 370);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(519, 116);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Dados da resposta correta - Valor exatamente igual a alternativa correta";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(7, 22);
            label14.Name = "label14";
            label14.Size = new Size(78, 16);
            label14.TabIndex = 1;
            label14.Text = "RESPOSTA";
            // 
            // rtbEditarResposta
            // 
            rtbEditarResposta.Location = new Point(7, 41);
            rtbEditarResposta.Name = "rtbEditarResposta";
            rtbEditarResposta.Size = new Size(480, 69);
            rtbEditarResposta.TabIndex = 0;
            rtbEditarResposta.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Century", 12F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(719, 411);
            button1.Name = "button1";
            button1.Size = new Size(127, 37);
            button1.TabIndex = 8;
            button1.Text = "CANCELAR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Century", 12F);
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(542, 411);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(137, 37);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.TextAlign = ContentAlignment.MiddleRight;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += atualizaPerguntas;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(rtbEditarAlter4);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(rtbEditarAlter3);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(rtbEditarAlter2);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(rtbEditarAlter1);
            groupBox5.Location = new Point(5, 138);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(848, 217);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dados das Alternativas:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(508, 113);
            label10.Name = "label10";
            label10.Size = new Size(127, 21);
            label10.TabIndex = 9;
            label10.Text = "ALTERNATIVA 04";
            // 
            // rtbEditarAlter4
            // 
            rtbEditarAlter4.Location = new Point(508, 136);
            rtbEditarAlter4.Name = "rtbEditarAlter4";
            rtbEditarAlter4.Size = new Size(323, 55);
            rtbEditarAlter4.TabIndex = 8;
            rtbEditarAlter4.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 113);
            label11.Name = "label11";
            label11.Size = new Size(127, 21);
            label11.TabIndex = 7;
            label11.Text = "ALTERNATIVA 03";
            // 
            // rtbEditarAlter3
            // 
            rtbEditarAlter3.Location = new Point(17, 136);
            rtbEditarAlter3.Name = "rtbEditarAlter3";
            rtbEditarAlter3.Size = new Size(323, 55);
            rtbEditarAlter3.TabIndex = 6;
            rtbEditarAlter3.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(508, 22);
            label12.Name = "label12";
            label12.Size = new Size(127, 21);
            label12.TabIndex = 5;
            label12.Text = "ALTERNATIVA 02";
            // 
            // rtbEditarAlter2
            // 
            rtbEditarAlter2.Location = new Point(508, 45);
            rtbEditarAlter2.Name = "rtbEditarAlter2";
            rtbEditarAlter2.Size = new Size(323, 55);
            rtbEditarAlter2.TabIndex = 4;
            rtbEditarAlter2.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 22);
            label13.Name = "label13";
            label13.Size = new Size(127, 21);
            label13.TabIndex = 3;
            label13.Text = "ALTERNATIVA 01";
            // 
            // rtbEditarAlter1
            // 
            rtbEditarAlter1.Location = new Point(17, 45);
            rtbEditarAlter1.Name = "rtbEditarAlter1";
            rtbEditarAlter1.Size = new Size(323, 55);
            rtbEditarAlter1.TabIndex = 2;
            rtbEditarAlter1.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(comboBoxEditarCategoria);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(rtbEditarPergunta);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(5, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(847, 136);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dados da Pergunta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(618, 20);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 3;
            label8.Text = "CATEGORIA";
            // 
            // comboBoxEditarCategoria
            // 
            comboBoxEditarCategoria.BackColor = SystemColors.Window;
            comboBoxEditarCategoria.Font = new Font("Century", 12F);
            comboBoxEditarCategoria.ForeColor = SystemColors.WindowText;
            comboBoxEditarCategoria.FormattingEnabled = true;
            comboBoxEditarCategoria.Location = new Point(623, 43);
            comboBoxEditarCategoria.Name = "comboBoxEditarCategoria";
            comboBoxEditarCategoria.Size = new Size(218, 28);
            comboBoxEditarCategoria.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 20);
            label9.Name = "label9";
            label9.Size = new Size(88, 21);
            label9.TabIndex = 1;
            label9.Text = "PERGUNTA";
            // 
            // rtbEditarPergunta
            // 
            rtbEditarPergunta.Location = new Point(6, 43);
            rtbEditarPergunta.Name = "rtbEditarPergunta";
            rtbEditarPergunta.Size = new Size(603, 73);
            rtbEditarPergunta.TabIndex = 0;
            rtbEditarPergunta.Text = "";
            // 
            // Pergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 524);
            Controls.Add(tabPergunta);
            Name = "Pergunta";
            Text = "FORMULÁRIO DE CONTROLE DE PERGUNTAS";
            Load += configForm;
            tabPergunta.ResumeLayout(false);
            abaCadastro.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            abaPesquisa.ResumeLayout(false);
            abaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPergunta).EndInit();
            abaEditar.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPergunta;
        private TabPage abaCadastro;
        private TabPage abaPesquisa;
        private TabPage abaEditar;
        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox txbPergunta;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label3;
        private RichTextBox txbAlter1;
        private Label label2;
        private Label label4;
        private RichTextBox txbAlter2;
        private Label label5;
        private RichTextBox txbAlter4;
        private Label label6;
        private RichTextBox txbAlter3;
        private GroupBox groupBox3;
        private RichTextBox txbResposta;
        private Label label7;
        private Button btnCancelar;
        private Button btnCadastrar;
        private DataGridView dataGridViewPergunta;
        private Button btnPesquisaUser;
        private TextBox txbPesquisaPergunta;
        private Label txtPergunta;
        private GroupBox groupBox4;
        private Label label8;
        private ComboBox comboBoxEditarCategoria;
        private Label label9;
        private RichTextBox rtbEditarPergunta;
        private GroupBox groupBox6;
        private Label label14;
        private RichTextBox rtbEditarResposta;
        private Button button1;
        private Button btnAtualizar;
        private GroupBox groupBox5;
        private Label label10;
        private RichTextBox rtbEditarAlter4;
        private Label label11;
        private RichTextBox rtbEditarAlter3;
        private Label label12;
        private RichTextBox rtbEditarAlter2;
        private Label label13;
        private RichTextBox rtbEditarAlter1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnPergunta;
        private DataGridViewTextBoxColumn ColumnResposta;
        private DataGridViewTextBoxColumn ColumnCategoria;
    }
}