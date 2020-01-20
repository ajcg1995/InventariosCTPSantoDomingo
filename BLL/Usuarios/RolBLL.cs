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
    public class RolBLL
    {
        public static void AgregarRol(Rol rol)
        {
            try
            {
                RolDAL.AgregarRol(rol);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static Rol BuscarRol(int id)
        {
            try
            {
                return RolDAL.BuscarRol(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(Rol rol)
        {

            try
            {
                RolDAL.Modificar(rol);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarRol(Rol rol)
        {
            try
            {
                RolDAL.EliminarRol(rol);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static List<Rol> ListadoRoles() {

            try
            {
                return RolDAL.ListadoRoles();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}