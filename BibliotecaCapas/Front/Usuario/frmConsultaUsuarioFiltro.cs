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
    public partial class frmConsultaUsuarioFiltro : Form
    {
        public frmConsultaUsuarioFiltro()
        {
            
            InitializeComponent();
        }

        private void frmConsultaUsuarioFiltro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string txt = txtTextoBuscar.Text;
            DataTable cmd = NUsuario.ObtenUsuarioFiltro(txt);
            dgvDatosUsuariosFiltro.DataSource = cmd;
            dgvDatosUsuariosFiltro.AllowUserToAddRows = false;
        }

        private void dgvDatosUsuariosFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesUsuario.TipoUsuario1 = dgvDatosUsuariosFiltro.CurrentRow.Cells["USUARIO"].Value.ToString();
            VariablesUsuario.NombreUsuario = dgvDatosUsuariosFiltro.CurrentRow.Cells["NOMBRE USUARIO"].Value.ToString();
            VariablesUsuario.IdUsuario = dgvDatosUsuariosFiltro.CurrentRow.Cells["CLAVE"].Value.ToString();

            this.Close();
        }
    }
}
