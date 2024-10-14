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
            tabPerguntas = new TabControl();
            abaCadastro = new TabPage();
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
            abaPesquisa = new TabPage();
            abaEditar = new TabPage();
            groupBox3 = new GroupBox();
            label7 = new Label();
            txbResposta = new RichTextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            tabPerguntas.SuspendLayout();
            abaCadastro.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPerguntas
            // 
            tabPerguntas.Controls.Add(abaCadastro);
            tabPerguntas.Controls.Add(abaPesquisa);
            tabPerguntas.Controls.Add(abaEditar);
            tabPerguntas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPerguntas.Location = new Point(1, 2);
            tabPerguntas.Name = "tabPerguntas";
            tabPerguntas.SelectedIndex = 0;
            tabPerguntas.Size = new Size(866, 394);
            tabPerguntas.TabIndex = 0;
            // 
            // abaCadastro
            // 
            abaCadastro.Controls.Add(groupBox2);
            abaCadastro.Controls.Add(groupBox1);
            abaCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abaCadastro.Location = new Point(4, 30);
            abaCadastro.Name = "abaCadastro";
            abaCadastro.Padding = new Padding(3);
            abaCadastro.Size = new Size(858, 360);
            abaCadastro.TabIndex = 0;
            abaCadastro.Text = "NOVA PERGUNTA";
            abaCadastro.UseVisualStyleBackColor = true;
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
            label2.Location = new Point(638, 20);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(643, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 25);
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
            txbPergunta.Size = new Size(615, 73);
            txbPergunta.TabIndex = 0;
            txbPergunta.Text = "";
            // 
            // abaPesquisa
            // 
            abaPesquisa.Location = new Point(4, 30);
            abaPesquisa.Name = "abaPesquisa";
            abaPesquisa.Padding = new Padding(3);
            abaPesquisa.Size = new Size(858, 360);
            abaPesquisa.TabIndex = 1;
            abaPesquisa.Text = "PESQUISAR";
            abaPesquisa.UseVisualStyleBackColor = true;
            // 
            // abaEditar
            // 
            abaEditar.Location = new Point(4, 30);
            abaEditar.Name = "abaEditar";
            abaEditar.Padding = new Padding(3);
            abaEditar.Size = new Size(858, 360);
            abaEditar.TabIndex = 2;
            abaEditar.Text = "EDITAR";
            abaEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txbResposta);
            groupBox3.Location = new Point(5, 402);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 119);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados da resposta correta - Valor exatamente igual a alternativa correta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 20);
            label7.Name = "label7";
            label7.Size = new Size(78, 16);
            label7.TabIndex = 1;
            label7.Text = "RESPOSTA";
            // 
            // txbResposta
            // 
            txbResposta.Location = new Point(7, 41);
            txbResposta.Name = "txbResposta";
            txbResposta.Size = new Size(423, 69);
            txbResposta.TabIndex = 0;
            txbResposta.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century", 12F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(688, 444);
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
            btnCadastrar.Location = new Point(495, 444);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 37);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += novaPergunta;
            // 
            // Pergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 524);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox3);
            Controls.Add(tabPerguntas);
            Name = "Pergunta";
            Text = "FORMULÁRIO DE CONTROLE DE PERGUNTAS";
            Load += configForm;
            tabPerguntas.ResumeLayout(false);
            abaCadastro.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPerguntas;
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
    }
}