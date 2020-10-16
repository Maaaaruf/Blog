using Autofac;
using Blog.Framework.Entities;
using Blog.Framework.Services.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Models
{
    public class ArticleModel
    {
        public IArticleService _articleService { get; set; }
        public ArticleModel(ArticleService articleService)
        {
            _articleService = articleService;
        }

        public ArticleModel()
        {
            _articleService = Startup.AutofacContainer.Resolve<IArticleService>();
        }

        public IList<Article> GetAllArticle()
        {
            return _articleService.GetAll();
        }


    }
}