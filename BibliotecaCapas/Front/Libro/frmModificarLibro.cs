using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;
using Biblioteca.Entidades;

namespace Biblioteca.Front
{
    public partial class frmModificarLibro : Form
    {
        public frmModificarLibro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmModificarLibro_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmFiltraLibros ffl = new frmFiltraLibros();
            ffl.ShowDialog();
            txtISBN.Text = Variables.Clave;
            txtAutor.Text = Variables.Autor;
            txtEditorial.Text = Variables.Editorial;
            txtNombreLibro.Text = Variables.NombreLibro;
            txtExistencia.Text = Variables.Existencia;
            rbExterno.Checked = Variables.Consulta.Equals("Externo");
            rbInterno.Checked = Variables.Consulta.Equals("Interno");

            cbAlumno.Checked = Variables.TipoDeUsuario.Equals("Alumno");
            cbMaestro.Checked = Variables.TipoDeUsuario.Equals("Maestro");
            if (Variables.TipoDeUsuario.Equals("Alumnos y Maestros"))
            {
                cbMaestro.Checked = true;
                cbAlumno.Checked = true;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtAutor.Text.Length != 0 
                && txtEditorial.Text.Length != 0
                && txtExistencia.Text.Length != 0
                && txtISBN.Text.Length != 0
                && txtNombreLibro.Text.Length != 0)
            {
                try
                {
                    string clave = txtISBN.Text;
                    string autor = txtAutor.Text;
                    byte existencia = Convert.ToByte(txtExistencia.Text);
                    string nombre = txtNombreLibro.Text;
                    string editorial = txtEditorial.Text;
                    char consulta = rbInterno.Checked ? '0':'1';
                    char disponible = ' ';
                    string nombreLibroAux = Variables.Autor;
                    if (cbAlumno.Checked) disponible = '0';
                    if (cbMaestro.Checked) disponible = '1';
                    if (cbMaestro.Checked && cbAlumno.Checked) disponible = '2';
                    if(!cbMaestro.Checked && !cbAlumno.Checked)
                    {
                        MessageBox.Show("Verificar el tipo de usuario!");
                        return;
                    }

                    ELibro libro = new ELibro(clave, nombre, existencia, consulta, disponible, autor,editorial);
                    if (nombreLibroAux.Equals(nombre))
                    {

                        string con = NLibro.modifica(libro);
                        MessageBox.Show(con.Equals("OK") ? "MODIFICADO" : con);
                    }
                    else
                    {
                        string con = NLibro.modifica2(libro).Equals("OK") ? "MODIFICADO" : "NOMBRE YA EXISTE";
                        MessageBox.Show(con);
                    }
                
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Verificar Campos Vacíos!");
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            frmConsultaAutorFiltro f = new frmConsultaAutorFiltro();
            f.ShowDialog();
            txtAutor.Text = VariablesAutor.NombreAutor;
            
        }

        private void btnBuscarEditorial_Click(object sender, EventArgs e)
        {
            frmConsultaEditorialFiltro f = new frmConsultaEditorialFiltro();
            f.ShowDialog();
            txtEditorial.Text = VariablesEditorial.NombreEditorial;

        }

        private void txtNombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
