using BLL.Activos;
using Entidades.Activos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reporte
{
    public partial class ReporteReparacionesporActivo : Form
    {
        public Control control { get; set; }
        public ReporteReparacionesporActivo(Control control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void ReporteReparacionesporActivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.SPReporteReparacionesporActivo' table. You can move, or remove it, as needed.
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void númeroDeActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.SPReporteReparacionesporActivoTableAdapter.Fill(this.DataSetPrincipal.SPReporteReparacionesporActivo, (tstxtActivo.Text.ToString().Trim()));

            this.reportViewer1.RefreshReport();
        }
    }
}
