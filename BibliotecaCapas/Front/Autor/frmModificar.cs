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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaAutorFiltro fcaf = new frmConsultaAutorFiltro();
            fcaf.ShowDialog();
            txtIdAutor.Text = VariablesAutor.IdAutor;
            txtNombre.Text = VariablesAutor.NombreAutor;
            txtNacionalidad.Text = VariablesAutor.Nacionalidad;

           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdAutor.Text.Length != 0 && txtNacionalidad.Text.Length != 0 && txtNombre.Text.Length != 0)
            {
                int idAutor = Convert.ToInt32(txtIdAutor.Text);
                string nombreAutor = txtNombre.Text;
                string nacionalidad = txtNacionalidad.Text;
                string nombreAutorAux = VariablesAutor.NombreAutor;

                try
                {
                    if (nombreAutorAux.Equals(nombreAutor))
                    {
                        EAutor autor = new EAutor(idAutor, nombreAutor, nacionalidad);
                        string con = NAutor.ModificaSoloNacio(autor);
                        MessageBox.Show(con.Equals("OK") ? "MODIFICADO":con);
                    }
                    else
                    {
                        EAutor autor = new EAutor(idAutor, nombreAutor, nacionalidad);
                        string con = NAutor.Modifica(autor).Equals("OK") ? "MODIFICADO" : "NOMBRE YA EXISTE";
                        MessageBox.Show(con);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
        private void txtNombre_Validated(object sender, EventArgs e)
        {
            valida(sender as TextBox);
        }
    }
}
