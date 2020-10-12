using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Entities
{
    public class Article : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Tittle { get; set; }
        public virtual string Body { get; set; }
    }
}
