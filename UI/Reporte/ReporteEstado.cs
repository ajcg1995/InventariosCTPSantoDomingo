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
    public partial class ReporteEstado : Form
    {
        public Control control { get; set; }
        public ReporteEstado(Control control)
        {
            this.control = control;
            InitializeComponent();
            List<Estado> listaEstados = EstadoBLL.ListadoEstados();
            cmbEstado.DataSource = listaEstados; // Estados y Id

            //Muestra en pantalla 
            cmbEstado.DisplayMember = "Estados";

            //Por detras 
            cmbEstado.ValueMember = "IdEstado";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void ReporteEstado_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                    }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // //TODO: This line of code loads data into the 'DataSetPrincipal.SPReporteEstado' table. You can move, or remove it, as needed.
            this.SPReporteEstadoTableAdapter.Fill(this.DataSetPrincipal.SPReporteEstado, cmbEstado.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
