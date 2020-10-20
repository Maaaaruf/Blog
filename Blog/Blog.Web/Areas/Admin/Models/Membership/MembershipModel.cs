using Blog.Web.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Areas.Admin.Models.Membership
{
    public class MembershipModel : ApplicationUser
    {

        public IList<ApplicationUser> Users { get; set; }
    }
}