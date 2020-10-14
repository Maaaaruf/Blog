using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Models
{
    public class CategoryModel
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }
    }
}