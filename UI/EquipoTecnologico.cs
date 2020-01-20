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
    public partial class EquipoTecnologico : Form
    {
        public Control control { get; set; }
        public EquipoTecnologico(Control control)
        {
            this.control = control;
            InitializeComponent();

        }

        public void llenarGrid(int idAula)
        {

            //string idAula = (lblAula.Text);

            TablaEquipo.Rows.Clear();



            ListaActivosPorAulas listado = new ListaActivosPorAulas();
            listado = ActivoBLL.ListadoActivosTecnoligicosPorAulas(1);

            for (int i = 0; i < listado.Listado.Count(); i++)
            {
                TablaEquipo.Rows.Add();

                TablaEquipo.Rows[i].Cells["Identificacion"].Value = listado.Listado[i].Identificacion.Trim();
                TablaEquipo.Rows[i].Cells["Descripcion"].Value = listado.Listado[i].Descripcion;
                TablaEquipo.Rows[i].Cells["Marca"].Value = listado.Listado[i].Marca;
                TablaEquipo.Rows[i].Cells["Ubicacion"].Value = listado.Listado[i].Ubicacion;
                TablaEquipo.Rows[i].Cells["Proveedor"].Value = listado.Listado[i].Proveedor;
                TablaEquipo.Rows[i].Cells["NombreCategoria"].Value = listado.Listado[i].NombreCategoria;
                TablaEquipo.Rows[i].Cells["NombreAula"].Value = listado.Listado[i].NombreAula;
                TablaEquipo.Rows[i].Cells["Estados"].Value = listado.Listado[i].Estados;

            }


        }











        private void EquipoTecnologico_Load(object sender, EventArgs e)
        {

        }

        private void TablaEquipo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string idSeleccionado = TablaEquipo.Rows[TablaEquipo.CurrentRow.Index].Cells[0].Value.ToString();

            control.EquipoSeleccionado = idSeleccionado;

            control.AbrirFormAgregarEquipoTecnologico(idSeleccionado);

           
        }

        private void TablaTecnologico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
   
        }

        private void TablaEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
