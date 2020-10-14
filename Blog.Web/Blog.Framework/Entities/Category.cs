

using System.Collections.Generic;

namespace Blog.Framework.Entities
{
    public class Category : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }
    }
}