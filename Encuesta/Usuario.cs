using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class Usuario
    {
        public int idusuario { get; private set; }
        public String nombre { get; private set; }
        public String apellido { get; private set; }
        public String telefono { get; private set; }
        public String direccion { get; private set; }
        /// <summary>
        /// Propiedad que requeprenta la contraseña del usuario
        /// </summary>
        public string ClaveUsuario { get; set; }
        public byte estadoUsuario { get; private set; }

        private Usuario()
        {

        }
        /// <summary>
        /// Método que Crea un Usuario
        /// </summary>
        /// <param name="asNombre">Nombre del usuario</param>
        /// <param name="asApellido">Apellido del usuario</param>
        /// <param name="asClave">Clave del usuario</param>
        /// <returns>Instancia nueva del usuario</returns>
        public static Usuario Crear(string asNombre, string asApellido, string asClave)
        {
            return new Usuario()
            {
                nombre = asNombre,
                apellido = asApellido,
                ClaveUsuario = asClave,
                estadoUsuario = 1
            };
        }

        public void AgregarMediosContacto(string asTelefono, string asDireccion)
        {
            telefono = asTelefono;
            direccion = asDireccion;
        }
        /// <summary>
        /// Método que elimina la instancia del usuario
        /// </summary>
        public void Eliminar()
        {
            estadoUsuario = 0;
        }
        
    }

}
