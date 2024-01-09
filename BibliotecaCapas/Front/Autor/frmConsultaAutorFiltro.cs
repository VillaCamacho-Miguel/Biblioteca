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
    public partial class frmConsultaAutorFiltro : Form
    {
        public frmConsultaAutorFiltro()
        {
            InitializeComponent();
        }

        private void frmConsultaAutorFiltro_Load(object sender, EventArgs e)
        {
            DataTable tabla = NAutor.ObtenAutores();
            dataGridView1.DataSource = tabla;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string claveAutor = txtFiltroAutor.Text;
            DataTable tabla = NAutor.ObtenAutoresFiltro(claveAutor);
            dataGridView1.DataSource = tabla;
            dataGridView1.AllowUserToAddRows = false;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesAutor.IdAutor = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            VariablesAutor.NombreAutor = dataGridView1.CurrentRow.Cells["AUTOR"].Value.ToString();
            VariablesAutor.Nacionalidad = dataGridView1.CurrentRow.Cells["NACIONALIDAD"].Value.ToString();
            this.Close();
        }
    }
}
