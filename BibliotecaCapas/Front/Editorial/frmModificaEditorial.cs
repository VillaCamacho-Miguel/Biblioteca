using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades;
using Biblioteca.Negocio;
namespace Biblioteca.Front
{
    public partial class frmModificaEditorial : Form
    {
        public frmModificaEditorial()
        {
            InitializeComponent();
        }

        private void frmModificaEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaEditorialFiltro fcef = new frmConsultaEditorialFiltro();
            fcef.ShowDialog();
            txtClave.Text = VariablesEditorial.IdEditorial;
            txtNombre.Text = VariablesEditorial.NombreEditorial;
            txtDireccion.Text = VariablesEditorial.Direccion;
            txtCiudad.Text = VariablesEditorial.Ciudad;
            txtTelefono.Text = VariablesEditorial.Telefono;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if(txtClave.Text.Length != 0 && txtCiudad.Text.Length != 0 && txtDireccion.Text.Length != 0 && txtNombre.Text.Length != 0 && txtTelefono.Text.Length != 0)
            {
                int idEditorial = Convert.ToInt32(txtClave.Text);
                string nombreEd = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string ciudad = txtCiudad.Text;
                string telefono = txtTelefono.Text;
                if(telefono.Length != 10)
                {
                    MessageBox.Show("Verificar numero!");
                    return;
                }
                string nombreEditorialAux = VariablesEditorial.NombreEditorial;

                try
                {
                    EEditorial editorial = new EEditorial(idEditorial, nombreEd, telefono, direccion, ciudad);
                    if (nombreEditorialAux.Equals(nombreEd))
                    {

                        string con = NEdtitorial.Modifica2(editorial);
                        MessageBox.Show(con.Equals("OK") ? "MODIFICADO" : con);
                    }
                    else
                    {
                        string con = NEdtitorial.Modifica(editorial).Equals("OK") ? "MODIFICADO" : "NOMBRE YA EXISTE";
                        MessageBox.Show(con);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

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
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
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
        private void txtClave_Validated(object sender, EventArgs e)
        {
            valida(sender as TextBox);
        }
    }
}
