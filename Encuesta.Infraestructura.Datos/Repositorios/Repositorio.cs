using Encuesta.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Infraestructura.Datos.Repositorios
{
    public class Repositorio : IRepositorio
    {
        EncuestaContexto ioContexto;
        public Repositorio(EncuestaContexto aoContexto) 
        {
            ioContexto = aoContexto;
        }
        
        public void Adicionar<T>(T ao_objeto) where T : class
        {
            ioContexto.Set<T>().Add(ao_objeto);
        }

        public T Buscar<T>(params object[] ao_llave) where T : class
        {
            return ioContexto.Set<T>().Find(ao_llave);
        }

        public void GuardarCambios()
        {
            ioContexto.SaveChanges();
        }

        public IQueryable<T> Listar<T>() where T : class
        {
            return ioContexto.Set<T>();
        }

        public List<T> ListarPorExpresion<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
