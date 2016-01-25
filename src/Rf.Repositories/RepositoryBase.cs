using Rf.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace Rf.Repositories
{
    public class RepositoryBase<T> : IRepository<T>, IDisposable
        where T : class
    {
        private const int CommandTimeout = 1800;
        private bool disposing;
        private DbContext dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual IDbSet<T> DbSet
        {
            get
            {
                return dbContext.Set<T>();
            }
        }

        public DbContext Context
        {
            get { return dbContext; }
        }

        public bool HasChanges
        {
            get { return Context.ChangeTracker.Entries().Any(); }
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> whereCondition)
        {
            return DbSet.Where(whereCondition).FirstOrDefault();
        }

        public T Get(Expression<Func<T, bool>> whereCondition)
        {
            return GetFirstOrDefault(whereCondition);
        }

        public virtual IList<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual IList<T> GetAllOrdered<TKey>(Func<T, TKey> orderCondition)
        {
            return DbSet.OrderBy(orderCondition).ToList();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> whereCondition)
        {
            return DbSet.Where(whereCondition).ToList();
        }

        public virtual T Add(T entity)
        {
            return DbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void Update(T entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> AsQueryable()
        {
            return DbSet.AsQueryable();
        }

        public virtual bool SaveChanges()
        {
            try
            {
                ((IObjectContextAdapter)dbContext).ObjectContext.CommandTimeout = CommandTimeout;
                return dbContext.SaveChanges() > 0;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var sb = new System.Text.StringBuilder();
                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new ApplicationException(sb.ToString());
            }
        }

        public virtual IQueryable<T> GetIncluding(string[] includes)
        {
            IQueryable<T> query = null;
            includes.ToList().ForEach(x => query = query.Include(x));

            return query;
        }

        public virtual IQueryable<T> GetIncluding(string[] includes, Expression<Func<T, bool>> whereCondition)
        {
            var query = DbSet.AsQueryable().Where(whereCondition);
            includes.ToList().ForEach(x => query = query.Include(x));

            return query;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                    dbContext = null;
                }
            }
        }
    }
}
