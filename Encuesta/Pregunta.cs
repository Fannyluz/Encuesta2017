﻿using System;
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
        public byte estadoPregunta { get; private set; }
        public static Pregunta CrearPregunta(int aiidPregunta, String ascontenido, String astipoPregunta)
        {
            return new Pregunta()
            {
                idPregunta = aiidPregunta,
                contenido = ascontenido,
                tipoPregunta = astipoPregunta,
                estadoPregunta = 1,
            };

        }
        public void ModificarPregunta (String ascontenido, String asTipoPregunta,int aiiddetalaencuesta)
        {
            contenido = ascontenido;
            tipoPregunta = asTipoPregunta;
            idDetalleEncuesta = aiiddetalaencuesta;
        }
        // activar 
        public void Activar()
        {
            estadoPregunta = 1;
        }
        //desactivar
        public void Desactivar()
        {
            estadoPregunta = 0;

        }
       

    }


}
