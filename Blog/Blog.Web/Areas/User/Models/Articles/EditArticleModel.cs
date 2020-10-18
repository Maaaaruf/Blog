using Antlr.Runtime.Tree;
using Autofac;
using Blog.Framework.Entities;
using Blog.Framework.Services.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Areas.User.Models.Articles
{
    public class EditArticleModel : ArticleBaseModel
    {
        public EditArticleModel()
        {
            Categories = _categoryService.GetAll();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Title is IMPORTANT")]
        public virtual string Title { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Description is IMPORTANT")]
        public virtual string Descreption { get; set; }
        public virtual string ImageURL { get; set; }
        [DisplayName("Publish Instantly?")]
        public virtual bool isPublished { get; set; }
        [DisplayName("Catagory")]
        [Required(ErrorMessage = "Catagory is IMPORTANT")]
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public ICategoryService _categoryService = Startup.AutofacContainer.Resolve<ICategoryService>();


        public void Edit()
        {
            var article = _articleService.GetById(this.Id);
            article.Id = this.Id;
            article.CategoryId = this.CategoryId;
            article.Descreption = this.Descreption;
            article.ImageURL = this.ImageURL;
            article.isPublished = this.isPublished;
            article.Title = this.Title;
            article.EditedOn = DateTime.UtcNow.AddHours(6);
            

            _articleService.Update(article);
        }

        public void Load(int Id) 
        {
            var article = _articleService.GetById(Id);

            this.Id = Id;
            //this.Category = article.Category;
            this.CategoryId = article.CategoryId;
            this.Descreption = article.Descreption;
            this.ImageURL = article.ImageURL;
            this.isPublished = article.isPublished;
            this.Title = article.Title;
        }
    }
}