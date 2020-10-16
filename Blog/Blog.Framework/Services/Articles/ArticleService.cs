using Blog.Framework.Entities;
using Blog.Framework.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services.Articles
{
    public class ArticleService : IArticleService
    {
        public IArticleUnitOfWork _articleUnitOfWork { get; set; }

        public ArticleService(IArticleUnitOfWork articleUnitOfWork)
        {
            _articleUnitOfWork = articleUnitOfWork;
        }


        //summary
        // Get a list of all article from DB
        //summary
        public IList<Article> GetAll()
        {
            var articles = _articleUnitOfWork.ArticleRepository.GetAll();
            return articles;
        }
    }
}
