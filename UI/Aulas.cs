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
    public partial class Aulas : Form
    {

        public Control control { get; set; }


        public void llenarDataGrid() {

            TableAulas.Rows.Clear();

            ListadoAulaCompleto listado = AulaBLL.ListadoCompletoAula();

            

            for (int i = 0; i < listado.ListadoAulas.Count(); i++)
            {

                TableAulas.Rows.Add();
                TableAulas.Rows[i].Cells["IdAula"].Value = listado.ListadoAulas[i].IdAula;
                TableAulas.Rows[i].Cells["Nombre"].Value = listado.ListadoAulas[i].NombreAula;
                TableAulas.Rows[i].Cells["Tipo"].Value = listado.ListadoAulas[i].Tipo;

            }

        }





        public Aulas(Control control)
        {

            this.control = control;

            InitializeComponent();

            llenarDataGrid();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.TableAulas.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                int idEliminar = Convert.ToInt32(TableAulas.Rows[TableAulas.CurrentRow.Index].Cells[0].Value);


                AulaBLL.EliminarAula(idEliminar);

                //Refrescar tabla
                control.refrescarTablaAulas();

            }
            else if (this.TableAulas.Columns[e.ColumnIndex].Name == "Ver") {

                int IdBuscar = Convert.ToInt32(TableAulas.Rows[TableAulas.CurrentRow.Index].Cells[0].Value);

                control.limpiarGridCaracteristicas();

                control.AbrirFormActivosPorAulas(IdBuscar);


                
            }                


            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Aulas_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.AbrirFormAgregarAulas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
