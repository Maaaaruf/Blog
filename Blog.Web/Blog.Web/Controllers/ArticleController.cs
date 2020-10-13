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
    public class ArticleController : Controller
    {
        private IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: Article
        public ActionResult Index()
        {
            var model = new ArticleModel();
            model.Articles = _articleService.GetAll();
            
            return View(model);
        }


        public ActionResult Create()
        {
            var model = new ArticleModel();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleModel model)
        {
            if (ModelState.IsValid)
            {
                _articleService.Create(new Article
                {
                    Title = model.Title,
                    Description = model.Description,
                    PostedOn = DateTime.UtcNow.AddHours(6),
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }


        public ActionResult Edit(int id)
        {
            var data = _articleService.GetById(id);
            var model = new ArticleModel { Title = data.Title, Description = data.Description, Id = data.Id };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleModel model)
        {
            if (ModelState.IsValid)
            {
                new ArticleModel { 
                    Title = model.Title, Description = model.Description, Id = model.Id };
                return RedirectToAction("Index");
            }
            return View(model);
        }




        public ActionResult Delete(int id)
        {
            _articleService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}