using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Web.Models
{
    public class ArticleModel
    {
        public IList<Article> Articles { get; set; }

        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }
    }
}