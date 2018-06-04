using System.Collections.Generic;

namespace Modelo.Base
{
    interface IBaseController<T> where T : class 
    {
        void Adicionar(T entity);

        List<T> ListarTodos();

        List<T> ListarPorNome();

        T BuscarPorId(int id);

        void Editar(T entity);

        void Excluir(int id);
    }
}
