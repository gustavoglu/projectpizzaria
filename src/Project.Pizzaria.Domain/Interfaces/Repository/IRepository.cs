using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Domain.Interfaces.Repository
{
    public interface IRepository<T> : IDisposable where T : EntityBase
    {
        T Add(T obj);

        T GetById(Guid Id);

        T Update(T obj);

        T Activate(T obj);

        T Disable(T obj);

        T ReturnEntityDeleted(T obj);

        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);

        IEnumerable<T> SearchActives(Expression<Func<T, bool>> predicate);

        IEnumerable<T> SearchNotActives(Expression<Func<T, bool>> predicate);

        IEnumerable<T> SearchNotActivesDeleteds(Expression<Func<T, bool>> predicate);

        IEnumerable<T> SearchDeleteds(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAllActives();

        IEnumerable<T> GetAllNotActivesDeleteds();

        IEnumerable<T> GetAllNotActives();

        IEnumerable<T> GetAllDeleteds();

        int Remove(T obj);

        int SaveChanges();

    }
}
