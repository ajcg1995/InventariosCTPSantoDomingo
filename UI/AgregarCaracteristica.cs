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
    public partial class AgregarCaracteristica : Form
    {
        public Control control { get; set; }


        //esta variable se carga cada vez que se agrega un activo, esto para poder recargar el grid
        public string IdActivo{ get; set; }

        public AgregarCaracteristica(Control control)
        {
            InitializeComponent();

            this.control = control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCapacidad.Text != "")
            {
                Capacidad capacidad = new Capacidad
                {
                    Detalle = txtCapacidad.Text,
                    Identificacion = control.EquipoSeleccionado
                };

                CapacidadBLL.AgregarCapacidad(capacidad);

                txtCapacidad.Text = "";

                control.llenarGridCaractesiticas(IdActivo.Trim());
                this.Visible = false;
            }
            else {

                MessageBox.Show("No puedes dejar campos en blanco");
            }




        }

        private void AgregarCaracteristica_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
