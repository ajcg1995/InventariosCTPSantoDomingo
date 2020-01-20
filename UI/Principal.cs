using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class Principal : Form
    {

        public Control control { get; set; }

        public Principal(Control control)
        {
            this.control = control;
            InitializeComponent();
        }

        public Principal()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {

                MenuVertical.Width = 70;

            }
            else {
                MenuVertical.Width = 250;
            }




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaura.Visible = true;
            icoMaximizar.Visible = false;
        }

        private void icoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icoRestaurar.Visible = false;
            icoMaximizar.Visible = true;
        }

        private void icoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /*
        public void abrirFormEnPanel(Object FormHijo) {

            if (this.PanelContenedor.Controls.Count > 0) {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
                


            this.PanelContenedor.Controls.Clear();

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();


        }*/

        private void btnAulas_Click(object sender, EventArgs e)
        {
            control.AbrirFormAulas();
        }


        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSub.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.control.AbrirFormUsuario();
        }



        public Panel getPanelContenedor() {
            return PanelContenedor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.control.AbrirFormAdministracion();
        }

        private void restaura_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaura.Visible = false;
            icoMaximizar.Visible = true;
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            this.control.AbrirFormReporte1();

        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            this.control.AbrirFormReporte2();
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            this.control.AbrirFormReporte3();
        }
        private void btnReporte4_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            this.control.AbrirFormReporte4();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            control.AbrirFormReparaciones();

            control.RefrescarTablaReparaciones();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
