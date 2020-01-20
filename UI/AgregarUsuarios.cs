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
using System.Text.RegularExpressions;

namespace UI
{
    public partial class AgregarUsuarios : Form
    {
        public Control control { get; set; }

        public AgregarUsuarios(Control control)
        {
            this.control = control;

            InitializeComponent();
    
            List<Rol> listadoRoles = RolBLL.ListadoRoles();

            //Asigar lista a combo
            cmbRol.DataSource = listadoRoles;

            //Asignar elemento que se vera en la pantalla
            cmbRol.DisplayMember = "RolUsuario";

            //Asignar cual elemento va por detras
            cmbRol.ValueMember = "IdRol";
            cmbRol.SelectedIndex = -1;

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }


        private void btnCancelarAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Desaparecer el boton modificar
            btnModificar.Visible = false;

            btnAceptarAgregarUsuario.Visible = true;


            this.Visible = false;

            LimpiarCajasTexto();
        }

        private void btnAceptarAgregarUsuario_Click(object sender, EventArgs e)
        {

            //FALTAN VALIDAR LOS TXT


            BorrarError();
            if (ValidarCampos())
            {
                if (txtConfirmarcontrasena.Text != txtContraseña.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");

                }
                else
                {

                    Usuario usuarios = new Usuario
                    {
                        Nombre = txtNombreUsuario.Text,
                        Apellido = txtApellidoUsuario.Text,
                        Correo = txtCorreo.Text,
                        password = txtContraseña.Text,
                        IdRol = int.Parse(cmbRol.SelectedValue.ToString())
                    };

                    Usuario u = UsuarioBLL.verificarSiExiste(txtCorreo.Text);

                    if (u != null)
                    {
                        MessageBox.Show("Usuario ya existe");
                    }
                    else {
                        UsuarioBLL.AgregarUsuario(usuarios);

                        MessageBox.Show("Usuario creado correctamente");

                        control.refrescarTablaUsuarios();
                        this.Visible = false;

                    }



                }

                LimpiarCajasTexto();
            }
            else
            {
                MessageBox.Show("Error al ingresar datos");
            }

        }
        public bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombreUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreUsuario, "Ingrese Nombre");
            }
            if (txtApellidoUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellidoUsuario, "Ingrese Apellido");
            }
            if (txtCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Ingrese Correo");
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseña, "Ingrese Contraseña");
            }
            if (txtConfirmarcontrasena.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtConfirmarcontrasena, "Contraseña no Coincide");
            }
            if (cmbRol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbRol, "Ingrese el tipo de Rol");
            }
            /*if (IdUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(IdUsuario, "Ingrese el Id del Usuario");
            }*/
            return ok;


        }
        private void BorrarError()
        {
            errorProvider1.SetError(txtNombreUsuario, "");
            errorProvider1.SetError(txtApellidoUsuario, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtContraseña, "");
            errorProvider1.SetError(txtConfirmarcontrasena, "");
            errorProvider1.SetError(cmbRol, "");
            errorProvider1.SetError(IdUsuario, "");
        }

        public void LlenarFormParaModificar(Usuario usuario) {
            //desaparecer el boton agregar
            btnAceptarAgregarUsuario.Visible = false;

            //aparecer el bonton modidicar
            btnModificar.Visible = true;

            //Cargar el formulario con los datos
            txtNombreUsuario.Text = usuario.Nombre;
            txtApellidoUsuario.Text = usuario.Apellido;
            txtCorreo.Text = usuario.Correo;
            txtContraseña.Text = usuario.password;
            txtConfirmarcontrasena.Text = usuario.password;
            cmbRol.SelectedValue = usuario.IdRol;
            IdUsuario.Text = usuario.IdUsuario.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtConfirmarcontrasena.Text != txtContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");

            }
            else
            {

                if (cmbRol.SelectedValue != null)
                {
                    Usuario usuarios = new Usuario
                    {
                        Nombre = txtNombreUsuario.Text,
                        Apellido = txtApellidoUsuario.Text,
                        Correo = txtCorreo.Text,
                        password = txtContraseña.Text,
                        IdRol = int.Parse(cmbRol.SelectedValue.ToString()),
                        IdUsuario = int.Parse(IdUsuario.Text)

                    };

                    UsuarioBLL.ModificarUsuario(usuarios);



                    MessageBox.Show("Usuario Modificado correctamente");

                    control.refrescarTablaUsuarios();
                    this.Visible = false;
                    LimpiarCajasTexto();
                }
                else {
                    MessageBox.Show("No dejar campos en blanco");
                
                }


            }
            
            
        }

        private void LimpiarCajasTexto() {

            txtNombreUsuario.Text = "";
            txtApellidoUsuario.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            IdUsuario.Text = "";
            txtConfirmarcontrasena.Text = "";
        }

        private void txtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void IdUsuario_Validating(object sender, CancelEventArgs e)
        {
            int num;
                if(!int.TryParse(IdUsuario.Text,out num))
            {
                errorProvider1.SetError(IdUsuario, "Ingrese valor en números");
            }
            else
            {
                errorProvider1.SetError(IdUsuario, "");
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
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
                MessageBox.Show("Ingrese solo Letras", "Validación de Texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          
        }
         public static bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {return true; }

                else
                {return false; }
            }
            else
            { return false; }



        }
        

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
             if (validarEmail(txtCorreo.Text))
            {

            }else
            {
                MessageBox.Show("Direccion de  correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " + "por favor seleccione un correo valido", "Validación de Correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.SelectAll();
                txtCorreo.Focus();
            }
        }

        private void txtApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
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
                MessageBox.Show("Ingrese solo Letras", "Validación de Texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-') && (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains(".") || !txtCorreo.Text.Contains("_") || !txtCorreo.Text.Contains("-")))
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

        private void txtConfirmarcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-') && (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains(".") || !txtCorreo.Text.Contains("_") || !txtCorreo.Text.Contains("-")))
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
