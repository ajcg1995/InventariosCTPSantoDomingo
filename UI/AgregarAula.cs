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
    public partial class AgregarAula : Form
    {
        public Control control{ get; set; }

        public AgregarAula(Control control)
        {
            

            this.control = control;

            InitializeComponent();


            ListaTipoAula listadoTipoAula = TipoAulaBLL.ListadoTipoAula();


            //Asigar lista al combo
            cmbTipoAula.DataSource = listadoTipoAula.ListadoTipoAula;

            //Asingar cual elemento de la lista se verá en pantalla
            cmbTipoAula.DisplayMember = "Tipo";

            //Asignar cual elemento va por detrás.
            cmbTipoAula.ValueMember = "IdTipoAula";

            cmbTipoAula.SelectedIndex = -1;
        }

        private void AgregarAula_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAula_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAceptarAula_Click(object sender, EventArgs e)
        {

            BorrarError();
            if (ValidarCampos())
            {
                if (txtNombreAula.Text == "")
                {

                    MessageBox.Show("No puede dejar campos en blanco");

                }
                else

                {
                    /*
                    Aula a = new Aula();


                    a.atributo

                    */
                    Aula aulas = new Aula
                    {
                        NombreAula = txtNombreAula.Text,
                        IdTipoAula = int.Parse(cmbTipoAula.SelectedValue.ToString()),
                        IdControllUsuario = 1

                    };


                    ResultadoPorSP resultado = AulaBLL.AgregarAula(aulas, control.MiUsuario);

                    MessageBox.Show("Insertado Correctamente");

                    control.refrescarTablaAulas();

                    this.Visible = false;

                    limpiartxt();


                }
            }
            else
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }

        public void limpiartxt() {
            txtNombreAula.Text = "";

        }





        private void label2_Click(object sender, EventArgs e)
        {

        }
        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreAula.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreAula, "Ingrese el nombre del Aula");
            }
            if (cmbTipoAula.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbTipoAula, "Marque el Tipo");
            }
           
            return ok;


        }
        private void BorrarError()
        {
            errorProvider1.SetError(txtNombreAula, "");
            errorProvider1.SetError(cmbTipoAula, "");
            
        }
        private void txtNombreAula_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbTipoAula.SelectedItem = null;
            //cmbTipoAula.SelectedText = "--select--";
            
        }

        private void txtNombreAula_KeyPress(object sender, KeyPressEventArgs e)
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
