using Entidades;
using Entidades.Usuarios;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Usuarios
{
    public class UsuarioDAL
    {

        public static Usuario VerificarCredenciales(string correo, string password)
        {

            try
            {
                var db = BDConn.Connector();


                /*
                var data = db.SqlList<string>(string.Format("Exec SPdesencryptar " +
                    "@Correo = '{0}'",
                    correo
                    )).FirstOrDefault();*/

                
                 Usuario resultado = db.SqlList<Usuario>(string.Format("Exec SPLogin " +
                     "@Correo = '{0}' ," +
                     "@Password = '{1}' ",

                      correo,
                      password
                      )).FirstOrDefault();



                return resultado;

            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public static string VerificarCredes(string correo, string password)
        {

            try
            {
                var db = BDConn.Connector();


                /*
                                Usuario resultado = db.SqlList<Usuario>(string.Format("Exec SPLogin " +
                                    "@Correo = '{0}' ," +
                                    "@Password = '{1}' ",

                                    correo,
                                    password

                                    )).FirstOrDefault();*/

                var resultado = db.SqlList<string>(string.Format("Exec SPdesencryptar " +
                "@Correo = '{0}'",
                correo
                )).FirstOrDefault();



                return resultado;

            }
            catch (Exception ex)
            {

                throw;
            }

        }


















        public static ListadoUsuarioCompleto ListadoCompletoUsuario()
        {

            try
            {
                var db = BDConn.Connector();

                ListadoUsuarioCompleto lista = new ListadoUsuarioCompleto();

                lista.ListaUsuarios = db.SqlList<UsuarioCompleto>(string.Format("Exec SPListarUsuariosCompleto "));



                if (lista.ListaUsuarios != null && lista.ListaUsuarios.Count() > 0)
                {
                    lista.Codigo = 1;
                    lista.Mensaje = "Lista Correcta";

                }
                else
                {
                    lista.Codigo = 99;
                    lista.Mensaje = "Problemas ";
                }




                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static ResultadoPorSP AgregarUsuarios(Usuario usuario)
        {

            try
            {
                var db = BDConn.Connector();

                ResultadoPorSP resultado = db.SqlList<ResultadoPorSP>(string.Format("Exec SPInsertarUsuarios " +
                    "@Nombre = '{0}' ," +
                    "@Apellido = '{1}' ," +
                    "@Correo = '{2}' ," +
                    "@pw = '{3}' ," +
                    "@IdRol = {4}",

                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Correo,
                    usuario.password,
                    usuario.IdRol
                    )).FirstOrDefault();            
                
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static Usuario BuscarUsuario(int idUsuario)
        {
            try
            {
                var db = BDConn.Connector();

                Usuario resultado = db.SqlList<Usuario>(string.Format("Exec SPBuscarUsuariosPorId " +
                    "@IdUsuario = {0}",
                    idUsuario
                    )).FirstOrDefault();

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static ResultadoPorSP ModificarUsuario(Usuario usuario)
        {
            try
            {
                var db = BDConn.Connector();

                ResultadoPorSP resultado = db.SqlList<ResultadoPorSP>(string.Format("Exec SPActulizarUsuarios " +
                    "@Nombre = '{0}'," +
                    "@Apellido = '{1}'," +
                    "@Correo = '{2}'," +
                    "@Password = '{3}'," +
                    "@IdRol = {4},"+
                    "@IdUsuario = {5} ",
    
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Correo,
                    usuario.password,
                    usuario.IdRol,
                    usuario.IdUsuario
                    )).FirstOrDefault();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static Usuario verificarSiExiste(string correo) {

            try
            {
                var db = BDConn.Connector();


                Usuario resultado = db.SqlList<Usuario>(string.Format("Exec SPVerificarExisteUsuario " +
                   "@correo = '{0}'",
                   correo
                   )).FirstOrDefault();

                return resultado;

            }
            catch (Exception e)
            {
                throw;
            }
        }



    }
}