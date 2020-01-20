using DAL.Usuarios;
using Entidades;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Usuarios
{
    public class UsuarioBLL
    {
        public static ListadoUsuarioCompleto ListadoCompletoUsuario()
        {
            try
            {
                return UsuarioDAL.ListadoCompletoUsuario();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static ResultadoPorSP AgregarUsuario(Usuario usuario)
        {

            try
            {
                return UsuarioDAL.AgregarUsuarios(usuario);
            }
            catch (Exception)
            {

                throw;
            }

        }
            public static Usuario VerificarCredenciales(string correo, string password)
            {
                try
                {
                    return UsuarioDAL.VerificarCredenciales(correo, password);
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
                return UsuarioDAL.BuscarUsuario(idUsuario);
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
                return UsuarioDAL.ModificarUsuario(usuario);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static Usuario verificarSiExiste(string correo)
        {

            try
            {
                return UsuarioDAL.verificarSiExiste(correo);
            }
            catch (Exception)
            {

                throw;
            }
        }







    }

}

