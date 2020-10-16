using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Entities.Overrides
{
    public class CategoryOverride : IAutoMappingOverride<Category>
    {
        public void Override(AutoMapping<Category> mapping)
        {
        }
    }
}
