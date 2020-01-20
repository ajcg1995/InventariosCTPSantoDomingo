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
    public partial class Reparaciones : Form
    {
        public Control control { get; set; }

        public Reparaciones(Control control)
        {
            InitializeComponent();
            this.control = control;            
        }

        private void Reparaciones_Load(object sender, EventArgs e)
        {

        }
        
        public void llenarGridActivosEnReparacion()
        {
            TablaEquipo.Rows.Clear();
            ListadoActivoReparacion listado = ActivoBLL.ListadoActivosReparacion();


            int index = 0; 
            for (int i = 0; i < listado.Listado.Count(); i++)
            {
                if (listado.Listado[i].DetalleReparacion == null)
                {
                    TablaEquipo.Rows.Add();
                    TablaEquipo.Rows[index].Cells["IdReparacion"].Value = listado.Listado[i].IdReparacion;
                    TablaEquipo.Rows[index].Cells["Identificacion"].Value = listado.Listado[i].Identificacion.Trim();
                    TablaEquipo.Rows[index].Cells["Descripcion"].Value = listado.Listado[i].Descripcion;
                    TablaEquipo.Rows[index].Cells["DetalleReparacion"].Value = listado.Listado[i].DetalleReparacion;

                    index++;
                }



            }



        }

        private void TablaEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (TablaEquipo.Rows[TablaEquipo.CurrentRow.Index].Cells[0].Value != null)
            {
                if (this.TablaEquipo.Columns[e.ColumnIndex].Name == "Reparado")
                {
                    int idSeleccionado = Convert.ToInt32(TablaEquipo.Rows[TablaEquipo.CurrentRow.Index].Cells[0].Value.ToString());
                    control.cargarReparaciones(idSeleccionado);
                    control.abrirFormularioReparacion();
                }
            }       


        }
    }
}
