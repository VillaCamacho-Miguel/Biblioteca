using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaUsoPDF;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using Biblioteca.Negocio;
namespace Biblioteca.Front
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibro fl = new frmLibro();
            abrirForm(fl);
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrestamo fp = new frmPrestamo();
            abrirForm(fp);

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultarDatos());
        }

        private void modficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarLibro fml = new frmModificarLibro();
            abrirForm(new frmModificarLibro());
        }


        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            frmAutor fa = new frmAutor();
            abrirForm(fa);

        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmEditorial fe = new frmEditorial();
            abrirForm(fe);

        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            abrirForm(fu);


        }

        private void librosMayorPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePDF("LibroMasPopular.pdf");
            documento = Utility.EncabezadoPDF(documento, "Registro Libros Mas Populares", "Reporte de Libros");
            DataTable tablaVal = NLibro.ObtenLibrosPopulares();
            float[] tam = { 5, 10, 5 };
            Table tabla = Utility.EncabezadoTabla(new string[] { "CLAVE", "NOMBRE LIBRO", "PRESTADOS" }, tam);
            for (int i = 0; i < tablaVal.Rows.Count; i++)
            {

                Paragraph p = new Paragraph(tablaVal.Rows[i]["CLAVE"].ToString());
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaVal.Rows[i]["NOMBRE LIBRO"].ToString());
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaVal.Rows[i]["PRESTADOS"].ToString());
                tabla.AddCell(new Cell().Add(p));
            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte libros populares Generado");
        }

        private void usuariosMasActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePDF("UsuarioMasActivo.pdf");
            documento = Utility.EncabezadoPDF(documento, "Registro de usuarios mas activos", "Reporte de Usuarios");
            DataTable tablaVal = NUsuario.ObtenUsuariosMasActivos();
            float[] tam = { 10, 10,10 };
            Table tabla = Utility.EncabezadoTabla(new string[] { "NOMBRE USUARIO","NOMBRE LIBRO", "PRESTAMOS REALIZADOS" }, tam);
            for (int i = 0; i < tablaVal.Rows.Count; i++)
            {

                Paragraph p = new Paragraph(tablaVal.Rows[i]["NOMBRE USUARIO"].ToString());
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaVal.Rows[i]["USUARIO"].ToString());
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaVal.Rows[i]["PRESTAMOS REALIZADOS"].ToString());
                tabla.AddCell(new Cell().Add(p));
            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte Usuarios mas activos Generado");
        }

        private void listadoDeLibrosDeEditorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CreatePDF("LibrosMasExistencias.pdf");
            documento = Utility.EncabezadoPDF(documento, "Registro Libros Mas Existencia", "Reporte de Libros");
            DataTable tablaVal = NLibro.ObtenLibrosMasExistencia();
            float[] tam = { 3, 10, 20 };
            Table tabla = Utility.EncabezadoTabla(new string[] {"CLAVE", "NOMBRE LIBRO", "EXISTENCIA" }, tam);
            for (int i = 0; i < tablaVal.Rows.Count; i++)
            {

                Paragraph p = new Paragraph(tablaVal.Rows[i]["CLAVE"].ToString());
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaVal.Rows[i]["NOMBRE DEL LIBRO"].ToString());
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaVal.Rows[i]["EXISTENCIA"].ToString());
                tabla.AddCell(new Cell().Add(p));
              

            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte libros mas existencia Generado");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        void abrirForm(Form form)
        {
            while (panelFrms.Controls.Count > 0)
            {
                panelFrms.Controls.RemoveAt(index: 0);
            }
            Form formHijo = form;
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFrms.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void librosMasPopularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new frmReporte("LibroMasPopular.pdf"));
        }

        private void usuariosMasActivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(new frmReporte("UsuarioMasActivo.pdf"));
        }

        private void listadoDeLibrosEditorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new frmReporte("LibrosMasExistencias.pdf"));
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaPrestamoFiltro());

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrirReportes.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                abrirForm(new frmReporte(ofdAbrirReportes.FileName));

            }
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaAutorFiltro());

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(new frmModificar());

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaUsuarioFiltro());

        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abrirForm(new frmModificaUsuario());

        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abrirForm(new frmModificaEditorial());

        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaEditorialFiltro());

        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultarDatos());

        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaLibroIndividual());
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new frmEliminarLibro());
        }
    }
}
