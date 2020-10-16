using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.User.Models.Articles
{
    public class ArticleModel : ArticleBaseModel
    {
        public IList<Article> Articles { get; set; }

        public IList<Article> GetArticles()
        {
            var data = _articleService.GetAll();
            return data;
        }

        internal void Delete(int id)
        {
            _articleService.Remove(id);
        }
    }
}