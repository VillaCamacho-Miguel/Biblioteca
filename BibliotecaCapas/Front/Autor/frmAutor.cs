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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(txtNombre.Text.Length != 0 && txtNacionalidad.Text.Length != 0)
            {
                string nombre = txtNombre.Text;
                string nacionalidad = txtNacionalidad.Text;
                try
                {
                    EAutor autor = new EAutor(nombre, nacionalidad);
                    if (NAutor.Agrega(autor).Equals("REPETIDO"))
                    {

                        MessageBox.Show("Nombre repetido");
                        return;
                    }
                    else
                    {

                        string con = NAutor.Agrega(autor).Equals("OK") ? "Error al ingresar a los datos" : "AGREGADO";
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
                MessageBox.Show("Verifica Campos vacíos!");
            }
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar fm = new frmModificar();
            fm.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
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
        private void txtNacionalidad_Validated(object sender, EventArgs e)
        {
            valida(sender as TextBox);
        }
    }
}
