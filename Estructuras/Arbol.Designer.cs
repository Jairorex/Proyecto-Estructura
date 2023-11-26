namespace Estructuras
{
    partial class Arbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arbol));
            panel1 = new Panel();
            label2 = new Label();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtArbol = new TextBox();
            btnAgregar = new Button();
            txtDato = new TextBox();
            label1 = new Label();
            btnImp = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 126);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(648, 84);
            label2.TabIndex = 0;
            label2.Text = "Ejercicio 12 de la Guia de Arboles Binarios:\r\n \r\nImplementa un árbol binario para buscar el menor dato contenido en un nodo y borrarlo.\r\nFuncionalidad: Insertar, buscar, eliminar e imprimir.";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(4, 41, 68);
            btnEliminar.FlatAppearance.BorderColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(20, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 41);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar Menor";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(4, 41, 68);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(144, 114);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 36);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtArbol
            // 
            txtArbol.BackColor = SystemColors.Window;
            txtArbol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtArbol.Location = new Point(30, 45);
            txtArbol.Multiline = true;
            txtArbol.Name = "txtArbol";
            txtArbol.ReadOnly = true;
            txtArbol.Size = new Size(307, 141);
            txtArbol.TabIndex = 13;
            txtArbol.KeyPress += txtArbol_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(4, 41, 68);
            btnAgregar.FlatAppearance.BorderColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(20, 114);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 36);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDato
            // 
            txtDato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDato.Location = new Point(144, 42);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(75, 23);
            txtDato.TabIndex = 10;
            txtDato.KeyPress += txtDato_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(111, 14);
            label1.TabIndex = 9;
            label1.Text = "Ingrese un dato";
            // 
            // btnImp
            // 
            btnImp.BackColor = Color.FromArgb(4, 41, 68);
            btnImp.FlatAppearance.BorderColor = Color.White;
            btnImp.FlatStyle = FlatStyle.Flat;
            btnImp.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImp.ForeColor = SystemColors.Control;
            btnImp.Location = new Point(144, 170);
            btnImp.Name = "btnImp";
            btnImp.Size = new Size(75, 41);
            btnImp.TabIndex = 16;
            btnImp.Text = "Imprimir";
            btnImp.UseVisualStyleBackColor = false;
            btnImp.Click += btnImp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnImp);
            groupBox1.Controls.Add(txtDato);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(25, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 242);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtArbol);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(305, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 242);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // Arbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 41, 68);
            ClientSize = new Size(690, 413);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Arbol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Árbol";
           // Load += Inicio_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtArbol;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtDato;
        private Label label1;
        private Button btnImp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}