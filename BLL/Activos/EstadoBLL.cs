using DAL.Activos;
using Entidades;
using Entidades.Activos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Activos
{
    public class EstadoBLL
    {
        public static void AgregarEstado(Estado estado)
        {
            try
            {
                EstadoDAL.AgregarEstado(estado);
            }
            catch (Exception)
            {

                throw;
            }



        }


        public static List<Estado> ListadoEstados()
        {
            try
            {
                return EstadoDAL.listadoEstados();
            }
            catch (Exception)
            {

                throw;
            }



        }


        public static Estado BuscarEstado(int id)
        {
            try
            {
                return EstadoDAL.BuscarEstado(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(Estado estado)
        {

            try
            {
                EstadoDAL.Modificar(estado);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarEstado(Estado estado)
        {

            try
            {
                EstadoDAL.EliminarEstado(estado);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
