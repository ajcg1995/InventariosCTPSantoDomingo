using BLL.Activos;
using BLL.Usuarios;
using Entidades.Activos;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Reporte;

namespace UI
{
    public class Control
    {

        AgregarActivos agregarActivos;
        AgregarAula agregarAula;
        AgregarReparaciones agregarReparaciones;
        AgregarFacturaActivo agregarFacturaActivo;
        AgregarPrestadorServicio agregarPrestadorServicio;
        AgregarUsuarios agregarUsuarios;
        Principal principal;
        Usuarios usuarios;
        Aulas aulas;
        ActivosPorAulas activosPorAulas;
        Administracion administracion;
        Login login;
        ReporteActivos reporteActivos;
        ReporteEstado reporteEstado;
        ReporteReparaciones reporteReparaciones;
        ReporteReparacionesporActivo reporteReparacionesporActivo;
        EquipoTecnologico equipoTecnologico;
        AgregarCaracteristica agregarEquipoTecnologico;
        Reparaciones reparaciones;
        AgregarDetalleReporte agregarDetalleReporte;

        //Variable Usuarios la cual se carga al momento del Login

        public Usuario MiUsuario { get; set; }

        public string EquipoSeleccionado { get; set; }

        public Control() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            agregarActivos = new AgregarActivos(this);
            agregarAula = new AgregarAula(this);
            agregarFacturaActivo = new AgregarFacturaActivo(this);
            agregarPrestadorServicio = new AgregarPrestadorServicio(this);
            usuarios = new Usuarios(this);
            aulas = new Aulas(this);
            activosPorAulas = new ActivosPorAulas(this);
            administracion = new Administracion(this);
            agregarUsuarios = new AgregarUsuarios(this);
            principal = new Principal(this);
            reparaciones = new Reparaciones(this);
            reporteActivos = new ReporteActivos(this);
            reporteEstado = new ReporteEstado(this);
            reporteReparaciones = new ReporteReparaciones(this);
            reporteReparacionesporActivo = new ReporteReparacionesporActivo(this);

            agregarReparaciones = new AgregarReparaciones(this);

            equipoTecnologico = new EquipoTecnologico(this);
            agregarEquipoTecnologico = new AgregarCaracteristica(this);
            agregarDetalleReporte = new AgregarDetalleReporte(this);

            Application.Run(login = new Login(this));        

        }


        public void abrirFormualrioEnPanel(Object FormHijo,Panel contenedor)
        {
            if (contenedor.Controls.Count > 0)
            {
                contenedor.Controls.RemoveAt(0);
            }

            contenedor.Controls.Clear();
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            contenedor.Controls.Add(fh);
            contenedor.Tag = fh;
            fh.Show();
        }


        public void CargarUsuarioSesion(Usuario usuario) {

            this.MiUsuario = usuario;
        }



        public Panel PanelPrincipa() {
            return principal.getPanelContenedor();
        }

        public Label getLabelNumeroAula()
        {
            return activosPorAulas.retornarLblNumeroAula();
        }


        public void AbrirFormAulas()
        {
            abrirFormualrioEnPanel(aulas, PanelPrincipa());
        }

        public void AbrirFormEquipoTecnologico()
        {
            abrirFormualrioEnPanel(equipoTecnologico, PanelPrincipa());
        }

        public void AbrirFormUsuario()
        {
            abrirFormualrioEnPanel(usuarios, PanelPrincipa());
        }
        public void AbrirFormReporte1()
        {
            abrirFormualrioEnPanel(reporteActivos, PanelPrincipa());
        }
        public void AbrirFormReporte2()
        {
            abrirFormualrioEnPanel(reporteEstado, PanelPrincipa());
        }

        public void AbrirFormReporte3()
        {
            abrirFormualrioEnPanel(reporteReparaciones, PanelPrincipa());
        }

        public void AbrirFormReporte4()
        {
            abrirFormualrioEnPanel(reporteReparacionesporActivo, PanelPrincipa());
        }

        public void AbrirFormAdministracion()
        {
            abrirFormualrioEnPanel(administracion, PanelPrincipa());
        }

        public void AbrirFormReparaciones()
        {
            abrirFormualrioEnPanel(reparaciones, PanelPrincipa());
        }


        public void AbrirFormActivosPorAulas(int IdAula)
        {
            //Setear el numero de Aula en el formulario de ActivosPorAulas
            Label label = getLabelNumeroAula();
            label.Text = IdAula.ToString();
            activosPorAulas.llenarGrid(IdAula);
            abrirFormualrioEnPanel(activosPorAulas, PanelPrincipa());
            
        }

        public void limpiarGridCaracteristicas() {

            activosPorAulas.limpiarGridCaracteristicas();
        }

        public void abrirFormularioPrincipal() {

            principal.Show();
        }

        public void abrirFormularioReparacion() {
            agregarReparaciones.Show();
        }

        public void AbrirFormProveedor() {
            agregarPrestadorServicio.Show();
        }



        public void AbrirFormAgregarAulas() {
             agregarAula.Show();
        }


        public void AbrirFormAgregarEquipoTecnologico(string idSeleccionado)
        {
            agregarEquipoTecnologico.Show();

            agregarEquipoTecnologico.IdActivo = idSeleccionado;
        }




        public void AbrirFormAgregarUsuarios()
        {
            agregarUsuarios.Show();
        }

        public void AbrirFormAgregarDetalleReporte()
        {
            agregarDetalleReporte.Show();
        }

        public void AbrirFormAgregarActivo() {
            agregarActivos.Show();
            agregarActivos.ocultarBotonesAlAgregar();
        }



        public void refrescarTablaAulas() {
            aulas.llenarDataGrid();
        }


        public void refrescarTablaUsuarios() {
            usuarios.llenarGrid();

        }

        public void RefrescarTablaActivosPorAulas(int idAula) {
            activosPorAulas.llenarGrid(idAula);

        }


        public void RefrescarTablaReparaciones()
        {
            reparaciones.llenarGridActivosEnReparacion();

        }


        public void RefrescarTablaActivosTecnoligicosPorAulas(int idAula)
        {
            equipoTecnologico.llenarGrid(idAula);

        }

        public void llenarFormularioBuscarUsuario(Usuario usuario) {

            AbrirFormAgregarUsuarios();
            agregarUsuarios.LlenarFormParaModificar(usuario);
        }

        public void llenarGridCaractesiticas(string identificacion) {

            activosPorAulas.llenarGridCaracteristicas(identificacion);
        }

        public void cargarReparaciones(int id) {
            agregarReparaciones.cargarReparacion(id);
        }


        /** **************Metodos del login ***************************/

        public Usuario verficarCredenciales(string nombre, string password) {


            Usuario usuario = UsuarioBLL.VerificarCredenciales(nombre, password);

            return usuario;

        }

        public void CargarActivoReparacion(Activo activo) {
            agregarDetalleReporte.CargarActivoReparacion(activo);
        }















        /* ************** Metodos Form Activos Por Aula ***************/



        public void buscarActivo(string id) {

            var activoBuscado = ActivoBLL.BuscarUnActivo(id);

            agregarActivos.cargarActivos(activoBuscado); // llamo al metodo que carga el fomrulario
            agregarActivos.Show(); // muestr el form
            agregarActivos.ocultarBotonesAlModificar(); // oculto el btn modificar

        }

        public Activo buscarActivoReparar(string id)
        {

            var activoBuscado = ActivoBLL.BuscarUnActivo(id);

            return activoBuscado;

        }









    }
}
