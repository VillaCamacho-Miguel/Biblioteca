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
    public partial class frmConsultaLibroIndividual : Form
    {
        public frmConsultaLibroIndividual()
        {
            InitializeComponent();
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibrosIndividual(cmbLibros.SelectedValue.ToString());
            dgvLibroIndividual.DataSource = tabla;

        }

        private void frmConsultaLibroIndividual_Load(object sender, EventArgs e)
        {
            DataTable tabla = NLibro.ObtenLibros();
            cmbLibros.ValueMember = "CLAVE";
            cmbLibros.DisplayMember = "NOMBRE DEL LIBRO";
            cmbLibros.DataSource = tabla;
            cmbLibros.SelectedIndex = 0;

            cmbLibros.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbLibros.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbLibros.AutoCompleteCustomSource = AutoComplete(tabla, "NOMBRE DEL LIBRO");
        }
        public AutoCompleteStringCollection AutoComplete(DataTable dt, string valor)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows) collection.Add(row[valor].ToString());
            return collection;
        }
    }
}
