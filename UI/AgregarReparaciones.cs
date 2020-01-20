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

namespace UI
{
    public partial class AgregarReparaciones : Form
    {

        public Control control { get; set; }




        public AgregarReparaciones(Control control)
        {
            InitializeComponent();

            this.control = control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
                Reparacion r = new Reparacion
                {

                    IdReparacion = Convert.ToInt32(txtIdRep.Text),
                    Identificacion = txtId.Text,
                    DetalleReparacion = txtReparacion.Text,
                    FechaReparacion = dtpReparacion.Value.ToString(),


                };


                ReparacionBLL.Modificar(r, control.MiUsuario);


                MessageBox.Show("Activo Reparado");


                this.Visible = false;

                limpiarTxt();

                control.RefrescarTablaReparaciones();
            }
            else
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }



        public void limpiarTxt() {
            txtIdRep.Text = "";
            txtId.Text = "";
            txtReporte.Text = "";
            txtReparacion.Text = "";
            

        }
        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtIdRep.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdRep, "Ingrese ID");
            }
            if (txtId.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtId, "Ingrese ID");
            }
            if (txtReporte.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtReporte, "Ingrese Reporte");
            }
            if (dtpReporte.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpReporte, "Ingrese Fecha");
            }
            if (dtpReparacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dtpReparacion, "Ingrese Fecha");
            }
            if (txtReparacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtReparacion, "Ingrese Detalle");
            }
         
            return ok;


        }
        private void BorrarError()
        {
            
            errorProvider1.SetError(txtReporte, "");
            errorProvider1.SetError(txtIdRep, "");
            errorProvider1.SetError(txtId, "");
            errorProvider1.SetError(dtpReporte, "");
            errorProvider1.SetError(dtpReparacion, "");
            errorProvider1.SetError(txtReparacion, "");
        }
        public void cargarReparacion(int id) {

            Reparacion r = ReparacionBLL.BuscarReparacion(id);

            txtIdRep.Text = r.IdReparacion.ToString();
            txtId.Text = r.Identificacion;
            txtReporte.Text = r.DetalleReporte;
            dtpReporte.Value = Convert.ToDateTime(r.FechaReporte);
            txtReparacion.Text = r.DetalleReparacion;

        }

        

        private void AgregarReparaciones_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtReparacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtReporte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIdRep_KeyPress(object sender, KeyPressEventArgs e)
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
