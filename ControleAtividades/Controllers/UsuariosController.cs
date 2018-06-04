using System.Collections.Generic;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorID(int id)
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

        public IList<Usuario> ListarPorNome()
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
