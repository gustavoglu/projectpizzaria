using Project.Pizzaria.Domain.Interfaces.Repository;
using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Project.Pizzaria.Infra.Data.Context;
using System.Data.Entity;
using System.Web;
using System.Security.Claims;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Context;
using EP.IdentityIsolation.Infra.Data.Context;

namespace Project.Pizzaria.Infra.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase, new()
    {
        ContextSQLServer db;
        IdentityIsolationContext udb;
        DbSet<T> dbSet;

        protected Repository()
        {
            db = new ContextSQLServer();
            udb = new IdentityIsolationContext();
            dbSet = db.Set<T>();

        }

        public virtual T Activate(T obj)
        {
            obj.Active = true;

            var entry = db.Entry(obj);
            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            SaveChanges();

            return obj;

        }

        public virtual T Add(T obj)
        {
            var nameUser = HttpContext.Current.User.Identity.Name;
            var iduser = udb.Usuarios.SingleOrDefault(u => u.UserName == nameUser).Id;
            obj.CreateAt = DateTime.Now.Date;
            obj.Active = true;
            obj.Id_CreateByUser = iduser;

            dbSet.Add(obj);
            SaveChanges();

            return obj;
        }

        public T Disable(T obj)
        {
            obj.Active = false;

            var entry = db.Entry(obj);
            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            SaveChanges();

            return obj;
        }

        public virtual int Remove(T obj)
        {
            var nameUser = HttpContext.Current.User.Identity.Name;
            obj.Active = false;
            obj.DeletedAt = DateTime.Now.Date;
            obj.IsDeleted = true;
            obj.Id_DeletedByUser = udb.Usuarios.SingleOrDefault(u => u.UserName == nameUser).Id;

            var entry = db.Entry(obj);

            dbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return SaveChanges();

        }

        public virtual T Update(T obj)
        {
            var entry = db.Entry(obj);
            dbSet.Attach(obj);
            entry.State = EntityState.Modified;

            SaveChanges();

            return obj;

        }

        public virtual void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual T GetById(Guid Id)
        {
            return dbSet.Find(Id);
        }

        public T ReturnEntityDeleted(T obj)
        {
            obj.Active = true;
            obj.IsDeleted = true;

            var entry = db.Entry(obj);
            dbSet.Attach(obj);

            entry.State = EntityState.Modified;

            SaveChanges();

            return obj;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetAllActives()
        {
            return dbSet.Where(t => t.Active == true).ToList();
        }

        public virtual IEnumerable<T> GetAllDeleteds()
        {
            return dbSet.Where(t => t.Active == false && t.IsDeleted == true).ToList();
        }

        public virtual IEnumerable<T> GetAllNotActives()
        {
            return dbSet.Where(t => t.Active == false && t.IsDeleted == false).ToList();
        }

        public virtual IEnumerable<T> GetAllNotActivesDeleteds()
        {
            return dbSet.Where(t => t.Active == false && t.IsDeleted == true).ToList();
        }

        public virtual IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public virtual IEnumerable<T> SearchActives(Expression<Func<T, bool>> predicate)
        {
            var set = dbSet.Where(t => t.Active == true && t.IsDeleted == false);
            return set.Where(predicate).ToList();
        }

        public virtual IEnumerable<T> SearchDeleteds(Expression<Func<T, bool>> predicate)
        {
            var set = dbSet.Where(t => t.IsDeleted == false);
            return set.Where(predicate).ToList();
        }

        public virtual IEnumerable<T> SearchNotActives(Expression<Func<T, bool>> predicate)
        {
            var set = dbSet.Where(t => t.Active == false && t.IsDeleted == false);
            return set.Where(predicate).ToList();
        }

        public virtual IEnumerable<T> SearchNotActivesDeleteds(Expression<Func<T, bool>> predicate)
        {
            var set = dbSet.Where(t => t.Active == false && t.IsDeleted == true);
            return set.Where(predicate).ToList();
        }

        public virtual int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
