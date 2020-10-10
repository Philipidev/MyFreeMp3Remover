namespace RemoverdorMyFreeMP3Core
{
    partial class MyFreeMP3Remover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFreeMP3Remover));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemover = new System.Windows.Forms.TextBox();
            this.txtDuplicado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(15, 22);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(104, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(38, 20);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(235, 15);
            this.lblCaminho.TabIndex = 2;
            this.lblCaminho.Text = "C:\\Users\\phili\\source\\repos\\asdasd\\asdasd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o texto a ser removido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digite o texto duplicado a ser removido:";
            // 
            // txtRemover
            // 
            this.txtRemover.Location = new System.Drawing.Point(15, 132);
            this.txtRemover.Name = "txtRemover";
            this.txtRemover.Size = new System.Drawing.Size(230, 23);
            this.txtRemover.TabIndex = 5;
            // 
            // txtDuplicado
            // 
            this.txtDuplicado.Location = new System.Drawing.Point(15, 193);
            this.txtDuplicado.Name = "txtDuplicado";
            this.txtDuplicado.Size = new System.Drawing.Size(230, 23);
            this.txtDuplicado.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblCaminho);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasta selecionada";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnExecutar);
            this.groupBox2.Controls.Add(this.btnSelecionar);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDuplicado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRemover);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 307);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione a pasta que contem o(s) arquivo(s)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(15, 260);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(230, 32);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // MyFreeMP3Remover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 334);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyFreeMP3Remover";
            this.Text = "MyFreeMP3 Remover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemover;
        private System.Windows.Forms.TextBox txtDuplicado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

