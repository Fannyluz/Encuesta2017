﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Dominio
{
    public class Opcion
    {
        public int idOpcion { get; set; }
        public String contenido { get; set; }
        public int idPregunta { get; set; }
        public Pregunta Pregunta { get; set; }

        public static Opcion CrearOpciones(int aiidOpcion, String ascontenido)
        {
            return new Opcion()
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
