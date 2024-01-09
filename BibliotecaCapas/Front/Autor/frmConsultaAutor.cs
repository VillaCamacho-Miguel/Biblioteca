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
    public partial class frmConsultaAutor : Form
    {
        public frmConsultaAutor()
        {
            InitializeComponent();
        }

        private void frmConsultaAutor_Load(object sender, EventArgs e)
        {
            DataTable tabla = NAutor.ObtenAutores();
            dataGridView1.DataSource = tabla;

        }
    }
}
