using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta.Repositorios
{
    public interface IRepositorio
    {
        T Buscar<T>(params object[] ao_llave) where T : class;
        IQueryable<T> Listar<T>() where T : class;
        List<T> ListarPorExpresion<T>() where T : class;
        void Adicionar<T>(T ao_objeto) where T : class;
        void GuardarCambios();
    }
}
