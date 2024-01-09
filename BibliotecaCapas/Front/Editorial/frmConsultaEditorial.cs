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
    public partial class frmConsultaEditorial : Form
    {
        public frmConsultaEditorial()
        {
            InitializeComponent();
        }

        private void frmConsultaEditorial_Load(object sender, EventArgs e)
        {
            DataTable tabla = NEdtitorial.ObtenEditoriales();
            dataGridView1.DataSource = tabla;
        }
    }
}
