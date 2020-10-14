using Blog.Framework.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mapping
{
    public class ArticleOverride : IAutoMappingOverride<Article>
    {
        public void Override(AutoMapping<Article> mapping)
        {
        }
    }
}
