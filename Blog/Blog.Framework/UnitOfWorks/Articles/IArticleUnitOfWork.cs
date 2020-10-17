using Blog.Data.BaseUnitOfWork;
using Blog.Framework.Repositories.Articles;
using Blog.Framework.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.UnitOfWorks.Articles
{
    public interface IArticleUnitOfWork : IUnitOfWork, IDisposable
    {
        public IArticleRepository ArticleRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
    }
}
