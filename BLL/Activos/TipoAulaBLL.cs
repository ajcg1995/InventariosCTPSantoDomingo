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
    public class TipoAulaBLL
    {
        public static void AgregarTipoAula(TipoAula tipoaula)
        {
            try
            {
                TipoAulaDAL.AgregarTipoAula(tipoaula);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static TipoAula BuscarTipoAula(int id)
        {
            try
            {
                return TipoAulaDAL.BuscarTipoAula(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(TipoAula tipoaula)
        {

            try
            {
                TipoAulaDAL.Modificar(tipoaula);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarTipoAula(TipoAula tipoaula)
        {

            try
            {
                TipoAulaDAL.EliminarTipoAula(tipoaula);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static ListaTipoAula ListadoTipoAula()
        {

            try
            {
                return TipoAulaDAL.ListadoTipoAulas();
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
