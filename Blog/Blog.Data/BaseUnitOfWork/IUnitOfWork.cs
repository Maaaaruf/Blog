using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.BaseUnitOfWork 
{
    public interface IUnitOfWork : IDisposable
    {
        public void BeginTransaction();
        public void Commit();
        public void Rollback();
    }
}
