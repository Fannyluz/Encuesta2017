using Encuesta.Dominio;
using Encuesta.Infraestructura.Datos;
using Encuesta.Infraestructura.Datos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Enuesta.Distribucion.API
{
    public class UsuariosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("api/Usuarios/{id}/{clave}/{otro}")]
        public string Get(int id, string clave, string otro)
        {
            var contexto = new EncuestaContexto();
            var repositorio = new Repositorio(contexto);
            var usuario = repositorio.Buscar<Usuario>(id);

            if (usuario.ClaveUsuario == clave)
            {
                return "True";
            }
            else
                return "False";
        }

        /// <summary>
        /// Metodo que valida el inicio de sesión del usuario
        /// </summary>
        /// <param name="id">Identificador del usuario</param>
        /// <param name="clave">clave del usuario</param>
        /// <returns>Verdadero o Falso</returns>
        [HttpGet]
        [Route("api/Usuarios/IniciarSesion/{id}/{clave}")]
        public string IniciarSesion(int id, string clave)
        {
            var contexto = new EncuestaContexto();
            var repositorio = new Repositorio(contexto);
            var usuario = repositorio.Buscar<Usuario>(id);

            if (usuario.ClaveUsuario == clave)
            {
                return "True";
            }
            else
                return "False";
        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}