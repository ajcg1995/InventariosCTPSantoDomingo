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
    public class PrestadorServicioBLL
    {
        public static void AgregarPrestadorServicio(PrestadorServicio prestadorservicio)
        {
            try
            {
                PrestadorServicioDAL.AgregarPrestadorServicio(prestadorservicio);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static PrestadorServicio BuscarPrestadorServicio(int id)
        {
            try
            {
                return PrestadorServicioDAL.BuscarPrestadorServicio(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(PrestadorServicio prestadorservicio)
        {

            try
            {
                PrestadorServicioDAL.Modificar(prestadorservicio);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarPrestadorServicio(PrestadorServicio prestadorservicio)
        {

            try
            {
                PrestadorServicioDAL.EliminarPrestadorServicio(prestadorservicio);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}