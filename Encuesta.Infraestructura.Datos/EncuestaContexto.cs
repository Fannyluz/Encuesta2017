using Encuesta.Dominio;
using Encuesta.Infraestructura.Datos.Mapeos;
using System.Data.Entity;

namespace Encuesta.Infraestructura.Datos
{
    public class EncuestaContexto : DbContext
    {
        public EncuestaContexto() : base("EncuestaBD")
        {
        }

        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Empresa> Empresas { get; set; }

        public IDbSet<Encuesta.Dominio.Encuesta> Encuestas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EmpresaMapeo());
            modelBuilder.Configurations.Add(new UsuarioMapeo());
            modelBuilder.Configurations.Add(new EncuestaMapeo());

            //agregacion 
            modelBuilder.Configurations.Add(new OpcionesMapeo());
            modelBuilder.Configurations.Add(new PreguntaMapeo());
            modelBuilder.Configurations.Add(new DetalleEncuesta_Mapeo());
        }
    }
}
