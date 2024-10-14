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
            tabUsuarios = new TabControl();
            tabNovoUsaurio = new TabPage();
            tabEditarUsuario = new TabPage();
            tabPesqUsuario = new TabPage();
            tabUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // tabUsuarios
            // 
            tabUsuarios.Controls.Add(tabNovoUsaurio);
            tabUsuarios.Controls.Add(tabPesqUsuario);
            tabUsuarios.Controls.Add(tabEditarUsuario);
            tabUsuarios.Font = new Font("Segoe UI", 12F);
            tabUsuarios.Location = new Point(0, -1);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.SelectedIndex = 0;
            tabUsuarios.Size = new Size(872, 522);
            tabUsuarios.TabIndex = 0;
            // 
            // tabNovoUsaurio
            // 
            tabNovoUsaurio.Location = new Point(4, 30);
            tabNovoUsaurio.Name = "tabNovoUsaurio";
            tabNovoUsaurio.Padding = new Padding(3);
            tabNovoUsaurio.Size = new Size(864, 488);
            tabNovoUsaurio.TabIndex = 0;
            tabNovoUsaurio.Text = "NOVO USUÁRIO";
            tabNovoUsaurio.UseVisualStyleBackColor = true;
            // 
            // tabEditarUsuario
            // 
            tabEditarUsuario.Location = new Point(4, 30);
            tabEditarUsuario.Name = "tabEditarUsuario";
            tabEditarUsuario.Padding = new Padding(3);
            tabEditarUsuario.Size = new Size(864, 488);
            tabEditarUsuario.TabIndex = 1;
            tabEditarUsuario.Text = "EDITAR USUÁRIO";
            tabEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // tabPesqUsuario
            // 
            tabPesqUsuario.Location = new Point(4, 30);
            tabPesqUsuario.Name = "tabPesqUsuario";
            tabPesqUsuario.Padding = new Padding(3);
            tabPesqUsuario.Size = new Size(864, 488);
            tabPesqUsuario.TabIndex = 2;
            tabPesqUsuario.Text = "PESQUISAR";
            tabPesqUsuario.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 524);
            Controls.Add(tabUsuarios);
            Name = "Usuario";
            Text = "FORMULÁRIO DE CONTROLE DE USUÁRIOS";
            tabUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabUsuarios;
        private TabPage tabNovoUsaurio;
        private TabPage tabEditarUsuario;
        private TabPage tabPesqUsuario;
    }
}