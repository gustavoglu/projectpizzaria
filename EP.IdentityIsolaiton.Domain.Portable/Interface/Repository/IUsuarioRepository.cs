using System;
using System.Collections.Generic;
using EP.IdentityIsolation.Domain.Portable.Entities;

namespace EP.IdentityIsolation.Domain.Portable.Interface.Repository
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
    }
}