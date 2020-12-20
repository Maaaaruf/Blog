using Blog.Web.Areas.Admin.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {

        // GET: Admin/Category
        public ActionResult Index()
        {
            var model = new CategoryModel();
            if (ModelState.IsValid)
            {
                model.Categories = model.GetCategories();
            }
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreateCategory();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = new EditCategoryModel();
            model.Load(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditCategoryModel model)
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
            var model = new CategoryModel();
            if (ModelState.IsValid)
            {
                model.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}