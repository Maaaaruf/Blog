using Blog.Framework.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.User.Models
{
    public class MenuModel
    {
        public IList<MenuItem> MenuItems { get; set; }
    }
}