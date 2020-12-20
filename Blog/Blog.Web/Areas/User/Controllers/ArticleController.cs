using Blog.Framework.Entities;
using Blog.Web.Areas.User.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Blog.Web.Areas.User.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {

        [AllowAnonymous]
        // GET: User/Home
        public ActionResult Index()
        {
            var model = new ArticleModel();
            model.GetArticles();
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult IndexByCategory(int id)
        {
            var model = new ArticleModel();
            model.GetArticlesByCategory(id);
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new CreateArticleModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateArticleModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreateArticle();
                    return RedirectToAction("Index");
                }catch (Exception e)
                {
                    //TODO Add Logger Code
                    //TODO Add Notification
                }
            }
            return View(model);

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