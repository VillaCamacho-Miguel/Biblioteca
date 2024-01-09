
namespace Biblioteca.Front
{
    partial class frmConsultaLibroIndividual
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
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.dgvLibroIndividual = new System.Windows.Forms.DataGridView();
            this.lblSeleccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibroIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(111, 38);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(121, 21);
            this.cmbLibros.TabIndex = 0;
            this.cmbLibros.SelectedIndexChanged += new System.EventHandler(this.cmbLibros_SelectedIndexChanged);
            // 
            // dgvLibroIndividual
            // 
            this.dgvLibroIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibroIndividual.Location = new System.Drawing.Point(13, 85);
            this.dgvLibroIndividual.Name = "dgvLibroIndividual";
            this.dgvLibroIndividual.Size = new System.Drawing.Size(747, 174);
            this.dgvLibroIndividual.TabIndex = 1;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(28, 41);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(60, 13);
            this.lblSeleccion.TabIndex = 2;
            this.lblSeleccion.Text = "Selecciona";
            // 
            // frmConsultaLibroIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.dgvLibroIndividual);
            this.Controls.Add(this.cmbLibros);
            this.Name = "frmConsultaLibroIndividual";
            this.Text = "frmConsultaLibroIndividual";
            this.Load += new System.EventHandler(this.frmConsultaLibroIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibroIndividual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.DataGridView dgvLibroIndividual;
        private System.Windows.Forms.Label lblSeleccion;
    }
}