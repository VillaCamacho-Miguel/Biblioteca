
namespace Biblioteca.Front
{
    partial class frmLibro
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
            this.components = new System.ComponentModel.Container();
            this.lblDatosDelLibro = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.gbUso = new System.Windows.Forms.GroupBox();
            this.rbExterno = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.gbPrestar = new System.Windows.Forms.GroupBox();
            this.cbMaestro = new System.Windows.Forms.CheckBox();
            this.cbAlumno = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbEditoriales = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbUso.SuspendLayout();
            this.gbPrestar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosDelLibro
            // 
            this.lblDatosDelLibro.AutoSize = true;
            this.lblDatosDelLibro.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelLibro.Location = new System.Drawing.Point(488, 20);
            this.lblDatosDelLibro.Name = "lblDatosDelLibro";
            this.lblDatosDelLibro.Size = new System.Drawing.Size(300, 52);
            this.lblDatosDelLibro.TabIndex = 0;
            this.lblDatosDelLibro.Text = "Datos del libro";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(7, 20);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(58, 25);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(188, 20);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(163, 25);
            this.lblNombreLibro.TabIndex = 2;
            this.lblNombreLibro.Text = "Nombre Del Libro";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(371, 114);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(59, 25);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(6, 114);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(81, 25);
            this.lblEditorial.TabIndex = 4;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.Location = new System.Drawing.Point(226, 114);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(101, 25);
            this.lblExistencia.TabIndex = 5;
            this.lblExistencia.Text = "Existencia";
            // 
            // gbUso
            // 
            this.gbUso.Controls.Add(this.rbExterno);
            this.gbUso.Controls.Add(this.rbInterno);
            this.gbUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUso.Location = new System.Drawing.Point(2, 212);
            this.gbUso.Name = "gbUso";
            this.gbUso.Size = new System.Drawing.Size(185, 109);
            this.gbUso.TabIndex = 6;
            this.gbUso.TabStop = false;
            this.gbUso.Text = "Para uso:";
            this.gbUso.Enter += new System.EventHandler(this.gbUso_Enter);
            // 
            // rbExterno
            // 
            this.rbExterno.AutoSize = true;
            this.rbExterno.Location = new System.Drawing.Point(17, 66);
            this.rbExterno.Name = "rbExterno";
            this.rbExterno.Size = new System.Drawing.Size(97, 29);
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
            this.rbInterno.Size = new System.Drawing.Size(90, 29);
            this.rbInterno.TabIndex = 0;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            // 
            // gbPrestar
            // 
            this.gbPrestar.Controls.Add(this.cbMaestro);
            this.gbPrestar.Controls.Add(this.cbAlumno);
            this.gbPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestar.Location = new System.Drawing.Point(231, 212);
            this.gbPrestar.Name = "gbPrestar";
            this.gbPrestar.Size = new System.Drawing.Size(207, 109);
            this.gbPrestar.TabIndex = 7;
            this.gbPrestar.TabStop = false;
            this.gbPrestar.Text = "Disponible Para";
            // 
            // cbMaestro
            // 
            this.cbMaestro.AutoSize = true;
            this.cbMaestro.Location = new System.Drawing.Point(23, 66);
            this.cbMaestro.Name = "cbMaestro";
            this.cbMaestro.Size = new System.Drawing.Size(112, 29);
            this.cbMaestro.TabIndex = 1;
            this.cbMaestro.Text = "Maestros";
            this.cbMaestro.UseVisualStyleBackColor = true;
            // 
            // cbAlumno
            // 
            this.cbAlumno.AutoSize = true;
            this.cbAlumno.Location = new System.Drawing.Point(23, 33);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(108, 29);
            this.cbAlumno.TabIndex = 0;
            this.cbAlumno.Text = "Alumnos";
            this.cbAlumno.UseVisualStyleBackColor = true;
            this.cbAlumno.CheckedChanged += new System.EventHandler(this.cbAlumno_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(598, 115);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 48);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(598, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 48);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(668, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 48);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(740, 115);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 48);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbEditoriales
            // 
            this.cmbEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditoriales.FormattingEnabled = true;
            this.cmbEditoriales.Location = new System.Drawing.Point(2, 142);
            this.cmbEditoriales.Name = "cmbEditoriales";
            this.cmbEditoriales.Size = new System.Drawing.Size(174, 33);
            this.cmbEditoriales.TabIndex = 12;
            this.cmbEditoriales.SelectedIndexChanged += new System.EventHandler(this.cmbEditoriales_SelectedIndexChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(2, 48);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(160, 30);
            this.txtISBN.TabIndex = 13;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLibro_KeyPress);
            this.txtISBN.Validated += new System.EventHandler(this.txtISBN_Validated);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(189, 46);
            this.txtNombreLibro.MaxLength = 30;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(197, 30);
            this.txtNombreLibro.TabIndex = 14;
            this.txtNombreLibro.TextChanged += new System.EventHandler(this.txtNombreLibro_TextChanged);
            this.txtNombreLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLibro_KeyPress);
            this.txtNombreLibro.Validated += new System.EventHandler(this.txtISBN_Validated);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(231, 142);
            this.txtExistencia.MaxLength = 3;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 30);
            this.txtExistencia.TabIndex = 15;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            this.txtExistencia.Validated += new System.EventHandler(this.txtISBN_Validated);
            // 
            // cmbAutor
            // 
            this.cmbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(376, 139);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(154, 33);
            this.cmbAutor.TabIndex = 16;
            this.cmbAutor.SelectedIndexChanged += new System.EventHandler(this.cmbAutor_SelectedIndexChanged);
            this.cmbAutor.MouseLeave += new System.EventHandler(this.cmbAutor_MouseLeave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(740, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 48);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 382);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.cmbEditoriales);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbPrestar);
            this.Controls.Add(this.gbUso);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblDatosDelLibro);
            this.Name = "frmLibro";
            this.Text = "LIBRO";
            this.Load += new System.EventHandler(this.frmLibro_Load);
            this.gbUso.ResumeLayout(false);
            this.gbUso.PerformLayout();
            this.gbPrestar.ResumeLayout(false);
            this.gbPrestar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosDelLibro;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.GroupBox gbUso;
        private System.Windows.Forms.GroupBox gbPrestar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbExterno;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.CheckBox cbMaestro;
        private System.Windows.Forms.CheckBox cbAlumno;
        private System.Windows.Forms.ComboBox cmbEditoriales;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}