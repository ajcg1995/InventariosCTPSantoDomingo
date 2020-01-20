using BLL.Usuarios;
using Entidades.Usuarios;
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
    public partial class Usuarios : Form
    {
        public Control control { get; set; }

        public Usuarios(Control control)
        {
            this.control = control;

            InitializeComponent();

            llenarGrid();
        }


        public void llenarGrid() {

            TableUsuarios.Rows.Clear();

            ListadoUsuarioCompleto listado = UsuarioBLL.ListadoCompletoUsuario();



            for (int i = 0; i < listado.ListaUsuarios.Count(); i++)
            {
                TableUsuarios.Rows.Add();
                TableUsuarios.Rows[i].Cells["IdUsuario"].Value = listado.ListaUsuarios[i].IdUsuario;
                TableUsuarios.Rows[i].Cells["Nombre"].Value = listado.ListaUsuarios[i].Nombre;
                TableUsuarios.Rows[i].Cells["Apellido"].Value = listado.ListaUsuarios[i].Apellido;
                TableUsuarios.Rows[i].Cells["Correo"].Value = listado.ListaUsuarios[i].Correo;
                TableUsuarios.Rows[i].Cells["Password"].Value = listado.ListaUsuarios[i].Passwords;
                TableUsuarios.Rows[i].Cells["IdRol"].Value = listado.ListaUsuarios[i].RolUsuario;


            }


        }





        private void button1_Click(object sender, EventArgs e)
        {
            control.AbrirFormAgregarUsuarios();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void TableUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableUsuarios_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TableUsuarios.SelectedRows[0].Cells["IdUsuario"].Value != null)
            {
                string IdUsuario = TableUsuarios.SelectedRows[0].Cells["IdUsuario"].Value.ToString();


                Usuario usuario = UsuarioBLL.BuscarUsuario(Int32.Parse(IdUsuario));

                control.llenarFormularioBuscarUsuario(usuario);

            }



    

            //MessageBox.Show(i.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcel(TableUsuarios);
        }
    }
}
