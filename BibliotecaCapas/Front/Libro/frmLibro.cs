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
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(txtExistencia.Text.Length != 0 && txtISBN.Text.Length != 0 && txtNombreLibro.Text.Length != 0)
            {
                //validar componentes, todo ya está validado
                string isbn = txtISBN.Text;
                string nombreLibro = txtNombreLibro.Text;
                string respuesta = "";
                try
                {
                    respuesta = NLibro.BuscarNombreLibro(nombreLibro);
                    if (respuesta.Equals("YA EXISTE"))
                    {
                        MessageBox.Show("Nombre del libro duplicado");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    return;
                }
                try
                {
                    if (NAutor.BuscarNombreAutor(cmbAutor.Text).Equals("PROCEDE"))
                    {
                        MessageBox.Show("Verificar nombre AUTOR");
                        return;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                int autor = Convert.ToInt32(cmbAutor.SelectedValue.ToString()); // NAutor.BuscaClaveAutor(cmbAutor.SelectedItem.ToString());

                try
                {
                    if (NEdtitorial.BuscarNombreEditorial(cmbEditoriales.Text).Equals("NO EXISTE"))
                    {
                        MessageBox.Show("Verificar nombre EDITORIAL");
                        return;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                //camiar a selected item cuando cmb tenga elementos
                int editorial = Convert.ToInt32(cmbEditoriales.SelectedValue.ToString());//NEdtitorial.BuscaClaveEditorial(cmbEditoriales.SelectedItem.ToString());

                
                byte existencia = Convert.ToByte(txtExistencia.Text);
                char consulta = rbInterno.Checked ? '1' : '0';
                char tipoUsuario = cbAlumno.Checked ? '0' : '1';
                if (cbAlumno.Checked && cbMaestro.Checked) tipoUsuario = '2';
                if (!cbMaestro.Checked && !cbAlumno.Checked)
                {
                    MessageBox.Show("Seleccione el tipo de usuario");
                    return;
                }
                //MessageBox.Show(isbn + ", " + nombreLibro + ", " + existencia + ", " + consulta + ", " + tipoUsuario + ", " + autor + ", " + editorial);
                ELibro libro = new ELibro(isbn, nombreLibro, existencia, consulta, tipoUsuario, autor, editorial);

                try
                {

                    respuesta = NLibro.Agregar(libro);
                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Libro Agregado");
                        btnLimpiar_Click(sender, e);
                    }
                    if (respuesta.Equals("YA EXISTE"))
                    {
                        MessageBox.Show("ISBN ya existe");

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Verifica Campos Vacíos!");
            }
            
        
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            DataTable tabla = NEdtitorial.ObtenEditoriales();
            this.cmbEditoriales.ValueMember = "ID";
            this.cmbEditoriales.DisplayMember = "EDITORIAL";
            cmbEditoriales.DataSource = tabla;
            cmbEditoriales.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbEditoriales.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbEditoriales.AutoCompleteCustomSource = AutoComplete(tabla, "EDITORIAL");

            tabla = NAutor.ObtenAutores();
         
            this.cmbAutor.ValueMember = "id";
            this.cmbAutor.DisplayMember = "AUTOR";
            cmbAutor.DataSource = tabla;


            // Filtrar datos con el teclado
            cmbAutor.SelectedIndex = 0;
            cmbEditoriales.SelectedIndex = 0;

            cmbAutor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbAutor.AutoCompleteCustomSource = AutoComplete(tabla, "AUTOR");

        
        }
    
        public AutoCompleteStringCollection AutoComplete(DataTable dt, string valor)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows) collection.Add(row[valor].ToString());
                    return collection;
        }
        private void txtNombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetterOrDigit(e.KeyChar)&& !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarDatos fcd = new frmConsultarDatos();
            fcd.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtISBN.Text = "";
            txtExistencia.Text = "";
            txtNombreLibro.Text = "";
        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbEditoriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbUso_Enter(object sender, EventArgs e)
        {

        }

        private void cmbAutor_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarLibro fel = new frmEliminarLibro();
            fel.ShowDialog();

        }

        private void txtNombreLibro_TextChanged(object sender, EventArgs e)
        {

        }
        public bool validaTexto(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena) || string.IsNullOrEmpty(cadena))
            {
                return false;

            }
            return true;
        }
        public void valida(TextBox txt)
        {
            string dato = txt.Text;
            if (validaTexto(dato))
            {

                errorP.SetError(txt, "");
            }
            else
            {
                errorP.SetError(txt, "nombreVacio");
                txt.Focus();
            }

        }
        private void txtISBN_Validated(object sender, EventArgs e)
        {
            valida(sender as TextBox);
        }
    }
}
