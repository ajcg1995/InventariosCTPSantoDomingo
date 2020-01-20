using BLL.Usuarios;
using Entidades.Usuarios;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Usuarios;

namespace Pruebas
{
    [TestClass]
    public class Usuarios
    {
        [TestMethod]
        public void addUsuario() {

            Usuario a = new Usuario
            {
                Nombre = "as",
                Apellido = "as",
                Correo = "proyecto@hotmail.com",
                password = "admin",
                IdRol = 1
            };

            UsuarioDAL.ModificarUsuario(a);

            //var data = UsuarioDAL.VerificarCredencuales("ajcg1995@hotmail.com", "12345");


        }


        [TestMethod]
        public void Login()
        {

            Usuario a = new Usuario
            {
                Nombre = "as",
                Apellido = "as",
                Correo = "a@hotmail.com",
                password = "12",
                IdRol = 1
            };

            UsuarioDAL.VerificarCredenciales("admin@hotmail.com","12345");

            //var data = UsuarioDAL.VerificarCredencuales("ajcg1995@hotmail.com", "12345");


        }





    }
}
