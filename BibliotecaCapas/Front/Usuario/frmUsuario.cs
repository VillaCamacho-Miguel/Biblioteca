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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            char tipoUsuario = rbAlumno.Checked ? '0' : '1';
            try
            {

                EUsuario usuario = new EUsuario(nombre, tipoUsuario);
               string str= NUsuario.Agrega(usuario);
                MessageBox.Show(str);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmModificaUsuario fmu = new frmModificaUsuario();
            fmu.ShowDialog();
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
