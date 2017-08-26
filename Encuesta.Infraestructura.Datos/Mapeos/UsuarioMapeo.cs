using Encuesta.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace Encuesta.Infraestructura.Datos.Mapeos
{
    public class UsuarioMapeo : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeo()
        {
            ToTable("USUARIOS","ENCUESTA");
            HasKey(k => k.idusuario);
            Property(p => p.idusuario).HasColumnName("ID_USUARIO").IsRequired();//.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.nombre).HasColumnName("NOM_USUARIO").IsRequired().HasMaxLength(30);
            Property(p => p.apellido).HasColumnName("APE_USUARIO").IsRequired().HasMaxLength(30);
            Property(p => p.telefono).HasColumnName("TEL_USUARIO").HasMaxLength(10);
            Property(p => p.direccion).HasColumnName("DIR_USUARIO").HasMaxLength(50);
        }
    }
}
