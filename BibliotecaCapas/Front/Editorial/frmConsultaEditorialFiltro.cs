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
    public partial class frmConsultaEditorialFiltro : Form
    {
        public frmConsultaEditorialFiltro()
        {
            InitializeComponent();
        }

        private void frmConsultaEditorialFiltro_Load(object sender, EventArgs e)
        {
            DataTable tabla = NEdtitorial.ObtenEditoriales();
            dgvEditorial.DataSource = tabla;

        }

        private void btnBuscarEdit_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltroEditorial.Text;
            DataTable tabla = NEdtitorial.ObtenEditorialesFiltro(filtro);
            dgvEditorial.DataSource = tabla;
        }

        private void dgvEditorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesEditorial.IdEditorial = dgvEditorial.CurrentRow.Cells["ID"].Value.ToString();
            VariablesEditorial.NombreEditorial = dgvEditorial.CurrentRow.Cells["EDITORIAL"].Value.ToString();
            VariablesEditorial.Telefono = dgvEditorial.CurrentRow.Cells["TELEFONO"].Value.ToString();
            VariablesEditorial.Direccion = dgvEditorial.CurrentRow.Cells["DIRECCION"].Value.ToString();
            VariablesEditorial.Ciudad = dgvEditorial.CurrentRow.Cells["CIUDAD"].Value.ToString();
            this.Close();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            DataTable tabla = NEdtitorial.ObtenEditoriales();
            dgvEditorial.DataSource = tabla;
        }
    }
}
