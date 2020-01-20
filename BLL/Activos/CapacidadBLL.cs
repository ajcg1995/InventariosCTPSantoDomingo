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
    public class CapacidadBLL
    {
        public static void AgregarCapacidad(Capacidad capacidad)
    {
        try
        {
             CapacidadDAL.AgregarCapacidad(capacidad);
        }
        catch (Exception)
        {

            throw;
        }



    }

    public static Capacidad BuscarCapacidad(int id)
    {
        try
        {
            return CapacidadDAL.BuscarCapacidad(id);
        }
        catch (Exception)
        {

            throw;
        }


    }


    public static void Modificar(Capacidad capacidad)
    {

        try
        {
            CapacidadDAL.Modificar(capacidad);
        }
        catch (Exception)
        {

            throw;
        }

    }


    public static void EliminarCapacidad(Capacidad capacidad)
    {

        try
        {
            CapacidadDAL.EliminarCapacidad(capacidad);
        }
        catch (Exception)
        {

            throw;
        }

    }

    public static ListadoCapacidad ListarCapacidadPorId(string identificacion)
    {
         try
         {
              return CapacidadDAL.ListarCapacidadPorId(identificacion);
         }
         catch (Exception)
         {

             throw;
         }
    }

}
}
