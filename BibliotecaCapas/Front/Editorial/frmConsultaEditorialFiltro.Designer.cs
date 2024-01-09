
namespace Biblioteca.Front
{
    partial class frmConsultaEditorialFiltro
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
            this.dgvEditorial = new System.Windows.Forms.DataGridView();
            this.txtFiltroEditorial = new System.Windows.Forms.TextBox();
            this.btnBuscarEdit = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditorial
            // 
            this.dgvEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditorial.Location = new System.Drawing.Point(14, 67);
            this.dgvEditorial.Name = "dgvEditorial";
            this.dgvEditorial.Size = new System.Drawing.Size(777, 368);
            this.dgvEditorial.TabIndex = 0;
            this.dgvEditorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditorial_CellDoubleClick);
            // 
            // txtFiltroEditorial
            // 
            this.txtFiltroEditorial.Location = new System.Drawing.Point(27, 21);
            this.txtFiltroEditorial.Name = "txtFiltroEditorial";
            this.txtFiltroEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroEditorial.TabIndex = 1;
            // 
            // btnBuscarEdit
            // 
            this.btnBuscarEdit.Location = new System.Drawing.Point(145, 18);
            this.btnBuscarEdit.Name = "btnBuscarEdit";
            this.btnBuscarEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEdit.TabIndex = 2;
            this.btnBuscarEdit.Text = "Buscar";
            this.btnBuscarEdit.UseVisualStyleBackColor = true;
            this.btnBuscarEdit.Click += new System.EventHandler(this.btnBuscarEdit_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(242, 18);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // frmConsultaEditorialFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscarEdit);
            this.Controls.Add(this.txtFiltroEditorial);
            this.Controls.Add(this.dgvEditorial);
            this.Name = "frmConsultaEditorialFiltro";
            this.Text = "BUSQUEDA EDITORIAL";
            this.Load += new System.EventHandler(this.frmConsultaEditorialFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditorial;
        private System.Windows.Forms.TextBox txtFiltroEditorial;
        private System.Windows.Forms.Button btnBuscarEdit;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}