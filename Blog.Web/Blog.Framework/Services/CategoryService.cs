using Blog.Framework.Entities;
using Blog.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IList<Category> GetAll()
        {
            var categories =  _categoryRepository.GetAll().ToList();
            return categories;
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Create(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
}
