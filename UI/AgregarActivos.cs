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
    public partial class AgregarActivos : Form
    {
        public Control control { get; set; }

        public AgregarActivos(Control control)
        {
            this.control = control;

            InitializeComponent();


            List<Ley> listadoLey = LeyBLL.ListarLeyes();

            List<Categoria> categorias = CategoriaBLL.ListaCategorias();

            List<Estado> listaEstados = EstadoBLL.ListadoEstados();


            //Combo boxLeyes
            cmbLeyAdquirida.DataSource = listadoLey;
            cmbLeyAdquirida.DisplayMember = "LeyAdquirida";
            cmbLeyAdquirida.ValueMember = "IdLeyAdquirida";


            //Combo Categorias
            cmbCategoría.DataSource = categorias;
            cmbCategoría.DisplayMember = "NombreCategoria";
            cmbCategoría.ValueMember = "IdCategoria";

            //Combo Estado
            cmbEstado.DataSource = listaEstados;
            cmbEstado.DisplayMember = "Estados";
            cmbEstado.ValueMember = "IdEstado";
            cmbLeyAdquirida.SelectedIndex = -1;
            cmbCategoría.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        private void btnCancelarActivos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AgregarActivos_Load(object sender, EventArgs e)
        {






        }

        public void ocultarBotonesAlAgregar()
        {
            btnModificar.Visible = false;
            btnAceptarActivos.Visible = true;
        }


        public void ocultarBotonesAlModificar()
        {
            btnModificar.Visible = true;
            btnAceptarActivos.Visible = false;
        }


        // Este metodo es para cargar los activos en el txt del form
        public void cargarActivos(Entidades.Activos.Activo activosPorAulas) {

            txtIdentificacionActivo.Text = activosPorAulas.Identificacion.ToString().Trim();
            txtDescripcion.Text = activosPorAulas.Descripcion.Trim();
            txtMarca.Text = activosPorAulas.Marca.Trim();
            txtUbicacion.Text = activosPorAulas.Ubicacion.Trim();


            txtProveedor.Text = activosPorAulas.Proveedor.Trim();
            //fechaCreacion.Text = activosPorAulas.FechaCreacion;

            //Ley Adquirida            
            cmbLeyAdquirida.SelectedValue = activosPorAulas.IdLeyAdquirida;

            //Categoria
            cmbCategoría.SelectedValue = activosPorAulas.IdCategoria;

            //Estado
            cmbEstado.SelectedValue = activosPorAulas.IdEstado;
            //Drepresiacion




        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarActivos_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
                // Validar los campos en blanco

                string NumAula = (control.getLabelNumeroAula().Text);


                int AulaInsertarActivo = Convert.ToInt32(NumAula);

                double Depreciacion;
                int numFactura;
                string fecha;




                fecha = fechaCreacion.Value.ToString("yyyy-MM-dd");


                Activo activos = new Activo
                {
                    Identificacion = txtIdentificacionActivo.Text,
                    Descripcion = txtDescripcion.Text,
                    Marca = txtMarca.Text,
                    Ubicacion = txtUbicacion.Text,
                    Proveedor = txtProveedor.Text,
                    //FechaCreacion = fecha,
                    IdLeyAdquirida = Int32.Parse(cmbLeyAdquirida.SelectedValue.ToString()),
                    IdCategoria = Int32.Parse(cmbCategoría.SelectedValue.ToString()),
                    IdAula = AulaInsertarActivo,
                    IdEstado = Int32.Parse(cmbEstado.SelectedValue.ToString()),
                    IdUsuario = control.MiUsuario.IdUsuario,


                    Depreciacion = "0"


                };



                Activo a = ActivoBLL.BuscarUnActivo(txtIdentificacionActivo.Text);

                if (a.Codigo == 99)
                {
                    ActivoBLL.AgregarActivo(activos, control.MiUsuario);

                    MessageBox.Show("Activo agregado Correctamente");

                    limpiartxt();
                    this.Visible = false;

                    control.RefrescarTablaActivosPorAulas(activos.IdAula);
                }
                else
                {
                    MessageBox.Show("Activo ya existe");
                }

            }
            else
            {
                MessageBox.Show("Error al ingresar datos");
            }

        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtIdentificacionActivo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdentificacionActivo, "Ingrese Identificación ");
            }
            if (txtDescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDescripcion, "Ingrese Descripción");
            }
            if (txtMarca.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMarca, "Ingrese Marca");
            }
            if (txtUbicacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUbicacion, "Ingrese Ubicación");
            }
            if (txtProveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProveedor, "Provedor Invalido");
            }
            if (fechaCreacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(fechaCreacion, "Ingrese Fecha");
            }
            if (cmbLeyAdquirida.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbLeyAdquirida, "Selececione la Ley");
            }
            if (cmbCategoría.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbCategoría, "Seleccione Categoría");
            }
            if (cmbEstado.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbEstado, "Seleccione el Estado");
            }
            
            return ok;


        }
        private void BorrarError()
        {
            errorProvider1.SetError(txtIdentificacionActivo, "");
            errorProvider1.SetError(txtDescripcion, "");
            errorProvider1.SetError(txtMarca, "");
            errorProvider1.SetError(txtUbicacion, "");
            errorProvider1.SetError(txtProveedor, "");
            errorProvider1.SetError(fechaCreacion, "");
            errorProvider1.SetError(cmbLeyAdquirida, "");
            errorProvider1.SetError(cmbCategoría, "");
            errorProvider1.SetError(cmbEstado, "");
        }
        private void chkFactura_CheckedChanged(object sender, EventArgs e)
        {


        }

        public void limpiartxt() {
            txtIdentificacionActivo.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtUbicacion.Text = "";
            txtProveedor.Text = "";


        }




        private void button1_Click(object sender, EventArgs e)
        {


            string NumAula = (control.getLabelNumeroAula().Text);


            int AulaInsertarActivo = Convert.ToInt32(NumAula);


            double Depreciacion;
            int numFactura;
            string fecha;



            fecha = fechaCreacion.Value.ToString("yyyy-MM-dd");


            Activo activos = new Activo
            {
                Identificacion = txtIdentificacionActivo.Text,
                Descripcion = txtDescripcion.Text,
                Marca = txtMarca.Text,
                Ubicacion = txtUbicacion.Text,
                //Revisado = Int32.Parse(cmbRevisado.SelectedValue.ToString()),
                Proveedor = txtProveedor.Text,
               // FechaCreacion = fecha,
                IdLeyAdquirida = Int32.Parse(cmbLeyAdquirida.SelectedValue.ToString()),
                IdCategoria = Int32.Parse(cmbCategoría.SelectedValue.ToString()),
                IdAula = AulaInsertarActivo,
                IdEstado = Int32.Parse(cmbEstado.SelectedValue.ToString()),
                IdUsuario = control.MiUsuario.IdUsuario,


                Depreciacion = "0"

                //FALTA DEPRESIACION

            };

            ActivoBLL.Modificar(activos, control.MiUsuario);

            MessageBox.Show("Modificado agregado Correctamente");

            limpiartxt();

            this.Visible = false;

            control.RefrescarTablaActivosPorAulas(activos.IdAula);
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLeyAdquirida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoría_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificacionActivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtUbicacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
