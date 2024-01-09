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
using Biblioteca.Front;
using Biblioteca.Entidades;
namespace Biblioteca.Front
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void gbDetallesLibro_Enter(object sender, EventArgs e)
        {

        }
        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            dtpFechaDevolucion.CustomFormat = "yyyy/MM/dd";
            dtpFechaDevolucion.Format = DateTimePickerFormat.Custom;

        }

     

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtClave.Text.Length != 0 && txtNombreLibro.Text.Length != 0
                && txtNombreUsuario.Text.Length != 0 && txtTipoUsuario.Text.Length != 0
                && txtUso.Text.Length != 0 && txtUsuarioLibro.Text.Length != 0)
            {
              
                if (rbExterno.Checked && txtUso.Text.Equals("Interno"))
                {
                    MessageBox.Show("No puede realizar un prestamo externo, revisar o modificar las consultas del libro");
                    return;
                }

                string clavePrestamo = txtClave.Text;
                string rpta = "";
                try
                {
                    rpta = NPrestamo.BuscarClave(clavePrestamo);

                    if (rpta.Equals("CLAVE REPETIDA"))
                    {
                        MessageBox.Show("CLAVE REPETIDA");
                        return;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                string nombreUsuario = txtNombreUsuario.Text;
                string nombreLibro = txtNombreLibro.Text;
                DateTime fechaDevolucion = dtpFechaDevolucion.Value;
                try
                {
                    if (!NPrestamo.VerificaFecha(fechaDevolucion).Equals("CORRECTO"))
                    {
                        MessageBox.Show("Verificar Fecha!");
                        return;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                char consulta = rbInterno.Checked ? '1' : '0';
                char userLibro = ' ', user = ' ';
                if (txtUsuarioLibro.Text.Equals("Alumno")) userLibro = '0';
                if (txtUsuarioLibro.Text.Equals("Maestro")) userLibro = '1';
                if (txtUsuarioLibro.Text.Equals("Alumnos y Maestros")) userLibro = '2';
                if (txtTipoUsuario.Text.Equals("Alumno")) user = '0';
                if (txtTipoUsuario.Text.Equals("Maestro")) user = '1';
                if (txtTipoUsuario.Text.Equals("Alumnos y Maestros")) user = '2';


                try
                {

                    if(NPrestamo.VerificaUsuarios(userLibro , user).Equals("CORRECTO"))
                    {
                        EPrestamo prestamo = new EPrestamo(clavePrestamo, nombreLibro, nombreUsuario, fechaDevolucion, consulta);
                        rpta = NPrestamo.AgregarPrestamo(prestamo);
                        if (rpta.Equals("OK")) MessageBox.Show("Prestamo Realizado");
                        else MessageBox.Show(rpta);
                    }
                    else
                    {
                        MessageBox.Show("Error, Libro no disponible para este tipo de usuario");
                        return;
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

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
             frmFiltraLibros fcuf = new frmFiltraLibros();
            fcuf.ShowDialog();
            txtNombreLibro.Text = Variables.NombreLibro;
            txtUsuarioLibro.Text = Variables.TipoDeUsuario;
            txtUso.Text = Variables.Consulta;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarioFiltro fcuf = new frmConsultaUsuarioFiltro();
            fcuf.ShowDialog();
            txtTipoUsuario.Text = VariablesUsuario.TipoUsuario1;
            txtNombreUsuario.Text = VariablesUsuario.NombreUsuario;
            
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
