using Encuesta.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Encuesta.Infraestructura.Datos.Mapeos
{
    public class EmpresaMapeo : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMapeo()
        {
            ToTable("EMPRESAS", "ENCUESTA");
            HasKey(k => k.idEmpresa);
            Property(p => p.idEmpresa).HasColumnName("ID_EMPRESA").IsRequired();
            Property(p => p.nombreEmpresa).HasColumnName("NOM_EMPRESA").IsRequired().HasMaxLength(30);
            Property(p => p.rucEmpresa).HasColumnName("RUC_EMPRESA").IsRequired().HasMaxLength(11);
            Property(p => p.telefonoEmpresa).HasColumnName("TEL_EMPRESA").HasMaxLength(10);
            Property(p => p.direccionEmpresa).HasColumnName("DIR_EMPRESA").HasMaxLength(50);
        }
    }
}
