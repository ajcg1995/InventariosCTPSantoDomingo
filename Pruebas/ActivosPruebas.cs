using System;
using BLL.Activos;
using Entidades.Activos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class ActivosPruebas
    {
        [TestMethod]
        public void AgregarLey()
        {
            //Creacion del objeto

            Ley ley = new Ley
            {
                LeyAdquirida = "Ley Jairon"
            };


            LeyBLL.AgregarLey(ley);

        }



        [TestMethod]
        public void BuscarLey()
        {

            Ley ley = LeyBLL.BuscarLey(0);


        }




        [TestMethod]
        public void ModificarLey()
        {

            Ley ley = LeyBLL.BuscarLey(0);

            ley.LeyAdquirida = "Ley 8800";


            LeyBLL.Modificar(ley);





        }


        [TestMethod]
        public void EliminarLey()
        {
            Ley ley = LeyBLL.BuscarLey(0);
            LeyBLL.EliminarLey(ley);
        }


        [TestMethod]
        public void ListarTipoAulas()
        {
            var listado = TipoAulaBLL.ListadoTipoAula();
        }

    }
}




