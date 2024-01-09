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
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(txtTelefono.Text.Length!=0 && txtNombre.Text.Length != 0 && txtDireccion.Text.Length != 0 && txtCiudad.Text.Length != 0)
            {
                string nombre = txtNombre.Text;


                try
                {
                    if (NEdtitorial.BuscarNombreEditorial(nombre).Equals("EXISTE"))
                    {
                        MessageBox.Show("Error, Nombre Repetido");
                        return;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                string telefono = txtTelefono.Text;
                if (txtTelefono.Text.Length != 10)
                {
                    MessageBox.Show("Verifica Numero!");
                }
                string ciudad = txtCiudad.Text;
                string direccion = txtDireccion.Text;
                try
                {
                    EEditorial editorial = new EEditorial(nombre, telefono, direccion, ciudad);
                    NEdtitorial.Agrega(editorial);

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificaEditorial fme = new frmModificaEditorial();
            fme.ShowDialog();
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaEditorial fce = new frmConsultaEditorial();
            fce.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        public bool validaTexto(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena) || string.IsNullOrEmpty(cadena))
            {
                return false;

            }
            return true;
        }
        public void valida(TextBox txt)
        {
            string dato = txt.Text;
            if (validaTexto(dato))
            {

                errorP.SetError(txt, "");
            }
            else
            {
                errorP.SetError(txt, "nombreVacio");
                txt.Focus();
            }

        }
        private void txtCiudad_Validated(object sender, EventArgs e)
        {
            valida(sender as TextBox);
        }
    }
}
