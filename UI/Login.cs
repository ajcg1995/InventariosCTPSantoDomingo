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
    public partial class Login : Form
    {
        public Control control { get; set; }

        public Login(Control control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuarios = control.verficarCredenciales(txtCorreo.Text, txtPassword.Text);


            if (usuarios != null)
            {
                this.Hide();

                control.abrirFormularioPrincipal();

                control.CargarUsuarioSesion(usuarios); //enviar mi usuario para cargar la variable de sesion.

                this.Visible = false;
            }
            else
            {


                msgerror("Ingrese las credenciales correctas");

                txtPassword.Text = "CONTRASEÑA";
                txtCorreo.Text = "USUARIO";

            }

        }

        private void msgerror(String msg)
        {
            lblerror.Text = "       " + msg;
            lblerror.Visible = true;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "USUARIO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;


            }
        }

        private void le(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "USUARIO";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void een(object sender, KeyPressEventArgs e)
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

        private void en(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if((e.KeyChar=='@' || e.KeyChar=='.' || e.KeyChar == '_' || e.KeyChar == '-') && (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains(".") || !txtCorreo.Text.Contains("_") || !txtCorreo.Text.Contains("-")))
            {
                e.Handled = false;
            }else if(char.IsDigit(e.KeyChar))
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
