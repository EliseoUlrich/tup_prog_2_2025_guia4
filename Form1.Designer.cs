namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBorrar = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrarPresu = new System.Windows.Forms.Button();
            this.btnIniciarPresu = new System.Windows.Forms.Button();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.rbtMesa = new System.Windows.Forms.RadioButton();
            this.rbtBanco = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBorrar);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnCerrarPresu);
            this.groupBox1.Controls.Add(this.btnIniciarPresu);
            this.groupBox1.Controls.Add(this.tbDir);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbBorrar
            // 
            this.cbBorrar.FormattingEnabled = true;
            this.cbBorrar.Location = new System.Drawing.Point(29, 173);
            this.cbBorrar.Name = "cbBorrar";
            this.cbBorrar.Size = new System.Drawing.Size(121, 21);
            this.cbBorrar.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(184, 171);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrarPresu
            // 
            this.btnCerrarPresu.Location = new System.Drawing.Point(184, 105);
            this.btnCerrarPresu.Name = "btnCerrarPresu";
            this.btnCerrarPresu.Size = new System.Drawing.Size(75, 42);
            this.btnCerrarPresu.TabIndex = 5;
            this.btnCerrarPresu.Text = "Cerrar Presupuesto";
            this.btnCerrarPresu.UseVisualStyleBackColor = true;
            this.btnCerrarPresu.Click += new System.EventHandler(this.btnCerrarPresu_Click);
            // 
            // btnIniciarPresu
            // 
            this.btnIniciarPresu.Location = new System.Drawing.Point(45, 105);
            this.btnIniciarPresu.Name = "btnIniciarPresu";
            this.btnIniciarPresu.Size = new System.Drawing.Size(75, 42);
            this.btnIniciarPresu.TabIndex = 4;
            this.btnIniciarPresu.Text = "Iniciar Presupuesto";
            this.btnIniciarPresu.UseVisualStyleBackColor = true;
            this.btnIniciarPresu.Click += new System.EventHandler(this.btnIniciarPresu_Click);
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(72, 62);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(139, 20);
            this.tbDir.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(73, 31);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(138, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtBanco);
            this.groupBox2.Controls.Add(this.rbtMesa);
            this.groupBox2.Controls.Add(this.tbGrosor);
            this.groupBox2.Controls.Add(this.tbLargo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.tbAncho);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(391, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(214, 66);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(54, 20);
            this.tbGrosor.TabIndex = 3;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(214, 28);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(54, 20);
            this.tbLargo.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Grosor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Largo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(66, 90);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(54, 20);
            this.tbCodigo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Código";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(205, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(66, 62);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(54, 20);
            this.tbAncho.TabIndex = 3;
            this.tbAncho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(66, 28);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(54, 20);
            this.tbPrecio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ancho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio B:";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(432, 212);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(102, 50);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(569, 212);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(102, 50);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // rbtMesa
            // 
            this.rbtMesa.AutoSize = true;
            this.rbtMesa.Location = new System.Drawing.Point(13, 118);
            this.rbtMesa.Name = "rbtMesa";
            this.rbtMesa.Size = new System.Drawing.Size(51, 17);
            this.rbtMesa.TabIndex = 9;
            this.rbtMesa.TabStop = true;
            this.rbtMesa.Text = "Mesa";
            this.rbtMesa.UseVisualStyleBackColor = true;
            // 
            // rbtBanco
            // 
            this.rbtBanco.AutoSize = true;
            this.rbtBanco.Location = new System.Drawing.Point(13, 141);
            this.rbtBanco.Name = "rbtBanco";
            this.rbtBanco.Size = new System.Drawing.Size(56, 17);
            this.rbtBanco.TabIndex = 10;
            this.rbtBanco.TabStop = true;
            this.rbtBanco.Text = "Banco";
            this.rbtBanco.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrarPresu;
        private System.Windows.Forms.Button btnIniciarPresu;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBorrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.RadioButton rbtMesa;
        public System.Windows.Forms.RadioButton rbtBanco;
    }
}

