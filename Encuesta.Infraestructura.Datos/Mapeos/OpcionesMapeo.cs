using Encuesta.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Encuesta.Infraestructura.Datos.Mapeos
{
    public class OpcionMapeo : EntityTypeConfiguration<Opcion>
    {
        public OpcionMapeo()
        {
            ToTable("OPCIONES", "ENCUESTA");
            HasKey(k => k.idOpcion);
            Property(p => p.idOpcion).HasColumnName("ID_OPCION").IsRequired();
            Property(p => p.contenido).HasColumnName("CON_OPCION").IsRequired().HasMaxLength(200);

            HasRequired(m => m.Pregunta).WithMany().HasForeignKey(f => f.idPregunta);



    }
}
}
