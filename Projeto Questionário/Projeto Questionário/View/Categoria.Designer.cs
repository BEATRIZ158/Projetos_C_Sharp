namespace Projeto_Questionário.View
{
    partial class CATEGORIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CATEGORIA));
            tabCategoria = new TabControl();
            abaNovaCategoria = new TabPage();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            txbNomeCategoria = new TextBox();
            label1 = new Label();
            abaPesquisar = new TabPage();
            dataGridView1 = new DataGridView();
            colunaid = new DataGridViewTextBoxColumn();
            colunaCategoria = new DataGridViewTextBoxColumn();
            btnPesquisaCategoria = new Button();
            txbPesquisaCategoria = new TextBox();
            label2 = new Label();
            abaEditar = new TabPage();
            button1 = new Button();
            btnAtualizaCategoria = new Button();
            txbEditarCategoria = new TextBox();
            label3 = new Label();
            tabCategoria.SuspendLayout();
            abaNovaCategoria.SuspendLayout();
            abaPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            abaEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabCategoria
            // 
            tabCategoria.Controls.Add(abaNovaCategoria);
            tabCategoria.Controls.Add(abaPesquisar);
            tabCategoria.Controls.Add(abaEditar);
            tabCategoria.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabCategoria.Location = new Point(6, 10);
            tabCategoria.Name = "tabCategoria";
            tabCategoria.SelectedIndex = 0;
            tabCategoria.Size = new Size(603, 269);
            tabCategoria.TabIndex = 0;
            // 
            // abaNovaCategoria
            // 
            abaNovaCategoria.Controls.Add(btnCancelar);
            abaNovaCategoria.Controls.Add(btnCadastrar);
            abaNovaCategoria.Controls.Add(txbNomeCategoria);
            abaNovaCategoria.Controls.Add(label1);
            abaNovaCategoria.Location = new Point(4, 29);
            abaNovaCategoria.Name = "abaNovaCategoria";
            abaNovaCategoria.Padding = new Padding(3);
            abaNovaCategoria.Size = new Size(595, 236);
            abaNovaCategoria.TabIndex = 0;
            abaNovaCategoria.Text = "NOVA CATEGORIA";
            abaNovaCategoria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(199, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 37);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += fecharForm;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(6, 140);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(138, 37);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += novaCategoria;
            // 
            // txbNomeCategoria
            // 
            txbNomeCategoria.Location = new Point(6, 67);
            txbNomeCategoria.Multiline = true;
            txbNomeCategoria.Name = "txbNomeCategoria";
            txbNomeCategoria.Size = new Size(491, 41);
            txbNomeCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "NOME CATEGORIA:";
            // 
            // abaPesquisar
            // 
            abaPesquisar.Controls.Add(dataGridView1);
            abaPesquisar.Controls.Add(btnPesquisaCategoria);
            abaPesquisar.Controls.Add(txbPesquisaCategoria);
            abaPesquisar.Controls.Add(label2);
            abaPesquisar.Location = new Point(4, 29);
            abaPesquisar.Name = "abaPesquisar";
            abaPesquisar.Padding = new Padding(3);
            abaPesquisar.Size = new Size(595, 236);
            abaPesquisar.TabIndex = 1;
            abaPesquisar.Text = "PESQUISAR";
            abaPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colunaid, colunaCategoria });
            dataGridView1.Location = new Point(6, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(573, 167);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += selecionaLinha;
            // 
            // colunaid
            // 
            colunaid.HeaderText = "ID";
            colunaid.Name = "colunaid";
            // 
            // colunaCategoria
            // 
            colunaCategoria.HeaderText = "CATEGORIA";
            colunaCategoria.Name = "colunaCategoria";
            // 
            // btnPesquisaCategoria
            // 
            btnPesquisaCategoria.BackColor = Color.DarkGray;
            btnPesquisaCategoria.Image = (Image)resources.GetObject("btnPesquisaCategoria.Image");
            btnPesquisaCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisaCategoria.Location = new Point(460, 8);
            btnPesquisaCategoria.Name = "btnPesquisaCategoria";
            btnPesquisaCategoria.Size = new Size(119, 43);
            btnPesquisaCategoria.TabIndex = 6;
            btnPesquisaCategoria.Text = "BUSCAR";
            btnPesquisaCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisaCategoria.UseVisualStyleBackColor = false;
            btnPesquisaCategoria.Click += listaCategoria;
            // 
            // txbPesquisaCategoria
            // 
            txbPesquisaCategoria.BorderStyle = BorderStyle.FixedSingle;
            txbPesquisaCategoria.Location = new Point(118, 11);
            txbPesquisaCategoria.Multiline = true;
            txbPesquisaCategoria.Name = "txbPesquisaCategoria";
            txbPesquisaCategoria.Size = new Size(336, 35);
            txbPesquisaCategoria.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 4;
            label2.Text = "CATEGORIA:";
            // 
            // abaEditar
            // 
            abaEditar.BackColor = Color.White;
            abaEditar.Controls.Add(button1);
            abaEditar.Controls.Add(btnAtualizaCategoria);
            abaEditar.Controls.Add(txbEditarCategoria);
            abaEditar.Controls.Add(label3);
            abaEditar.Location = new Point(4, 29);
            abaEditar.Name = "abaEditar";
            abaEditar.Padding = new Padding(3);
            abaEditar.Size = new Size(595, 236);
            abaEditar.TabIndex = 2;
            abaEditar.Text = "EDITAR";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(274, 141);
            button1.Name = "button1";
            button1.Size = new Size(128, 37);
            button1.TabIndex = 7;
            button1.Text = "CANCELAR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaCategoria
            // 
            btnAtualizaCategoria.Image = (Image)resources.GetObject("btnAtualizaCategoria.Image");
            btnAtualizaCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizaCategoria.Location = new Point(8, 141);
            btnAtualizaCategoria.Name = "btnAtualizaCategoria";
            btnAtualizaCategoria.Size = new Size(138, 37);
            btnAtualizaCategoria.TabIndex = 6;
            btnAtualizaCategoria.Text = "ATUALIZAR";
            btnAtualizaCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnAtualizaCategoria.UseVisualStyleBackColor = true;
            btnAtualizaCategoria.Click += atualizaCategoria;
            // 
            // txbEditarCategoria
            // 
            txbEditarCategoria.Location = new Point(8, 79);
            txbEditarCategoria.Multiline = true;
            txbEditarCategoria.Name = "txbEditarCategoria";
            txbEditarCategoria.Size = new Size(491, 41);
            txbEditarCategoria.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 42);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 4;
            label3.Text = "NOME CATEGORIA:";
            // 
            // CATEGORIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 291);
            Controls.Add(tabCategoria);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CATEGORIA";
            Text = "CATEGORIA";
            tabCategoria.ResumeLayout(false);
            abaNovaCategoria.ResumeLayout(false);
            abaNovaCategoria.PerformLayout();
            abaPesquisar.ResumeLayout(false);
            abaPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            abaEditar.ResumeLayout(false);
            abaEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCategoria;
        private TabPage abaNovaCategoria;
        private TabPage abaPesquisar;
        private TabPage abaEditar;
        private TextBox txbNomeCategoria;
        private Label label1;
        private Button btnCadastrar;
        private Button btnCancelar;
        private TextBox txbPesquisaCategoria;
        private Label label2;
        private Button btnPesquisaCategoria;
        private Button button1;
        private Button btnAtualizaCategoria;
        private TextBox txbEditarCategoria;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colunaid;
        private DataGridViewTextBoxColumn colunaCategoria;
    }
}