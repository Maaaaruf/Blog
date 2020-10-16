using Blog.Data.BaseUnitOfWork;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Repositories.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.UnitOfWorks.Articles
{
    public class ArticleUnitOfWork : UnitOfWork, IArticleUnitOfWork
    {
        public IArticleRepository ArticleRepository { get; set; }
        public ArticleUnitOfWork(InHibernetFrameworkSession session,
            IArticleRepository articleRepository) 
            : base(session)
        {
            ArticleRepository = articleRepository;
        }
    }
}
