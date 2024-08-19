namespace Projeto1
{
    partial class Form1
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
            btnIr = new Button();
            btnAtencao = new Button();
            btnPare = new Button();
            lbInfo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIr
            // 
            btnIr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIr.BackColor = Color.Lime;
            btnIr.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIr.Location = new Point(33, 278);
            btnIr.Name = "btnIr";
            btnIr.Size = new Size(133, 83);
            btnIr.TabIndex = 0;
            btnIr.Text = "Acelera, vai, acelera!";
            btnIr.UseVisualStyleBackColor = false;
            btnIr.Click += btnIr_click_infoVerde;
            // 
            // btnAtencao
            // 
            btnAtencao.BackColor = Color.Yellow;
            btnAtencao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtencao.Location = new Point(33, 167);
            btnAtencao.Name = "btnAtencao";
            btnAtencao.Size = new Size(133, 83);
            btnAtencao.TabIndex = 1;
            btnAtencao.Text = "Olhe para o lado";
            btnAtencao.UseVisualStyleBackColor = false;
            btnAtencao.Click += btnAtencao_click_mudaCor;
            // 
            // btnPare
            // 
            btnPare.BackColor = Color.Red;
            btnPare.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPare.Location = new Point(33, 50);
            btnPare.Name = "btnPare";
            btnPare.Size = new Size(133, 83);
            btnPare.TabIndex = 2;
            btnPare.Text = "Calmo calabreso!";
            btnPare.UseVisualStyleBackColor = false;
            btnPare.Click += btnPare_click_infoVermelho;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(274, 65);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(0, 17);
            lbInfo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(258, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(870, 419);
            Controls.Add(pictureBox1);
            Controls.Add(lbInfo);
            Controls.Add(btnPare);
            Controls.Add(btnAtencao);
            Controls.Add(btnIr);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIr;
        private Button btnAtencao;
        private Button btnPare;
        private Label lbInfo;
        private PictureBox pictureBox1;
    }
}
