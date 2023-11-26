namespace Estructuras
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnArboles = new Button();
            btnGrafo = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(283, 91);
            label1.Name = "label1";
            label1.Size = new Size(408, 32);
            label1.TabIndex = 0;
            label1.Text = "Implementacion de Árbol y Grafos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnArboles
            // 
            btnArboles.FlatStyle = FlatStyle.Flat;
            btnArboles.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnArboles.ForeColor = SystemColors.Control;
            btnArboles.Image = (Image)resources.GetObject("btnArboles.Image");
            btnArboles.ImageAlign = ContentAlignment.MiddleLeft;
            btnArboles.Location = new Point(108, 280);
            btnArboles.Name = "btnArboles";
            btnArboles.Size = new Size(169, 76);
            btnArboles.TabIndex = 3;
            btnArboles.Text = "         Árbol";
            btnArboles.UseVisualStyleBackColor = true;
            btnArboles.Click += btnArboles_Click;
            // 
            // btnGrafo
            // 
            btnGrafo.FlatStyle = FlatStyle.Flat;
            btnGrafo.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGrafo.ForeColor = SystemColors.Control;
            btnGrafo.Image = (Image)resources.GetObject("btnGrafo.Image");
            btnGrafo.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrafo.Location = new Point(522, 280);
            btnGrafo.Name = "btnGrafo";
            btnGrafo.Size = new Size(169, 76);
            btnGrafo.TabIndex = 4;
            btnGrafo.Text = "      Grafo";
            btnGrafo.UseVisualStyleBackColor = true;
            btnGrafo.Click += btnGrafo_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(638, 391);
            label3.Name = "label3";
            label3.Size = new Size(153, 29);
            label3.TabIndex = 0;
            label3.Text = "Autor: Jairo Narvaez";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(285, 36);
            label2.Name = "label2";
            label2.Size = new Size(406, 32);
            label2.TabIndex = 0;
            label2.Text = "Proyecto de Estructura de Datos II";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 41, 68);
            ClientSize = new Size(786, 414);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnGrafo);
            Controls.Add(btnArboles);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnArboles;
        private Button btnGrafo;
        private Label label3;
        private Label label2;
    }
}