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
        public void Create(Article article);
        public void Update(Article article);
        public void Update(int id);
        public void Remove(Article article);
        public void Remove(int id);
        Article GetById(int id);
        IList<Article> GetByCategoryId(int categoryId);
    }
}
