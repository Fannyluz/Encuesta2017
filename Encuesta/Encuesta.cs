using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class Encuesta
    {
        public int idEncuesta { get; set; }
        public String descripcion { get; set; }
        public int idEmpresa { get; set; }
        public Empresa empresa { get; set; }
        public DateTime fecha { get; set; }
        public String tipoEncuesta { get; set; }
        public int totalEncuestados { get; set; }
        public byte estadoEncuesta { get; set; }
        public int idUsuario { get; set; }
        public Usuario UsuarioEncuesta { get; set; }



        public static Encuesta CrearEncuesta(int aiidEncuesta, String asdescripcion, int idEmpresa, String astipoEncuesta, int aitotalEncuestados, byte iestadoEncuesta, int aiidUsuario)
        {
            return new Encuesta()
            {
                idEncuesta = aiidEncuesta,
                descripcion = asdescripcion,
                idEmpresa = idEmpresa,
                fecha = DateTime.Now,
                tipoEncuesta = astipoEncuesta,
                totalEncuestados = aitotalEncuestados,
                estadoEncuesta = iestadoEncuesta,
                idUsuario = aiidUsuario

            };
        }

        public void Calcular_Porcentaje()
        {

        }

        public void Activar()
        {

        }

        public void Desactivar()
        {

        }
    }

 
}
