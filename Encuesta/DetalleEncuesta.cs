using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class DetalleEncuesta
    {
        public int idDetalleEncuesta { get; set; }
        public String respuestaPregunta { get; set; }
        public int idEncuesta { get; set; }
        //public int idPregunta { get; set; }
        public Encuesta Encuesta { get; set; }
        public ICollection<Pregunta> Preguntas { get; set; }


        public static DetalleEncuesta CrearDetalleEncuesta(int aiidDetalleEncuesta, String asrespuestaPregunta, int aiidEncuesta)
        {
            return new DetalleEncuesta()
            {
                idDetalleEncuesta = aiidDetalleEncuesta,
                respuestaPregunta = asrespuestaPregunta,
                idEncuesta = aiidEncuesta,
            };

        }
        public void EstablecerRespuesta()
        {

        }


    }


}
