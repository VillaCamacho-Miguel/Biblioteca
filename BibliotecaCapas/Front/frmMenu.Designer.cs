
namespace Biblioteca.Front
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modficarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosMayorPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMasActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosDeEditorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosMasPopularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMasActivosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosEditorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFrms = new System.Windows.Forms.Panel();
            this.ofdAbrirReportes = new System.Windows.Forms.OpenFileDialog();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroToolStripMenuItem,
            this.prestamoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.editorialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.modficarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.libroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("libroToolStripMenuItem.Image")));
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.libroToolStripMenuItem.Text = "Libro";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasToolStripMenuItem,
            this.individualToolStripMenuItem});
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            this.todasToolStripMenuItem.Click += new System.EventHandler(this.todasToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            this.individualToolStripMenuItem.Click += new System.EventHandler(this.individualToolStripMenuItem_Click);
            // 
            // modficarToolStripMenuItem
            // 
            this.modficarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modficarToolStripMenuItem.Image")));
            this.modficarToolStripMenuItem.Name = "modficarToolStripMenuItem";
            this.modficarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modficarToolStripMenuItem.Text = "Modficar";
            this.modficarToolStripMenuItem.Click += new System.EventHandler(this.modficarToolStripMenuItem_Click);
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.consultarToolStripMenuItem1});
            this.prestamoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prestamoToolStripMenuItem.Image")));
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem1.Image")));
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem1.Image")));
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem,
            this.mostrarReporteToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosMayorPrestamoToolStripMenuItem,
            this.usuariosMasActivosToolStripMenuItem,
            this.listadoDeLibrosDeEditorialesToolStripMenuItem});
            this.generarReporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generarReporteToolStripMenuItem.Image")));
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generarReporteToolStripMenuItem.Text = "GenerarReporte";
            // 
            // librosMayorPrestamoToolStripMenuItem
            // 
            this.librosMayorPrestamoToolStripMenuItem.Name = "librosMayorPrestamoToolStripMenuItem";
            this.librosMayorPrestamoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.librosMayorPrestamoToolStripMenuItem.Text = "Libros mayor prestamo";
            this.librosMayorPrestamoToolStripMenuItem.Click += new System.EventHandler(this.librosMayorPrestamoToolStripMenuItem_Click);
            // 
            // usuariosMasActivosToolStripMenuItem
            // 
            this.usuariosMasActivosToolStripMenuItem.Name = "usuariosMasActivosToolStripMenuItem";
            this.usuariosMasActivosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.usuariosMasActivosToolStripMenuItem.Text = "Usuarios mas activos";
            this.usuariosMasActivosToolStripMenuItem.Click += new System.EventHandler(this.usuariosMasActivosToolStripMenuItem_Click);
            // 
            // listadoDeLibrosDeEditorialesToolStripMenuItem
            // 
            this.listadoDeLibrosDeEditorialesToolStripMenuItem.Name = "listadoDeLibrosDeEditorialesToolStripMenuItem";
            this.listadoDeLibrosDeEditorialesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.listadoDeLibrosDeEditorialesToolStripMenuItem.Text = "Libros con mas existencia";
            this.listadoDeLibrosDeEditorialesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeLibrosDeEditorialesToolStripMenuItem_Click);
            // 
            // mostrarReporteToolStripMenuItem
            // 
            this.mostrarReporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosMasPopularesToolStripMenuItem,
            this.usuariosMasActivosToolStripMenuItem1,
            this.listadoDeLibrosEditorialesToolStripMenuItem});
            this.mostrarReporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarReporteToolStripMenuItem.Image")));
            this.mostrarReporteToolStripMenuItem.Name = "mostrarReporteToolStripMenuItem";
            this.mostrarReporteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mostrarReporteToolStripMenuItem.Text = "MostrarReporte";
            // 
            // librosMasPopularesToolStripMenuItem
            // 
            this.librosMasPopularesToolStripMenuItem.Name = "librosMasPopularesToolStripMenuItem";
            this.librosMasPopularesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.librosMasPopularesToolStripMenuItem.Text = "Libros mas populares";
            this.librosMasPopularesToolStripMenuItem.Click += new System.EventHandler(this.librosMasPopularesToolStripMenuItem_Click);
            // 
            // usuariosMasActivosToolStripMenuItem1
            // 
            this.usuariosMasActivosToolStripMenuItem1.Name = "usuariosMasActivosToolStripMenuItem1";
            this.usuariosMasActivosToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.usuariosMasActivosToolStripMenuItem1.Text = "Usuarios mas activos";
            this.usuariosMasActivosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosMasActivosToolStripMenuItem1_Click);
            // 
            // listadoDeLibrosEditorialesToolStripMenuItem
            // 
            this.listadoDeLibrosEditorialesToolStripMenuItem.Name = "listadoDeLibrosEditorialesToolStripMenuItem";
            this.listadoDeLibrosEditorialesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listadoDeLibrosEditorialesToolStripMenuItem.Text = "Listado de libros editoriales";
            this.listadoDeLibrosEditorialesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeLibrosEditorialesToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.consultarToolStripMenuItem2,
            this.modificarToolStripMenuItem1});
            this.autorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autorToolStripMenuItem.Image")));
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            this.consultarToolStripMenuItem2.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.consultarToolStripMenuItem3,
            this.modificarToolStripMenuItem2});
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem3.Text = "Agregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            this.consultarToolStripMenuItem3.Click += new System.EventHandler(this.consultarToolStripMenuItem3_Click);
            // 
            // modificarToolStripMenuItem2
            // 
            this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem2.Text = "Modificar";
            this.modificarToolStripMenuItem2.Click += new System.EventHandler(this.modificarToolStripMenuItem2_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem4,
            this.modificarToolStripMenuItem3,
            this.consultarToolStripMenuItem4});
            this.editorialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editorialToolStripMenuItem.Image")));
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.editorialToolStripMenuItem.Text = "Editorial";
            // 
            // agregarToolStripMenuItem4
            // 
            this.agregarToolStripMenuItem4.Name = "agregarToolStripMenuItem4";
            this.agregarToolStripMenuItem4.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem4.Text = "Agregar";
            this.agregarToolStripMenuItem4.Click += new System.EventHandler(this.agregarToolStripMenuItem4_Click);
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            this.modificarToolStripMenuItem3.Click += new System.EventHandler(this.modificarToolStripMenuItem3_Click);
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem4.Text = "Consultar";
            this.consultarToolStripMenuItem4.Click += new System.EventHandler(this.consultarToolStripMenuItem4_Click);
            // 
            // panelFrms
            // 
            this.panelFrms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrms.Location = new System.Drawing.Point(0, 24);
            this.panelFrms.Name = "panelFrms";
            this.panelFrms.Size = new System.Drawing.Size(1180, 506);
            this.panelFrms.TabIndex = 1;
            // 
            // ofdAbrirReportes
            // 
            this.ofdAbrirReportes.FileName = "openFileDialog1";
            this.ofdAbrirReportes.Filter = "Archivos PDF(*.pdf)|*.pdf";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 530);
            this.Controls.Add(this.panelFrms);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "BIBLIOTECA";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modficarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem librosMayorPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMasActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosDeEditorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosMasPopularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMasActivosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosEditorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Panel panelFrms;
        private System.Windows.Forms.OpenFileDialog ofdAbrirReportes;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}