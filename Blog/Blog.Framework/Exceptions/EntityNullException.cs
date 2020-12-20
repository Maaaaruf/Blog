using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Exceptions
{
    public  class EntityNullException<T>:Exception
    {
        public Type EntityType { get; set; }
        public EntityNullException()
            :base($"Entity Null Exception for entity {typeof(T).FullName}")
        {
            EntityType = typeof(T);
        }
    }
}
