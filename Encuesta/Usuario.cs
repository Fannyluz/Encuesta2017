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

        private Usuario()
        {

        }
        public static Usuario Crear(string asNombre, string asApellido)
        {
            return new Usuario()
            {
                nombre = asNombre,
                apellido = asApellido
            };
        }

        public void AgregarMediosContacto(string asTelefono, string asDireccion)
        {
            telefono = asTelefono;
            direccion = asDireccion;
        }
        public static Usuario Eliminar( int aiUsuario)
        {
            return new Usuario()
            {
                idusuario = aiUsuario
            };
        }
        
    }

}
