using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Entities
{
    public class Article : IEntity
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Body { get; set; }
    }
}
