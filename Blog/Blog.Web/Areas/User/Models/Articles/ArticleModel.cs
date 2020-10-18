using Autofac;
using Blog.Framework.Entities;
using Blog.Framework.Services.Categories;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.User.Models.Articles
{
    public class ArticleModel : ArticleBaseModel
    {
        
        public IList<Article> Articles { get; set; }
        public IList<Category> Categories { get; set; }
        public int CategoryHalfCount { get; set; }
        ICategoryService _categoryService = Startup.AutofacContainer.Resolve<ICategoryService>();

        public void GetArticles()
        {
            Articles = _articleService.GetAll();
            Categories = _categoryService.GetAll();
            CategoryHalfCount = Categories.Count / 2;
        }

        internal void GetArticlesByCategory(int categoryId)
        {
            Articles = _articleService.GetByCategoryId(categoryId);
            if (Categories == null)
            {
                Categories = _categoryService.GetAll();
                CategoryHalfCount = Categories.Count / 2;
            }

        }

        internal void Delete(int id)
        {
            _articleService.Remove(id);
        }
    }
}