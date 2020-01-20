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
    public partial class ActivosPorAulas : Form
    {
        public Control control { get; set; }

        public ActivosPorAulas(Control control)
        {
            this.control = control;
            InitializeComponent();          
        }

        public void llenarGrid(int idBuscar) {
            string idAula = (lblAula.Text);
            TableActivos.Rows.Clear();
                ListaActivosPorAulas listado = ActivoBLL.ListadoActivosPorAulas(Convert.ToInt32(idBuscar));
            
                for (int i = 0; i < listado.Listado.Count(); i++)
                {
                    TableActivos.Rows.Add();
                    TableActivos.Rows[i].Cells["Identificacion"].Value = listado.Listado[i].Identificacion;
                    TableActivos.Rows[i].Cells["Descripcion"].Value = listado.Listado[i].Descripcion;
                    TableActivos.Rows[i].Cells["Marca"].Value = listado.Listado[i].Marca;
                    TableActivos.Rows[i].Cells["Ubicacion"].Value = listado.Listado[i].Ubicacion;
                    TableActivos.Rows[i].Cells["Proveedor"].Value = listado.Listado[i].Proveedor;
                    TableActivos.Rows[i].Cells["FechaCreacion"].Value = listado.Listado[i].FechaCreacion;
                    TableActivos.Rows[i].Cells["Depreciacion"].Value = listado.Listado[i].Depreciacion;
                    TableActivos.Rows[i].Cells["LeyAdquirida"].Value = listado.Listado[i].LeyAdquirida;
                    TableActivos.Rows[i].Cells["NombreCategoria"].Value = listado.Listado[i].NombreCategoria;
                    TableActivos.Rows[i].Cells["NombreAula"].Value = listado.Listado[i].NombreAula;
                    TableActivos.Rows[i].Cells["Estados"].Value = listado.Listado[i].Estados;

                }            
        }

        private void ActivosPorAulas_Load(object sender, EventArgs e)
        {
            
        }

        //Metodo para retornar el lable que contiene el numero de Aula
        public Label retornarLblNumeroAula()
        {
            return lblAula;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.AbrirFormAulas();
        }

        private void TableActivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (TableActivos.Rows[TableActivos.CurrentRow.Index].Cells[0].Value != null) {

                string idSeleccionado = TableActivos.Rows[TableActivos.CurrentRow.Index].Cells[0].Value.ToString();

                if (idSeleccionado != "")
                {
                    control.buscarActivo(idSeleccionado);

                    //Llenar Grid Caracteristica
                    llenarGridCaracteristicas(idSeleccionado);

                }
            }



            




        }

        private void TableActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            control.AbrirFormAgregarActivo();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (TableActivos.SelectedRows[0].Cells["Identificacion"].Value != null)
            {
                string idActivo = TableActivos.SelectedRows[0].Cells["Identificacion"].Value.ToString();

                control.buscarActivo(idActivo.Trim());
            }
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            control.AbrirFormEquipoTecnologico();

            control.RefrescarTablaActivosTecnoligicosPorAulas(Convert.ToInt32(lblAula.Text));
        }

        private void btnEnviarReparacion_Click(object sender, EventArgs e)
        {
            if (TableActivos.SelectedRows[0].Cells["Identificacion"].Value != null)
            {

                string idActivo = TableActivos.SelectedRows[0].Cells["Identificacion"].Value.ToString();

                Activo activo = control.buscarActivoReparar(idActivo.Trim());

                if (activo.IdEstado == 2)
                {
                    MessageBox.Show("Activo ya se encuentra en reparacion");
                }
                else
                {

                    control.CargarActivoReparacion(activo);

                    control.AbrirFormAgregarDetalleReporte();



                }


            }



            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcel(TableActivos);
           
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        public void limpiarGridCaracteristicas() {
            TablaCaract.Rows.Clear();
        }

        public void llenarGridCaracteristicas(string identificacion)
        {
            TablaCaract.Rows.Clear();

            ListadoCapacidad listado = new ListadoCapacidad();
            listado = CapacidadBLL.ListarCapacidadPorId(identificacion);

            for (int i = 0; i < listado.listado.Count(); i++)
            {
                TablaCaract.Rows.Add();
                TablaCaract.Rows[i].Cells["Id"].Value = listado.listado[i].IdCapacidad;
                TablaCaract.Rows[i].Cells["Detalle"].Value = listado.listado[i].Detalle;

            }

        }

        private void TablaCaract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (TableActivos.Rows.Count > 1) {

                string idSeleccionado = TableActivos.Rows[TableActivos.CurrentRow.Index].Cells[0].Value.ToString();

                control.EquipoSeleccionado = idSeleccionado;

                control.AbrirFormAgregarEquipoTecnologico(idSeleccionado);

            }

        }

        private void TableActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TableActivos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaCaract_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.TablaCaract.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                if (TablaCaract.Rows[TablaCaract.CurrentRow.Index].Cells[0].Value != null)
                {
                    int idBuscar = Convert.ToInt32(TablaCaract.Rows[TablaCaract.CurrentRow.Index].Cells[0].Value);

                    //Donde esta selecionado el activo que querems eliminar
                    string idSeleccionado = TableActivos.Rows[TableActivos.CurrentRow.Index].Cells[0].Value.ToString();

                    Capacidad capacidad = CapacidadBLL.BuscarCapacidad(idBuscar);

                    CapacidadBLL.EliminarCapacidad(capacidad);

                    MessageBox.Show("Activo Eliminado");

                    llenarGridCaracteristicas(idSeleccionado.Trim());

                }



            }
        }
    }
}
