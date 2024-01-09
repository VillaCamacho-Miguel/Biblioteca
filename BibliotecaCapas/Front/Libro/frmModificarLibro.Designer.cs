
namespace Biblioteca.Front
{
    partial class frmModificarLibro
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.gbPrestar = new System.Windows.Forms.GroupBox();
            this.cbMaestro = new System.Windows.Forms.CheckBox();
            this.cbAlumno = new System.Windows.Forms.CheckBox();
            this.gbUso = new System.Windows.Forms.GroupBox();
            this.rbExterno = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.gbEditorial = new System.Windows.Forms.GroupBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnBuscarEditorial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbPrestar.SuspendLayout();
            this.gbUso.SuspendLayout();
            this.gbEditorial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(56, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Libro";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExistencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreLibro);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.gbPrestar);
            this.groupBox1.Controls.Add(this.gbUso);
            this.groupBox1.Controls.Add(this.gbEditorial);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Modificacion";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(15, 185);
            this.txtExistencia.MaxLength = 3;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 13;
            this.txtExistencia.TextChanged += new System.EventHandler(this.txtExistencia_TextChanged);
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Existencia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(15, 119);
            this.txtNombreLibro.MaxLength = 30;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLibro.TabIndex = 11;
            this.txtNombreLibro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtNombreLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLibro_KeyPress);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(13, 51);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(111, 20);
            this.txtISBN.TabIndex = 10;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLibro_KeyPress);
            // 
            // gbPrestar
            // 
            this.gbPrestar.Controls.Add(this.cbMaestro);
            this.gbPrestar.Controls.Add(this.cbAlumno);
            this.gbPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbPrestar.Location = new System.Drawing.Point(170, 145);
            this.gbPrestar.Name = "gbPrestar";
            this.gbPrestar.Size = new System.Drawing.Size(207, 100);
            this.gbPrestar.TabIndex = 9;
            this.gbPrestar.TabStop = false;
            this.gbPrestar.Text = "Disponible Para";
            // 
            // cbMaestro
            // 
            this.cbMaestro.AutoSize = true;
            this.cbMaestro.Location = new System.Drawing.Point(23, 66);
            this.cbMaestro.Name = "cbMaestro";
            this.cbMaestro.Size = new System.Drawing.Size(69, 17);
            this.cbMaestro.TabIndex = 1;
            this.cbMaestro.Text = "Maestros";
            this.cbMaestro.UseVisualStyleBackColor = true;
            // 
            // cbAlumno
            // 
            this.cbAlumno.AutoSize = true;
            this.cbAlumno.Location = new System.Drawing.Point(23, 33);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(66, 17);
            this.cbAlumno.TabIndex = 0;
            this.cbAlumno.Text = "Alumnos";
            this.cbAlumno.UseVisualStyleBackColor = true;
            // 
            // gbUso
            // 
            this.gbUso.Controls.Add(this.rbExterno);
            this.gbUso.Controls.Add(this.rbInterno);
            this.gbUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbUso.Location = new System.Drawing.Point(170, 30);
            this.gbUso.Name = "gbUso";
            this.gbUso.Size = new System.Drawing.Size(207, 109);
            this.gbUso.TabIndex = 8;
            this.gbUso.TabStop = false;
            this.gbUso.Text = "Para uso:";
            // 
            // rbExterno
            // 
            this.rbExterno.AutoSize = true;
            this.rbExterno.Location = new System.Drawing.Point(17, 66);
            this.rbExterno.Name = "rbExterno";
            this.rbExterno.Size = new System.Drawing.Size(61, 17);
            this.rbExterno.TabIndex = 1;
            this.rbExterno.Text = "Externo";
            this.rbExterno.UseVisualStyleBackColor = true;
            // 
            // rbInterno
            // 
            this.rbInterno.AutoSize = true;
            this.rbInterno.Checked = true;
            this.rbInterno.Location = new System.Drawing.Point(17, 33);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(58, 17);
            this.rbInterno.TabIndex = 0;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            // 
            // gbEditorial
            // 
            this.gbEditorial.Controls.Add(this.txtEditorial);
            this.gbEditorial.Controls.Add(this.btnBuscarEditorial);
            this.gbEditorial.Controls.Add(this.label4);
            this.gbEditorial.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gbEditorial.Location = new System.Drawing.Point(383, 145);
            this.gbEditorial.Name = "gbEditorial";
            this.gbEditorial.Size = new System.Drawing.Size(212, 105);
            this.gbEditorial.TabIndex = 5;
            this.gbEditorial.TabStop = false;
            this.gbEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(13, 40);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.ReadOnly = true;
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 4;
            // 
            // btnBuscarEditorial
            // 
            this.btnBuscarEditorial.Location = new System.Drawing.Point(131, 38);
            this.btnBuscarEditorial.Name = "btnBuscarEditorial";
            this.btnBuscarEditorial.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEditorial.TabIndex = 3;
            this.btnBuscarEditorial.Text = "Buscar";
            this.btnBuscarEditorial.UseVisualStyleBackColor = true;
            this.btnBuscarEditorial.Click += new System.EventHandler(this.btnBuscarEditorial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.btnBuscarAutor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(383, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(13, 41);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(131, 38);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAutor.TabIndex = 3;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(727, 116);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 44);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(727, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(727, 199);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 44);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmModificarLibro";
            this.Text = "MODIFICAR LIBRO";
            this.Load += new System.EventHandler(this.frmModificarLibro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPrestar.ResumeLayout(false);
            this.gbPrestar.PerformLayout();
            this.gbUso.ResumeLayout(false);
            this.gbUso.PerformLayout();
            this.gbEditorial.ResumeLayout(false);
            this.gbEditorial.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbEditorial;
        private System.Windows.Forms.Button btnBuscarEditorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPrestar;
        private System.Windows.Forms.CheckBox cbMaestro;
        private System.Windows.Forms.CheckBox cbAlumno;
        private System.Windows.Forms.GroupBox gbUso;
        private System.Windows.Forms.RadioButton rbExterno;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}