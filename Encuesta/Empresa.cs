using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class Empresa
    {
        public String nombreEmpresa { get; set; }
        public String direccionEmpresa { get; set; }
        public String telefonoEmpresa { get; set; }
        public String rucEmpresa { get; set; }
        public int idEmpresa { get; set; }

        //agregar empresa 
         public static Empresa CrearEmpresa(int aiidEmpresa, String asnombreEmpresa,String asdireccionEmpresa, String aiTelefonoEmpresa, String aiRucEmpresa)
        {
            return new Empresa()
            {
                idEmpresa = aiidEmpresa,
                nombreEmpresa = asnombreEmpresa,
                direccionEmpresa = asdireccionEmpresa,
                telefonoEmpresa = aiTelefonoEmpresa,
                rucEmpresa = aiRucEmpresa

            };
        }
    }

}
