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
    public class ActivoBLL
    {
        public static Resultado AgregarActivo(Activo activo, Usuario usuario)
        {
            try
            {
                return ActivoDAL.AgregarActivo(activo, usuario);
            }
            catch (Exception)
            {

                throw;
            }



        }

       /* public static Activo BuscarActivo(int id)
        {
            try
            {
                return ActivoDAL.BuscarActivo(id);
            }
            catch (Exception)
            {

                throw;
            }


        }
        */

        public static void Modificar(Activo activo, Usuario usuario)
        {

            try
            {
                 ActivoDAL.Modificar(activo, usuario);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarActivo(Activo activo)
        {

            try
            {
                ActivoDAL.EliminarActivo(activo);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static ListaActivosPorAulas ListadoActivosPorAulas(int idAula)
        {
            try
            {
                return ActivoDAL.ListadoActivosPorAulas(idAula);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ActivosPorAulas BuscarActivosPorAulas(int idActivo) {
            try
            {
                return ActivoDAL.BuscarActivosPorAulas(idActivo);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static Activo BuscarUnActivo(string identificacion) {
            try
            {
                return ActivoDAL.BuscarUnActivo(identificacion);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static ListaActivosPorAulas ListadoActivosTecnoligicosPorAulas(int idAula)
        {
            try
            {
                return ActivoDAL.ListadoActivosTecnolgicosPorAulas(idAula);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ListadoActivoReparacion ListadoActivosReparacion()
        {
            try
            {
                return ActivoDAL.ListadoActivosReparacion();  
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
