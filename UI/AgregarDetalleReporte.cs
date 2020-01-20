using BLL.Activos;
using Entidades;
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

namespace UI
{
    public partial class AgregarDetalleReporte : Form
    {
        public Control control { get; set; }

        public Activo ActivoReparacion { get; set; }
        public AgregarDetalleReporte(Control control)
        {            
            InitializeComponent();
            this.control = control;
        }

        public void CargarActivoReparacion(Activo activo) {

            this.ActivoReparacion = activo;

        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarDetalleReporte_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAceptarDetalleReporte_Click(object sender, EventArgs e)
        {
            if (rtbDetalleReporte.Text == "")
            {

                MessageBox.Show("No puede dejar campos en blanco");

            }
            else

            {
                
                Reparacion reparaciones = new Reparacion
                {
                    DetalleReporte = rtbDetalleReporte.Text,
                    FechaReporte = dtpFechaReporte.Value.ToString(),
                    Identificacion = ActivoReparacion.Identificacion,
                    /*FechaReparacion = default(DateTime),
                    DetalleReparacion = "",*/
                };

                

                ReparacionBLL.AgregarReparacion(reparaciones, control.MiUsuario);

                MessageBox.Show("Insertado Correctamente");

                rtbDetalleReporte.Text = "";


                int idAula = Convert.ToInt32(control.getLabelNumeroAula().Text);

                control.RefrescarTablaActivosPorAulas(idAula);

                this.Visible=false;
            }
        }

        private void dtpFechaReporte_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarDetalleReporte_Load(object sender, EventArgs e)
        {

        }

        private void rtbDetalleReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-'))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Caracteres Invalido", "Validación de Texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
