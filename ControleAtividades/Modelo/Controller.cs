using Modelo.Base;
using System.Collections.Generic;

namespace Modelo
{
    class Controller : IBaseController<Usuario>
    {
       List<Atividade> minhasAtividades = new List<Atividade>();

        public void Adicionar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Editar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> ListarPorNome()
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            throw new System.NotImplementedException();
        }

        Usuario IBaseController<Usuario>.BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
