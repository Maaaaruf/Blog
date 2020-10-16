using Blog.Data.BaseUnitOfWork;
using Blog.Framework.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.UnitOfWorks.Category
{
    public interface ICategoryUnitOfWork : IUnitOfWork, IDisposable
    {
        public ICategoryRepository CategoryRepository { get; set; }
    }
}
