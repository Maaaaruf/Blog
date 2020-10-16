using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services.Articles
{
    public interface IArticleService
    {
        public IList<Article> GetAll();
    }
}
