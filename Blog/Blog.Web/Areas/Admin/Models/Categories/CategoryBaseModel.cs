using Autofac;
using Blog.Framework.Services.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.Admin.Models.Categories
{
    public class CategoryBaseModel
    {
        protected readonly ICategoryService _categoryService;
        public CategoryBaseModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public CategoryBaseModel()
        {
            _categoryService = Startup.AutofacContainer.Resolve<ICategoryService>();
        }
    }
}