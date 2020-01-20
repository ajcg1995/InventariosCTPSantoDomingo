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
    public partial class ReporteActivos : Form
    {
        public Control control { get; set; }
        public ReporteActivos(Control control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void ReporteActivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.SPReportesActivos' table. You can move, or remove it, as needed.
            }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.SPReportesActivosTableAdapter.Fill(this.DataSetPrincipal.SPReportesActivos, dtpFechaInicial.Value, dtpFechaFinal.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
