namespace Jogo_Pedra_Papel_Tesoura
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_CPU = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.label_player1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_cpu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.img_player1 = new System.Windows.Forms.PictureBox();
            this.btn_tesoura = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_pedra = new System.Windows.Forms.Button();
            this.label_fimdejogo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_cpu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_player1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_fimdejogo);
            this.splitContainer1.Panel1.Controls.Add(this.label_CPU);
            this.splitContainer1.Panel1.Controls.Add(this.label_resultado);
            this.splitContainer1.Panel1.Controls.Add(this.label_player1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_tesoura);
            this.splitContainer1.Panel2.Controls.Add(this.btn_papel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_pedra);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_CPU
            // 
            this.label_CPU.AutoSize = true;
            this.label_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPU.Location = new System.Drawing.Point(503, 24);
            this.label_CPU.Name = "label_CPU";
            this.label_CPU.Size = new System.Drawing.Size(49, 54);
            this.label_CPU.TabIndex = 5;
            this.label_CPU.Text = "0";
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(201, 136);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(219, 39);
            this.label_resultado.TabIndex = 4;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_player1
            // 
            this.label_player1.AutoSize = true;
            this.label_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_player1.Location = new System.Drawing.Point(74, 24);
            this.label_player1.Name = "label_player1";
            this.label_player1.Size = new System.Drawing.Size(49, 54);
            this.label_player1.TabIndex = 2;
            this.label_player1.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.img_cpu);
            this.groupBox2.Location = new System.Drawing.Point(426, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU";
            // 
            // img_cpu
            // 
            this.img_cpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_cpu.Location = new System.Drawing.Point(3, 53);
            this.img_cpu.Name = "img_cpu";
            this.img_cpu.Size = new System.Drawing.Size(186, 154);
            this.img_cpu.TabIndex = 1;
            this.img_cpu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.img_player1);
            this.groupBox1.Location = new System.Drawing.Point(3, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // img_player1
            // 
            this.img_player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_player1.Location = new System.Drawing.Point(6, 53);
            this.img_player1.Name = "img_player1";
            this.img_player1.Size = new System.Drawing.Size(186, 154);
            this.img_player1.TabIndex = 0;
            this.img_player1.TabStop = false;
            // 
            // btn_tesoura
            // 
            this.btn_tesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tesoura.BackgroundImage")));
            this.btn_tesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_tesoura.Location = new System.Drawing.Point(426, 0);
            this.btn_tesoura.Name = "btn_tesoura";
            this.btn_tesoura.Size = new System.Drawing.Size(198, 163);
            this.btn_tesoura.TabIndex = 2;
            this.btn_tesoura.UseVisualStyleBackColor = true;
            this.btn_tesoura.Click += new System.EventHandler(this.btn_tesoura_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_papel.BackgroundImage")));
            this.btn_papel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_papel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_papel.Location = new System.Drawing.Point(213, 0);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(213, 163);
            this.btn_papel.TabIndex = 1;
            this.btn_papel.UseVisualStyleBackColor = true;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_pedra
            // 
            this.btn_pedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pedra.BackgroundImage")));
            this.btn_pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_pedra.Location = new System.Drawing.Point(0, 0);
            this.btn_pedra.Name = "btn_pedra";
            this.btn_pedra.Size = new System.Drawing.Size(213, 163);
            this.btn_pedra.TabIndex = 0;
            this.btn_pedra.UseVisualStyleBackColor = true;
            this.btn_pedra.Click += new System.EventHandler(this.btn_pedra_Click);
            // 
            // label_fimdejogo
            // 
            this.label_fimdejogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fimdejogo.Location = new System.Drawing.Point(201, 185);
            this.label_fimdejogo.Name = "label_fimdejogo";
            this.label_fimdejogo.Size = new System.Drawing.Size(219, 39);
            this.label_fimdejogo.TabIndex = 6;
            this.label_fimdejogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel Tesoura";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_cpu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_player1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_tesoura;
        private System.Windows.Forms.Button btn_papel;
        private System.Windows.Forms.Button btn_pedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox img_cpu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox img_player1;
        private System.Windows.Forms.Label label_CPU;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Label label_player1;
        private System.Windows.Forms.Label label_fimdejogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

