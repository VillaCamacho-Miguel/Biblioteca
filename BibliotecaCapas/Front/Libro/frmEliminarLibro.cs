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
    public partial class frmEliminarLibro : Form
    {
        public frmEliminarLibro()
        {
            InitializeComponent();
        }

        private void frmEliminarLibro_Load(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibros();
            dataGridView1.DataSource = tabla;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string isbn = dataGridView1.CurrentRow.Cells["CLAVE"].Value.ToString();
            try
            {

                string rpta = NLibro.Elimina(isbn);
                MessageBox.Show(rpta);
                DataTable tabla = NLibro.ObtenLibros();
                dataGridView1.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibrosFiltro(txtBuscar.Text);
            dataGridView1.DataSource = tabla;
        }
    }
}
