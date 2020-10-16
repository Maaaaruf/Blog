using Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Entities
{
    public class Article : IEntity<int>
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Descreption { get; set; }
        public virtual DateTime PostedOn { get; set; }
        public virtual DateTime EditedOn { get; set; }
        public virtual bool isPublished { get; set; }
    }
}
