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
    public class CreateArticleModel : ArticleBaseModel
    {
        public CreateArticleModel()
        {
            Categories = _categoryService.GetAll();
        }

        [Required(ErrorMessage = "Title is IMPORTANT")]
        public virtual string Title { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Description is IMPORTANT")]
        public virtual string Description { get; set; }
        public virtual string ImageURL { get; set; }
        [DisplayName("Publish Instantly?")]
        public virtual bool isPublished { get; set; }
        [DisplayName("Catagory")]
        [Required(ErrorMessage = "Catagory is IMPORTANT")]
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public ICategoryService _categoryService = Startup.AutofacContainer.Resolve<ICategoryService>();

        public void CreateArticle()
        {

            //TODO: Link User with Article

            //int userIdValue = 0;
            //var claimsIdentity = User.Identity as ClaimsIdentity;
            //if (claimsIdentity != null)
            //{
            //    // the principal identity is a claims identity.
            //    // now we need to find the NameIdentifier claim
            //    var userIdClaim = claimsIdentity.Claims
            //        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

            //    if (userIdClaim != null)
            //    {
            //        userIdValue = userIdClaim.Value;
            //    }
            //}




            Article article = new Article
            {
                Category = this.Category,
                CategoryId = this.CategoryId,
                Descreption = this.Description,
                ImageURL = this.ImageURL,
                isPublished = this.isPublished,
                Title = this.Title,
                PostedOn = DateTime.UtcNow.AddHours(6)
            };

            
            _articleService.Create(article);
        }
    }
}