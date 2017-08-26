using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class Opciones
    {
        public int idOpcion { get; set; }
        public String contenido { get; set; }
        public Pregunta Opcion { get; set; }

        public static Opciones CrearOpciones(int aiidOpcion, String ascontenido)
        {
            return new Opciones()
            {
                idOpcion = aiidOpcion,
                contenido = ascontenido,
            };


        }

        public void modificarOpcion()
        {

        }


        public void Eliminar()
        {

        }


    }


}
