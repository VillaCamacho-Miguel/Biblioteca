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
    public partial class frmConsultaPrestamoFiltro : Form
    {
        public frmConsultaPrestamoFiltro()
        {
            InitializeComponent();
        }

        private void frmConsultaPrestamoFiltro_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = NPrestamo.ObtenPrestamos();
            dgvFiltraPrestamos.DataSource = tabla;
        }
    }
}
