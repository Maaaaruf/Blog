using FluentNHibernate.Mapping;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Membership.Entities
{
    public class User : IUser<int>
    {
        public virtual int Id { get; protected set; }
        public virtual string UserName { get; set; }
        public virtual string PasswordHash { get; set; }

        public class Map : ClassMap<User>
        {
            public Map()
            {
                Id(x => x.Id).GeneratedBy.Identity();
                Map(x => x.UserName).Not.Nullable();
                Map(x => x.PasswordHash).Not.Nullable();
            }
        }
    }
}
