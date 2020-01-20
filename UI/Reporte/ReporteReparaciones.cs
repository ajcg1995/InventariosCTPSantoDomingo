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
    public partial class ReporteReparaciones : Form
    {
        public Control control { get; set; }
        public ReporteReparaciones(Control control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void ReporteReparaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPrincipal.SPReporteReparaciones' table. You can move, or remove it, as needed.
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.SPReporteReparacionesTableAdapter.Fill(this.DataSetPrincipal.SPReporteReparaciones);

            this.reportViewer1.RefreshReport();

        }
    }
}
