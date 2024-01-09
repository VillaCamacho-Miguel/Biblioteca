
namespace Biblioteca.Front
{
    partial class frmConsultaUsuarioFiltro
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
            this.dgvDatosUsuariosFiltro = new System.Windows.Forms.DataGridView();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuariosFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosUsuariosFiltro
            // 
            this.dgvDatosUsuariosFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuariosFiltro.Location = new System.Drawing.Point(0, 59);
            this.dgvDatosUsuariosFiltro.Name = "dgvDatosUsuariosFiltro";
            this.dgvDatosUsuariosFiltro.Size = new System.Drawing.Size(800, 391);
            this.dgvDatosUsuariosFiltro.TabIndex = 0;
            this.dgvDatosUsuariosFiltro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosUsuariosFiltro_CellDoubleClick);
            // 
            // txtTextoBuscar
            // 
            this.txtTextoBuscar.Location = new System.Drawing.Point(30, 21);
            this.txtTextoBuscar.Name = "txtTextoBuscar";
            this.txtTextoBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtTextoBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(136, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsultaUsuarioFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTextoBuscar);
            this.Controls.Add(this.dgvDatosUsuariosFiltro);
            this.Name = "frmConsultaUsuarioFiltro";
            this.Text = "BUSCAR USUARIO";
            this.Load += new System.EventHandler(this.frmConsultaUsuarioFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuariosFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosUsuariosFiltro;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}