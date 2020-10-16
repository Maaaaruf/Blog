using Blog.Framework.Entities;
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
        [Required(ErrorMessage = "Title is IMPORTANT")]
        public virtual string Title { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Description is IMPORTANT")]
        public virtual string Description { get; set; }
        public virtual string ImageURL { get; set; }
        [DisplayName("Publish Instantly?")]
        public virtual bool isPublished { get; set; }
        [DisplayName("Catagory")]
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

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