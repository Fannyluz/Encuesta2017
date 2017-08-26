using Encuesta.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Encuesta.Infraestructura.Datos.Mapeos
{
    public class EncuestaMapeo : EntityTypeConfiguration<Encuesta.Dominio.Encuesta>
    {
        public EncuestaMapeo()
        {
            ToTable("ENCUESTAS", "ENCUESTA");
            HasKey(k => k.idEncuesta);
            Property(p => p.idEncuesta).HasColumnName("ID_ENCUESTA").IsRequired();
            Property(p => p.idEmpresa).HasColumnName("ID_EMPRESA").IsRequired();
            Property(p => p.idUsuario).HasColumnName("ID_USUARIO").IsRequired();
            Property(p => p.descripcion).HasColumnName("DES_ENCUESTA").IsRequired().HasMaxLength(50);
            Property(p => p.fecha).HasColumnName("FEC_ENCUESTA").IsRequired();
            Property(p => p.tipoEncuesta).HasColumnName("TIPO_ENCUESTA").HasMaxLength(20).IsRequired();
            Property(p => p.estadoEncuesta).HasColumnName("EST_ENCUESTA").IsRequired();
            Ignore(p => p.totalEncuestados);

            HasRequired(m => m.empresa).WithMany().HasForeignKey(f => f.idEmpresa);
            HasRequired(m => m.UsuarioEncuesta).WithMany().HasForeignKey(f => f.idUsuario);
        }
    }
}
