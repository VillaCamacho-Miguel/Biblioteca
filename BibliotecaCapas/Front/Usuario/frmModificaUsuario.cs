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
    public partial class frmModificaUsuario : Form
    {
        public frmModificaUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarioFiltro fcuf = new frmConsultaUsuarioFiltro();
            fcuf.ShowDialog();
            txtClave.Text = VariablesUsuario.IdUsuario;
            txtNombre.Text = VariablesUsuario.NombreUsuario;
            rbMaestro.Checked = VariablesUsuario.TipoUsuario1.Equals("MAESTRO");
            rbAlumno.Checked = VariablesUsuario.TipoUsuario1.Equals("ALUMNO");


        }

        private void frmModificaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if(txtNombre.Text.Length != 0 && txtClave.Text.Length != 0)
            {
                try
                {
                    int clave = Convert.ToInt32(txtClave.Text);
                    string nombre = txtNombre.Text;
                    char tipoUsuario = rbAlumno.Checked ? '0' : '1';
                    EUsuario usuario = new EUsuario(clave, nombre, tipoUsuario);
                    string rpt = NUsuario.Modifica(usuario);
                    MessageBox.Show(rpt);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Verificar Campos vacíos");
            }

          
        }
    }
}
