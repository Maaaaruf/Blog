using Blog.Data;
using Blog.Framework.Entities;
using Blog.Framework.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Repositories
{
    public class ArticleRepository : Repository<Article, int, IDataSession>, IArticleRepository
    {
        public ArticleRepository(IDataSession sessionFactory) : base(sessionFactory)
        {
        }
    }
}
