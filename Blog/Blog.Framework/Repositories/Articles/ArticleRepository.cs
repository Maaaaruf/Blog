using Blog.Data;
using Blog.Data.BaseRepository;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Entities;
using Blog.Framework.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Repositories.Articles
{
    public class ArticleRepository : Repository<Article, InHibernetFrameworkSession>, IArticleRepository
    {
        public ArticleRepository(InHibernetFrameworkSession sessionFactory) : base(sessionFactory)
        {
        }
    }
}
