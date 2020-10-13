using Blog.Framework.Entities;
using Blog.Framework.Services;
using Blog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : BaseController
    {
        private IArticleService _articleService;
        private ICategoryService _categoryService;

        public HomeController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            // ensure there are products for the example
            //if (!_articleService.GetAll().Any())
            //{
                _articleService.Create(new Article { Title = "Learn Core MVC" , PostedOn = DateTime.Now });
                _articleService.Create(new Article { Title = "Learn nHibernet", PostedOn = DateTime.Now });
                _articleService.Create(new Article { Title = "Learn ASP.NET MVC", PostedOn = DateTime.Now });

            _categoryService.Create(new Category {  Name = "MVC"});
            _categoryService.Create(new Category { Name = "nHibernet"});
            _categoryService.Create(new Category { Name = "ASP.NET MVC" });
            //}

            var model = new ArticleModel();
            model.Articles = _articleService.GetAll();

            return View(model);
        }
    }
}