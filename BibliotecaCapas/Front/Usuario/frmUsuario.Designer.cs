
namespace Biblioteca.Front
{
    partial class frmUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbMaestro = new System.Windows.Forms.RadioButton();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 85);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbMaestro);
            this.gbTipo.Controls.Add(this.rbAlumno);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(22, 129);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(207, 109);
            this.gbTipo.TabIndex = 8;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo Usuario";
            // 
            // rbMaestro
            // 
            this.rbMaestro.AutoSize = true;
            this.rbMaestro.Location = new System.Drawing.Point(12, 64);
            this.rbMaestro.Name = "rbMaestro";
            this.rbMaestro.Size = new System.Drawing.Size(101, 29);
            this.rbMaestro.TabIndex = 1;
            this.rbMaestro.TabStop = true;
            this.rbMaestro.Text = "Maestro";
            this.rbMaestro.UseVisualStyleBackColor = true;
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.Checked = true;
            this.rbAlumno.Location = new System.Drawing.Point(12, 29);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(97, 29);
            this.rbAlumno.TabIndex = 0;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(296, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(296, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Modificar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(296, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datos Usuario";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "frmUsuario";
            this.Text = "USUARIO";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbMaestro;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}