using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Front
{
    public partial class frmReporte : Form
    {

        string tipoReporte;
        public frmReporte(string tipoReporte)
        {
            InitializeComponent();
            this.tipoReporte = tipoReporte;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = Path.GetFullPath(tipoReporte);
        }
    }
}
