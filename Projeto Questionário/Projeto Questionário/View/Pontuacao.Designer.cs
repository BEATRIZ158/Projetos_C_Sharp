namespace Projeto_Questionário.View
{
    partial class Pontuacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pontuacao));
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnPesquisaPontuacao = new Button();
            txbUsuarioPont = new TextBox();
            txtUser = new Label();
            dataGridViewPontuacao = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnTotalAcertos = new DataGridViewTextBoxColumn();
            ColumnTotalErros = new DataGridViewTextBoxColumn();
            ColumnData = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPontuacao).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 12F);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 435);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnPesquisaPontuacao);
            tabPage2.Controls.Add(txbUsuarioPont);
            tabPage2.Controls.Add(txtUser);
            tabPage2.Controls.Add(dataGridViewPontuacao);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "PESQUISAR";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaPontuacao
            // 
            btnPesquisaPontuacao.BackColor = Color.DarkGray;
            btnPesquisaPontuacao.Image = (Image)resources.GetObject("btnPesquisaPontuacao.Image");
            btnPesquisaPontuacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisaPontuacao.Location = new Point(628, 15);
            btnPesquisaPontuacao.Name = "btnPesquisaPontuacao";
            btnPesquisaPontuacao.Size = new Size(119, 35);
            btnPesquisaPontuacao.TabIndex = 13;
            btnPesquisaPontuacao.Text = "BUSCAR";
            btnPesquisaPontuacao.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisaPontuacao.UseVisualStyleBackColor = false;
            btnPesquisaPontuacao.Click += listaPontuacao;
            // 
            // txbUsuarioPont
            // 
            txbUsuarioPont.BorderStyle = BorderStyle.FixedSingle;
            txbUsuarioPont.Location = new Point(99, 15);
            txbUsuarioPont.Multiline = true;
            txbUsuarioPont.Name = "txbUsuarioPont";
            txbUsuarioPont.Size = new Size(523, 35);
            txbUsuarioPont.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(13, 20);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(80, 21);
            txtUser.TabIndex = 11;
            txtUser.Text = "USUÁRIO:";
            // 
            // dataGridViewPontuacao
            // 
            dataGridViewPontuacao.AllowUserToAddRows = false;
            dataGridViewPontuacao.AllowUserToDeleteRows = false;
            dataGridViewPontuacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPontuacao.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPontuacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPontuacao.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnNome, ColumnTotalAcertos, ColumnTotalErros, ColumnData });
            dataGridViewPontuacao.Location = new Point(6, 65);
            dataGridViewPontuacao.Name = "dataGridViewPontuacao";
            dataGridViewPontuacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPontuacao.Size = new Size(756, 336);
            dataGridViewPontuacao.TabIndex = 0;
            dataGridViewPontuacao.CellClick += excluirPont;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "NOME";
            ColumnNome.Name = "ColumnNome";
            // 
            // ColumnTotalAcertos
            // 
            ColumnTotalAcertos.HeaderText = "ACERTOS";
            ColumnTotalAcertos.Name = "ColumnTotalAcertos";
            // 
            // ColumnTotalErros
            // 
            ColumnTotalErros.HeaderText = "ERROS";
            ColumnTotalErros.Name = "ColumnTotalErros";
            // 
            // ColumnData
            // 
            ColumnData.HeaderText = "DATA";
            ColumnData.Name = "ColumnData";
            // 
            // Pontuacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Pontuacao";
            Text = "DESEMPENHO";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPontuacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dataGridViewPontuacao;
        private Button btnPesquisaPontuacao;
        private TextBox txbUsuarioPont;
        private Label txtUser;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTotalAcertos;
        private DataGridViewTextBoxColumn ColumnTotalErros;
        private DataGridViewTextBoxColumn ColumnData;
    }
}