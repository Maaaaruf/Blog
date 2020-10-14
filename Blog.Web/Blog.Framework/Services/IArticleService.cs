using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services
{
    public interface IArticleService
    {
        IList<Article> GetAll();
        Article GetById(int id);
        void Create(Article article);
        void Update(Article article);
        void Delete(int id);
    }
}
