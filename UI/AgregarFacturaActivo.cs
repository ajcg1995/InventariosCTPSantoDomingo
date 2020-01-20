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
    public partial class AgregarFacturaActivo : Form
    {
        public AgregarFacturaActivo(Control control)
        {
            InitializeComponent();
            cmbMoneda.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarFacturaActivo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAceptarFacturaActivo_Click(object sender, EventArgs e)
        {

        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
