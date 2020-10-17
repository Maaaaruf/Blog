using Blog.Data.nHibernetConfigurations;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BaseRepository
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

        

        public virtual void Add(TEntity entity)
        {
            _session.Save(entity);
        }

        public virtual void Edit(TEntity entityToUpdate)
        {
            _session.Update(entityToUpdate);
        }

        public virtual IList<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return _session.QueryOver<TEntity>().Where(filter).List();
        }

        public virtual IList<TEntity> GetAll()
        {
            return _session.Query<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _session.Get<TEntity>(id);
        }

        public virtual int GetCount(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(int id)
        {
            _session.Delete(_session.Load<TEntity>(id));
        }

        public virtual void Remove(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
