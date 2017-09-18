using Encuesta.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Encuesta.Infraestructura.Datos.Mapeos
{
    public class PreguntaMapeo : EntityTypeConfiguration<Pregunta>
    {
        public PreguntaMapeo()
        {
            ToTable("PREGUNTAS", "ENCUESTA");
            HasKey(k => k.idPregunta);
            Property(p => p.idPregunta).HasColumnName("ID_PREGUNTA").IsRequired();
            Property(p => p.contenido).HasColumnName("CON_PREGUNTA").IsRequired().HasMaxLength(100);
            Property(p => p.tipoPregunta).HasColumnName("TIPO_PREGUNTA").IsRequired().HasMaxLength(11);
            Property(p => p.idopcionPregunta).HasColumnName("IDOPNCION_PREGUNTA").IsRequired();

            HasRequired(m => m.Detalle).WithMany().HasForeignKey(f => f.idDetalleEncuesta);
              
    }
    }
}
