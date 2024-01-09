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

namespace Biblioteca.Front
{
    public partial class frmFiltraLibros : Form
    {
        public frmFiltraLibros()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         string txt = txtBuscar.Text;
                DataTable cmd = NLibro.ObtenLibrosFiltro(txt);
                dgvFiltraLibros.DataSource = cmd;
                dgvFiltraLibros.AllowUserToAddRows = false;

        }

        private void dgvFiltraLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Variables.Clave = dgvFiltraLibros.CurrentRow.Cells["CLAVE"].Value.ToString();
            Variables.NombreLibro = dgvFiltraLibros.CurrentRow.Cells["NOMBRE DEL LIBRO"].Value.ToString();
            Variables.Consulta = dgvFiltraLibros.CurrentRow.Cells["CONSULTA"].Value.ToString();
            Variables.TipoDeUsuario = dgvFiltraLibros.CurrentRow.Cells["TIPO DE USUARIO"].Value.ToString();
            Variables.Existencia = dgvFiltraLibros.CurrentRow.Cells["EXISTENCIA"].Value.ToString();
            Variables.Editorial = dgvFiltraLibros.CurrentRow.Cells["EDITORIAL"].Value.ToString();
            Variables.Autor = dgvFiltraLibros.CurrentRow.Cells["AUTOR"].Value.ToString();

            this.Close();
            
        }

        private void frmFiltraLibros_Load(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibros();
            dgvFiltraLibros.DataSource = tabla;
            dgvFiltraLibros.AllowUserToAddRows = false;
            Variables.Clave = "";
            Variables.NombreLibro = "";
            Variables.Consulta = "";
            Variables.TipoDeUsuario = "";
            Variables.Existencia = "";
            Variables.Editorial = "";
            Variables.Autor = "";

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibros();
            dgvFiltraLibros.DataSource = tabla;
            dgvFiltraLibros.AllowUserToAddRows = false;
        }
    }
}
