using DAL.Activos;
using Entidades;
using Entidades.Activos;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Activos
{
    public class ReparacionBLL
    {
        public static void AgregarReparacion(Reparacion reparacion, Usuario usuario)
        {
            try
            {
                ReparacionDAL.AgregarReparacion(reparacion, usuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Reparacion BuscarReparacion(int id)
        {
            try
            {
                return ReparacionDAL.BuscarReparacion(id);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void Modificar(Reparacion reparacion, Usuario usuario)
        {
            try
            {
                ReparacionDAL.Modificar(reparacion,usuario);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarReparacion(Reparacion reparacion)
        {

            try
            {
                ReparacionDAL.EliminarReparacion(reparacion);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
