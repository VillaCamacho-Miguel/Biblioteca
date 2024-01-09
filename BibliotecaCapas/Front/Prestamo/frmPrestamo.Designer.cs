
namespace Biblioteca.Front
{
    partial class frmPrestamo
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
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblDatosPrestamo = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDetallesLibro = new System.Windows.Forms.GroupBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.txtUsuarioLibro = new System.Windows.Forms.TextBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.txtUso = new System.Windows.Forms.TextBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.gbConsultaUso = new System.Windows.Forms.GroupBox();
            this.rbExterno = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatosUsuario.SuspendLayout();
            this.gbDetallesLibro.SuspendLayout();
            this.gbConsultaUso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(156, 67);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(171, 20);
            this.dtpFechaDevolucion.TabIndex = 0;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(21, 49);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 18);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(30, 13);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "Libro";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(6, 24);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblDatosPrestamo
            // 
            this.lblDatosPrestamo.AutoSize = true;
            this.lblDatosPrestamo.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPrestamo.Location = new System.Drawing.Point(15, -1);
            this.lblDatosPrestamo.Name = "lblDatosPrestamo";
            this.lblDatosPrestamo.Size = new System.Drawing.Size(239, 31);
            this.lblDatosPrestamo.TabIndex = 4;
            this.lblDatosPrestamo.Text = "Datos del prestamo";
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Location = new System.Drawing.Point(21, 67);
            this.txtClave.MaxLength = 5;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(85, 20);
            this.txtClave.TabIndex = 5;
            this.txtClave.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(153, 52);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(107, 13);
            this.lblFechaDevolucion.TabIndex = 6;
            this.lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 45);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(146, 283);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 45);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.gbDatosUsuario.Controls.Add(this.btnBuscarUsuario);
            this.gbDatosUsuario.Controls.Add(this.txtTipoUsuario);
            this.gbDatosUsuario.Controls.Add(this.label2);
            this.gbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.gbDatosUsuario.Location = new System.Drawing.Point(12, 113);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(242, 137);
            this.gbDatosUsuario.TabIndex = 11;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Detalles Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(12, 43);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(109, 20);
            this.txtNombreUsuario.TabIndex = 12;
            this.txtNombreUsuario.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(144, 40);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 11;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(12, 100);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.ReadOnly = true;
            this.txtTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtTipoUsuario.TabIndex = 10;
            this.txtTipoUsuario.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "tipoUsuario";
            // 
            // gbDetallesLibro
            // 
            this.gbDetallesLibro.Controls.Add(this.txtNombreLibro);
            this.gbDetallesLibro.Controls.Add(this.btnBuscarLibro);
            this.gbDetallesLibro.Controls.Add(this.txtUsuarioLibro);
            this.gbDetallesLibro.Controls.Add(this.lblUsuarios);
            this.gbDetallesLibro.Controls.Add(this.txtUso);
            this.gbDetallesLibro.Controls.Add(this.lblUso);
            this.gbDetallesLibro.Controls.Add(this.lblISBN);
            this.gbDetallesLibro.Location = new System.Drawing.Point(320, 113);
            this.gbDetallesLibro.Name = "gbDetallesLibro";
            this.gbDetallesLibro.Size = new System.Drawing.Size(230, 156);
            this.gbDetallesLibro.TabIndex = 12;
            this.gbDetallesLibro.TabStop = false;
            this.gbDetallesLibro.Text = "Detalles Libro";
            this.gbDetallesLibro.Enter += new System.EventHandler(this.gbDetallesLibro_Enter);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(8, 33);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(125, 20);
            this.txtNombreLibro.TabIndex = 13;
            this.txtNombreLibro.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(149, 31);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 12;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // txtUsuarioLibro
            // 
            this.txtUsuarioLibro.Location = new System.Drawing.Point(15, 121);
            this.txtUsuarioLibro.Name = "txtUsuarioLibro";
            this.txtUsuarioLibro.ReadOnly = true;
            this.txtUsuarioLibro.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioLibro.TabIndex = 11;
            this.txtUsuarioLibro.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(18, 105);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(53, 13);
            this.lblUsuarios.TabIndex = 10;
            this.lblUsuarios.Text = "Usuario/s";
            // 
            // txtUso
            // 
            this.txtUso.Location = new System.Drawing.Point(15, 81);
            this.txtUso.Name = "txtUso";
            this.txtUso.ReadOnly = true;
            this.txtUso.Size = new System.Drawing.Size(100, 20);
            this.txtUso.TabIndex = 9;
            this.txtUso.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // lblUso
            // 
            this.lblUso.AutoSize = true;
            this.lblUso.Location = new System.Drawing.Point(18, 65);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(24, 13);
            this.lblUso.TabIndex = 8;
            this.lblUso.Text = "uso";
            // 
            // gbConsultaUso
            // 
            this.gbConsultaUso.Controls.Add(this.rbExterno);
            this.gbConsultaUso.Controls.Add(this.rbInterno);
            this.gbConsultaUso.Location = new System.Drawing.Point(359, 30);
            this.gbConsultaUso.Name = "gbConsultaUso";
            this.gbConsultaUso.Size = new System.Drawing.Size(205, 57);
            this.gbConsultaUso.TabIndex = 13;
            this.gbConsultaUso.TabStop = false;
            this.gbConsultaUso.Text = "Uso";
            // 
            // rbExterno
            // 
            this.rbExterno.AutoSize = true;
            this.rbExterno.Location = new System.Drawing.Point(110, 20);
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
            this.rbInterno.Location = new System.Drawing.Point(6, 20);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(57, 17);
            this.rbInterno.TabIndex = 0;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 340);
            this.Controls.Add(this.gbConsultaUso);
            this.Controls.Add(this.gbDetallesLibro);
            this.Controls.Add(this.gbDatosUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblDatosPrestamo);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Name = "frmPrestamo";
            this.Text = "PRESTAMO";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            this.gbDetallesLibro.ResumeLayout(false);
            this.gbDetallesLibro.PerformLayout();
            this.gbConsultaUso.ResumeLayout(false);
            this.gbConsultaUso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblDatosPrestamo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDetallesLibro;
        private System.Windows.Forms.TextBox txtUsuarioLibro;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TextBox txtUso;
        private System.Windows.Forms.Label lblUso;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.GroupBox gbConsultaUso;
        private System.Windows.Forms.RadioButton rbExterno;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}