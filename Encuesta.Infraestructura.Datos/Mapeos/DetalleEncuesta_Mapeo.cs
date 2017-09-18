using Encuesta.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Encuesta.Infraestructura.Datos.Mapeos
{
    public class DetalleEncuesta_Mapeo : EntityTypeConfiguration<Encuesta.Dominio.DetalleEncuesta>
    {
        public DetalleEncuesta_Mapeo()
        {
            ToTable("DET_ENCUESTAS", "ENCUESTA");
            HasKey(k => k.idDetalleEncuesta);
            Property(p => p.idDetalleEncuesta).HasColumnName("ID_DETALLE_ENCUESTA").IsRequired();
            Property(p => p.respuestaPregunta).HasColumnName("RESPUESTA_PREGUNTA_DETALLE_ENCUESTA").IsRequired().HasMaxLength(200);
            Property(p => p.idEncuesta).HasColumnName("ID_ENCUESTA").IsRequired();
            //Property(p => p.idPregunta).HasColumnName("ID_PREGUNTA").IsRequired();
       

            HasRequired(m => m.Encuesta).WithMany().HasForeignKey(f => f.idEncuesta);
            //HasRequired(m => m.Preguntas).WithMany().HasForeignKey(f => f.idPregunta);


    }
    }
}
