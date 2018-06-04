using Modelo.Base;

namespace Modelo
{
    public class UsuariosController : IBaseController<Usuario>
    {
        public int UsuarioID { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public void Adicionar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
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

        public System.Collections.Generic.List<Usuario> ListarPorNome()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Usuario> ListarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
