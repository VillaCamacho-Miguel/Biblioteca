using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Biblioteca.Negocio;
namespace Biblioteca.Front
{
    public partial class frmConsultarDatos : Form
    {
        public frmConsultarDatos()
        {
            InitializeComponent();
        }

        private void frmConsultarDatos_Load(object sender, EventArgs e)
        {

            DataTable cmd = NLibro.ObtenLibros();
            dgvConsultaDatos.DataSource = cmd;
            dgvConsultaDatos.Columns[1].Width = 175;
            dgvConsultaDatos.AllowUserToAddRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibrosFiltro(textBox1.Text);
            dgvConsultaDatos.DataSource = tabla;
            
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibros();
            dgvConsultaDatos.DataSource = tabla;

        }
    }
}
