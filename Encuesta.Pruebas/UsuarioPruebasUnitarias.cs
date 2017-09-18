using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encuesta.Dominio;
using Encuesta.Infraestructura.Datos;
using Encuesta.Infraestructura.Datos.Repositorios;

namespace Encuesta.Pruebas
{
    [TestClass]
    public class UsuarioPruebasUnitarias
    {
        [TestMethod]
        public void UsuarioCrearSatisfactorio()
        {
            var usuario = Usuario.Crear("Diego", "Paucar", "123456");
            var contexto = new EncuestaContexto();
            var repositorio = new Repositorio(contexto);
            repositorio.Adicionar<Usuario>(usuario);
            repositorio.GuardarCambios();

            Assert.IsNotNull(usuario);
        }

        [TestMethod]
        public void UsuarioAgregarMediosContactoSatisfactorio()
        {
            var contexto = new EncuestaContexto();
            var repositorio = new Repositorio(contexto);
            var usuario = repositorio.Buscar<Usuario>(1);

            usuario.AgregarMediosContacto("952000666", "Calle Billigursth 555");
            repositorio.GuardarCambios();

            Assert.IsNotNull(usuario);
        }
    }
}
