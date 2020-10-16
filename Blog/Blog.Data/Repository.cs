using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public abstract class Repository<TEntity, TSession>
        : IRepository<TEntity, TSession>
        where TEntity : class
        where TSession : InHibernetFrameworkSession
    {
        public ISession session { get; set; }

        private ISession _session;
        public Repository(TSession sessionFactory)     
        {
            _session = sessionFactory.Session;
            session = _session;
        }

        

        public void Add(TEntity entity)
        {
            _session.Save(entity);
        }

        public void Edit(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Remove(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
