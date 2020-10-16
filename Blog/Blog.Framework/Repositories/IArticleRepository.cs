using Blog.Data;
using Blog.Framework.Entities;
using Blog.Framework.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Repositories
{
    public interface IArticleRepository : IRepository<Article,InHibernetFrameworkSession>
    {
    }
}
