using Blog.Framework.Entities;
using Blog.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services
{
    public class ArticleService : IArticleService
    {
        private IRepository<Article> _articleRepository;

        public ArticleService(IRepository<Article> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IList<Article> GetAll()
        {
            return _articleRepository
                .GetAll()
                .ToList();
        }

        public Article GetById(int id)
        {
            return _articleRepository.GetById(id);
        }

        public void Create(Article article)
        {
            _articleRepository.Create(article);
        }

        public void Update(Article article)
        {
            _articleRepository.Update(article);
        }

        public void Delete(int id)
        {
            _articleRepository.Delete(id);
        }
    }
}
