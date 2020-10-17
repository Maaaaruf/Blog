using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.Admin.Models.Categories
{
    public class CreateCategoryModel : CategoryBaseModel
    {
        public string Name { get; set; }

        public void CreateCategory()
        {
            Category category = new Category
            {
                Name = this.Name
            };

            _categoryService.Create(category);
        }
    }
}