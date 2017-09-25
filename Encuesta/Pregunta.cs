using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class Pregunta
    {
        public int idPregunta { get; set; }
        public String contenido { get; set; }
        public String tipoPregunta { get; set; }
        public int idDetalleEncuesta { get; set; }
        public DetalleEncuesta Detalle { get; set; }
        public ICollection<Opcion> Opciones { get; set; }
        public static Pregunta CrearPregunta(int aiidPregunta, String ascontenido, String astipoPregunta)
        {
            return new Pregunta()
            {
                idPregunta = aiidPregunta,
                contenido = ascontenido,
                tipoPregunta = astipoPregunta,
            };

        }
        public void ModificarPregunta (int aiidPregunta)
        {
            idPregunta = aiidPregunta;
        }
        // activar 
        public void Activar()
        {
           
        }
        //desactivar
        public void Desactivar()
        {

        }
        public void Eliminar()
        {

        }

    }


}
