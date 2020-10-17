using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.Admin.Models.Categories
{
    public class CategoryModel : CategoryBaseModel
    {
        public IList<Category> Categories { get; internal set; }

        internal IList<Category> GetCategories()
        {
            return _categoryService.GetAll();
        }

        internal void Delete(int id)
        {
            _categoryService.Remove(id);
        }
    }
}