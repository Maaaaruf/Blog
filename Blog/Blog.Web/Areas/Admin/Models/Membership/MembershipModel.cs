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

        public void GetUsers()
        {
            using (var context = new ApplicationDbContext())
            {
                Users = context.Users.ToList();
            }
        }


        public void EditUser()
        {
            using (var context = new ApplicationDbContext())
            {

                ApplicationUser ExistingUser = context.Users.Where(x => x.Id == this.Id).FirstOrDefault();

                if (ExistingUser != null)
                {
                    ExistingUser.PhoneNumber = PhoneNumber;
                    ExistingUser.UserName = UserName;
                    ExistingUser.Email = Email;

                    context.SaveChanges();
                }
            }
        }


        public void DeleteUser(string id)
        {
            if(id != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    ApplicationUser user = context.Users.Where(x => x.Id == id).FirstOrDefault();
                    context.Users.Remove(user);
                }
            }
        }
    }
}