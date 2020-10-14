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
    [Authorize]
    public class CategoryController : BaseController
    {
        private ICategoryService _categoryService;

        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            IList<Category> model = _categoryService.GetAll();
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new CategoryModel();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Create(new Category
                {
                    Name = model.Name
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        
        public ActionResult Edit(int id)
        {
            var data = _categoryService.GetById(id);
            var model = new CategoryModel { Name = data.Name };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(new Category
                {
                    Id = model.Id,
                    Name = model.Name
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}