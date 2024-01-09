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

namespace Biblioteca.Front.Prestamo
{
    public partial class frmConsultarPrestamos : Form
    {
        public frmConsultarPrestamos()
        {
            InitializeComponent();
        }

        private void frmConsultarPrestamos_Load(object sender, EventArgs e)
        {
            DataTable tabla = NPrestamo.ObtenPrestamos();
            dataGridView1.DataSource = tabla;
        }
    }
}
