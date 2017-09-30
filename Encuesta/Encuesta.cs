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



        public static Encuesta CrearEncuesta(int aiidEncuesta, String asdescripcion, String astipoEncuesta , 
                                              Empresa aoempresa, Usuario aousuario,
                                                 byte iestadoEncuesta , int aitotalEncuestados)
        {
            return new Encuesta()
            {
                idEncuesta = aiidEncuesta,
                descripcion = asdescripcion,
                tipoEncuesta = astipoEncuesta,
                empresa = aoempresa,
                UsuarioEncuesta = aousuario,
                fecha = DateTime.Now,
                estadoEncuesta = iestadoEncuesta,
                totalEncuestados = aitotalEncuestados
                
                

            };
        }

        public void Calcular_Porcentaje()
        {

        }

        public void Activar()
        {
            estadoEncuesta = 1;
        }

        public void Desactivar()
        {
            estadoEncuesta = 0;
        }
    }

 
}
