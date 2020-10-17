using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.Admin.Models.Categories
{
    public class EditCategoryModel : CategoryBaseModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is IMPORTANT")]
        public string Name { get; set; }


        public void Edit()
        {
            var category = _categoryService.GetById(this.Id);
            category.Id = this.Id;
            category.Name = this.Name;

            _categoryService.Update(category);
        }

        public void Load(int Id)
        {
            var category = _categoryService.GetById(Id);

            this.Id = category.Id;
            this.Name = category.Name;
        }
    }
}