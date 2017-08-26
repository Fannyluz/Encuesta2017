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
        public int idPregunta { get; set; }
        public Encuesta Encuestas { get; set; }
        public Pregunta Preguntas { get; set; }


        public static DetalleEncuesta CrearDetalleEncuesta(int aiidDetalleEncuesta, String asrespuestaPregunta, int aiidEncuesta, int aiidPregunta)
        {
            return new DetalleEncuesta()
            {
                idDetalleEncuesta = aiidDetalleEncuesta,
                respuestaPregunta = asrespuestaPregunta,
                idEncuesta = aiidEncuesta,
                idPregunta = aiidPregunta
            };


        }
        public void EstablecerRespuesta()
        {

        }


    }


}
