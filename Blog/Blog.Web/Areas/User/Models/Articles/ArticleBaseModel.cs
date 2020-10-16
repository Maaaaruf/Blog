using Autofac;
using Blog.Framework.Services.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.User.Models.Articles
{
    public class ArticleBaseModel : UserBaseModel
    {
        protected readonly IArticleService _articleService;
        public ArticleBaseModel(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public ArticleBaseModel()
        {
            _articleService = Startup.AutofacContainer.Resolve<IArticleService>();
        }
    }
}