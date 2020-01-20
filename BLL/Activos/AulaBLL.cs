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
    public class AulaBLL
    {
        public static ResultadoPorSP AgregarAula(Aula aula, Usuario usuarios)
        {
            try
            {
                ResultadoPorSP res = AulaDAL.AgregarAula(aula,usuarios);
                return res;
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static Aula BuscarAula(int id)
        {
            try
            {
                return AulaDAL.BuscarAula(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(Aula aula)
        {

            try
            {
                AulaDAL.Modificar(aula);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static ResultadoPorSP EliminarAula(int idAulaEliminar)
        {

            try
            {
                return AulaDAL.EliminarAula(idAulaEliminar);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static ListadoAulaCompleto ListadoCompletoAula()
        {
            try
            {
                return AulaDAL.ListadoCompletoAula();
            }
            catch (Exception)
            {

                throw;
            }

        }
        }
}
