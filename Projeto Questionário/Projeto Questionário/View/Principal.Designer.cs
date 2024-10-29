namespace Projeto_Questionário
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            menuNovo = new ToolStripMenuItem();
            novoCategoria = new ToolStripMenuItem();
            novoPergunta = new ToolStripMenuItem();
            novoUsuario = new ToolStripMenuItem();
            menuEditar = new ToolStripMenuItem();
            editarCategoria = new ToolStripMenuItem();
            editarPergunta = new ToolStripMenuItem();
            editarUsuario = new ToolStripMenuItem();
            menuPesquisar = new ToolStripMenuItem();
            pesqCategoria = new ToolStripMenuItem();
            pesqPergunta = new ToolStripMenuItem();
            pesqPontuacao = new ToolStripMenuItem();
            pesqUsuario = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            novoQuestionario = new ToolStripButton();
            novoAluno = new ToolStripButton();
            novoProfessor = new ToolStripButton();
            novaPergunta = new ToolStripButton();
            verPontos = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuNovo, menuEditar, menuPesquisar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(863, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuNovo
            // 
            menuNovo.DropDownItems.AddRange(new ToolStripItem[] { novoCategoria, novoPergunta, novoUsuario });
            menuNovo.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuNovo.Name = "menuNovo";
            menuNovo.Size = new Size(70, 24);
            menuNovo.Text = "&NOVO";
            // 
            // novoCategoria
            // 
            novoCategoria.Image = (Image)resources.GetObject("novoCategoria.Image");
            novoCategoria.Name = "novoCategoria";
            novoCategoria.ShortcutKeys = Keys.Control | Keys.C;
            novoCategoria.Size = new Size(241, 24);
            novoCategoria.Text = "&CATEGORIA";
            novoCategoria.Click += frmCategoria;
            // 
            // novoPergunta
            // 
            novoPergunta.Image = (Image)resources.GetObject("novoPergunta.Image");
            novoPergunta.Name = "novoPergunta";
            novoPergunta.ShortcutKeys = Keys.Control | Keys.P;
            novoPergunta.Size = new Size(241, 24);
            novoPergunta.Text = "&PERGUNTA";
            // 
            // novoUsuario
            // 
            novoUsuario.Image = (Image)resources.GetObject("novoUsuario.Image");
            novoUsuario.Name = "novoUsuario";
            novoUsuario.ShortcutKeys = Keys.Control | Keys.U;
            novoUsuario.Size = new Size(241, 24);
            novoUsuario.Text = "&USUARIO";
            // 
            // menuEditar
            // 
            menuEditar.DropDownItems.AddRange(new ToolStripItem[] { editarCategoria, editarPergunta, editarUsuario });
            menuEditar.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuEditar.Name = "menuEditar";
            menuEditar.Size = new Size(87, 24);
            menuEditar.Text = "&EDITAR";
            // 
            // editarCategoria
            // 
            editarCategoria.Image = (Image)resources.GetObject("editarCategoria.Image");
            editarCategoria.Name = "editarCategoria";
            editarCategoria.ShortcutKeys = Keys.Alt | Keys.C;
            editarCategoria.Size = new Size(234, 24);
            editarCategoria.Text = "&CATEGORIA";
            // 
            // editarPergunta
            // 
            editarPergunta.Image = (Image)resources.GetObject("editarPergunta.Image");
            editarPergunta.Name = "editarPergunta";
            editarPergunta.ShortcutKeys = Keys.Alt | Keys.E;
            editarPergunta.Size = new Size(234, 24);
            editarPergunta.Text = "P&ERGUNTA";
            // 
            // editarUsuario
            // 
            editarUsuario.Image = (Image)resources.GetObject("editarUsuario.Image");
            editarUsuario.Name = "editarUsuario";
            editarUsuario.ShortcutKeys = Keys.Alt | Keys.U;
            editarUsuario.Size = new Size(234, 24);
            editarUsuario.Text = "&USUARIO";
            // 
            // menuPesquisar
            // 
            menuPesquisar.DropDownItems.AddRange(new ToolStripItem[] { pesqCategoria, pesqPergunta, pesqPontuacao, pesqUsuario });
            menuPesquisar.Name = "menuPesquisar";
            menuPesquisar.Size = new Size(120, 24);
            menuPesquisar.Text = "&PESQUISAR";
            // 
            // pesqCategoria
            // 
            pesqCategoria.Image = (Image)resources.GetObject("pesqCategoria.Image");
            pesqCategoria.Name = "pesqCategoria";
            pesqCategoria.ShortcutKeys = Keys.F6;
            pesqCategoria.Size = new Size(215, 24);
            pesqCategoria.Text = "&CATEGORIA";
            // 
            // pesqPergunta
            // 
            pesqPergunta.Image = (Image)resources.GetObject("pesqPergunta.Image");
            pesqPergunta.Name = "pesqPergunta";
            pesqPergunta.ShortcutKeys = Keys.F7;
            pesqPergunta.Size = new Size(215, 24);
            pesqPergunta.Text = "&PERGUNTA";
            // 
            // pesqPontuacao
            // 
            pesqPontuacao.Image = (Image)resources.GetObject("pesqPontuacao.Image");
            pesqPontuacao.Name = "pesqPontuacao";
            pesqPontuacao.ShortcutKeys = Keys.F8;
            pesqPontuacao.Size = new Size(215, 24);
            pesqPontuacao.Text = "P&ONTUAÇÃO";
            // 
            // pesqUsuario
            // 
            pesqUsuario.Image = (Image)resources.GetObject("pesqUsuario.Image");
            pesqUsuario.Name = "pesqUsuario";
            pesqUsuario.ShortcutKeys = Keys.F9;
            pesqUsuario.Size = new Size(215, 24);
            pesqUsuario.Text = "&USUARIO";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Items.AddRange(new ToolStripItem[] { novoQuestionario, novoAluno, novoProfessor, novaPergunta, verPontos });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(89, 449);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // novoQuestionario
            // 
            novoQuestionario.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            novoQuestionario.Image = (Image)resources.GetObject("novoQuestionario.Image");
            novoQuestionario.ImageAlign = ContentAlignment.TopCenter;
            novoQuestionario.ImageScaling = ToolStripItemImageScaling.None;
            novoQuestionario.ImageTransparentColor = Color.Magenta;
            novoQuestionario.Name = "novoQuestionario";
            novoQuestionario.Size = new Size(86, 84);
            novoQuestionario.Text = "NOVO";
            novoQuestionario.TextAlign = ContentAlignment.BottomCenter;
            novoQuestionario.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // novoAluno
            // 
            novoAluno.Font = new Font("Century", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            novoAluno.Image = (Image)resources.GetObject("novoAluno.Image");
            novoAluno.ImageAlign = ContentAlignment.TopCenter;
            novoAluno.ImageScaling = ToolStripItemImageScaling.None;
            novoAluno.ImageTransparentColor = Color.Magenta;
            novoAluno.Name = "novoAluno";
            novoAluno.Size = new Size(86, 83);
            novoAluno.Text = "NOVO";
            novoAluno.TextAlign = ContentAlignment.BottomCenter;
            novoAluno.TextImageRelation = TextImageRelation.ImageAboveText;
            novoAluno.Click += formUsuario;
            // 
            // novoProfessor
            // 
            novoProfessor.Image = (Image)resources.GetObject("novoProfessor.Image");
            novoProfessor.ImageScaling = ToolStripItemImageScaling.None;
            novoProfessor.ImageTransparentColor = Color.Magenta;
            novoProfessor.Name = "novoProfessor";
            novoProfessor.Size = new Size(86, 83);
            novoProfessor.Text = "NOVO";
            novoProfessor.TextAlign = ContentAlignment.BottomCenter;
            novoProfessor.TextImageRelation = TextImageRelation.ImageAboveText;
            novoProfessor.Click += formUsuario;
            // 
            // novaPergunta
            // 
            novaPergunta.Image = (Image)resources.GetObject("novaPergunta.Image");
            novaPergunta.ImageAlign = ContentAlignment.TopCenter;
            novaPergunta.ImageScaling = ToolStripItemImageScaling.None;
            novaPergunta.ImageTransparentColor = Color.Magenta;
            novaPergunta.Name = "novaPergunta";
            novaPergunta.Size = new Size(86, 83);
            novaPergunta.Text = "NOVA";
            novaPergunta.TextAlign = ContentAlignment.BottomCenter;
            novaPergunta.TextImageRelation = TextImageRelation.ImageAboveText;
            novaPergunta.ToolTipText = "NOVA";
            novaPergunta.Click += formPergunta;
            // 
            // verPontos
            // 
            verPontos.Image = (Image)resources.GetObject("verPontos.Image");
            verPontos.ImageScaling = ToolStripItemImageScaling.None;
            verPontos.ImageTransparentColor = Color.Magenta;
            verPontos.Name = "verPontos";
            verPontos.Size = new Size(86, 83);
            verPontos.Text = "DESEMPENHO";
            verPontos.TextAlign = ContentAlignment.BottomCenter;
            verPontos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 479);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Principal";
            Text = "Form1";
            Load += loadPrincipal;
            Shown += formLogin;
            VisibleChanged += habilitarBotoes;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuNovo;
        private ToolStripMenuItem novoCategoria;
        private ToolStripMenuItem novoPergunta;
        private ToolStripMenuItem novoUsuario;
        private ToolStripMenuItem menuEditar;
        private ToolStripMenuItem editarCategoria;
        private ToolStripMenuItem editarPergunta;
        private ToolStripMenuItem editarUsuario;
        private ToolStripMenuItem menuPesquisar;
        private ToolStripMenuItem pesqCategoria;
        private ToolStripMenuItem pesqPergunta;
        private ToolStripMenuItem pesqPontuacao;
        private ToolStripMenuItem pesqUsuario;
        private ToolStrip toolStrip1;
        private ToolStripButton novoQuestionario;
        private ToolStripButton novoAluno;
        private ToolStripButton novoProfessor;
        private ToolStripButton novaPergunta;
        private ToolStripButton verPontos;
    }
}
