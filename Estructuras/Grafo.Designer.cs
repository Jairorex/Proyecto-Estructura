namespace Estructuras
{
    partial class Grafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafo));
            btnCrear = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            txtVertice = new TextBox();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtImprimir = new TextBox();
            txtEliminar = new TextBox();
            txtVerticead = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            btnBuscar = new Button();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.FlatAppearance.BorderColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = SystemColors.Control;
            btnCrear.Location = new Point(350, 52);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 28);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(350, 158);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 28);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatAppearance.BorderColor = Color.White;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = SystemColors.Control;
            btnImprimir.Location = new Point(341, 245);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 30);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Impimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtVertice
            // 
            txtVertice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtVertice.Location = new Point(229, 57);
            txtVertice.Name = "txtVertice";
            txtVertice.Size = new Size(88, 23);
            txtVertice.TabIndex = 4;
            txtVertice.KeyPress += txtVertice_KeyPress;
            // 
            // txtOrigen
            // 
            txtOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrigen.Location = new Point(95, 114);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(71, 23);
            txtOrigen.TabIndex = 5;
            txtOrigen.KeyPress += txtVertice_KeyPress;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDestino.Location = new Point(250, 114);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(67, 23);
            txtDestino.TabIndex = 6;
            txtDestino.KeyPress += txtVertice_KeyPress;
            // 
            // txtImprimir
            // 
            txtImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtImprimir.Location = new Point(28, 76);
            txtImprimir.Multiline = true;
            txtImprimir.Name = "txtImprimir";
            txtImprimir.Size = new Size(398, 141);
            txtImprimir.TabIndex = 7;
            // 
            // txtEliminar
            // 
            txtEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEliminar.Location = new Point(177, 163);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(140, 23);
            txtEliminar.TabIndex = 8;
            txtEliminar.KeyPress += txtVertice_KeyPress;
            // 
            // txtVerticead
            // 
            txtVerticead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtVerticead.Location = new Point(207, 217);
            txtVerticead.Name = "txtVerticead";
            txtVerticead.Size = new Size(110, 23);
            txtVerticead.TabIndex = 9;
            txtVerticead.KeyPress += txtVertice_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 114);
            panel1.TabIndex = 10;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(667, 93);
            label9.TabIndex = 2;
            label9.Text = "Ejercicio 2 de la Guia de Grafos con Lista Adyacente:\r\n\r\nDado un vértice o nodo verifique sí existe e imprima todos los nodos adyacentes, contenidos \r\nen su lista. (En caso que tenga)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 58);
            label1.Name = "label1";
            label1.Size = new Size(195, 17);
            label1.TabIndex = 11;
            label1.Text = "Digite la Cantidad de  Vertices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(16, 117);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 12;
            label2.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(186, 117);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 13;
            label3.Text = "Destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(16, 168);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 14;
            label4.Text = "Eliminar Arista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(16, 220);
            label5.Name = "label5";
            label5.Size = new Size(185, 17);
            label5.TabIndex = 15;
            label5.Text = "Encontrar Nodos Adyacentes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtVertice);
            groupBox1.Controls.Add(txtOrigen);
            groupBox1.Controls.Add(txtVerticead);
            groupBox1.Controls.Add(txtDestino);
            groupBox1.Controls.Add(txtEliminar);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 321);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(350, 106);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 31);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(350, 212);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 28);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtImprimir);
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(485, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 321);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida ";
            // 
            // Grafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 41, 68);
            ClientSize = new Size(941, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Grafo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafo";
            //Load += Grafo_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnEliminar;
        private Button btnImprimir;
        private TextBox txtVertice;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtImprimir;
        private TextBox txtEliminar;
        private TextBox txtVerticead;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Button btnAgregar;
    }
}