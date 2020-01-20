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
    public class LeyBLL
    {
        public static ResultadoPorSP AgregarLey(Ley ley)
        {
            try
            {
                return LeyDAL.AgregarLey(ley);
            }
            catch (Exception)
            {

                throw;
            }
            


        }

        public static Ley BuscarLey(int id)
        {
            try
            {
                return LeyDAL.BuscarLey(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(Ley ley) {

            try
            {
                LeyDAL.Modificar(ley);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarLey(Ley ley) {

            try
            {
                LeyDAL.EliminarLey(ley);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<Ley> ListarLeyes()
        {

            try
            {
                return LeyDAL.ListadoLeyes();
            }
            catch (Exception)
            {

                throw;
            }

        }





    }
}
