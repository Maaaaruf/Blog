using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var model = new CategoryModel();
            model.Articles = model.GetArticles();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateArticleModel model)
        {
            model.CreateArticle();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = new EditArticleModel();
            model.Load(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditArticleModel model)
        {
            if (ModelState.IsValid)
            {
                model.Edit();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }


        public ActionResult Delete(int id)
        {
            var model = new ArticleModel();
            model.Delete(id);
            return RedirectToAction("Index");
        }
    }
}