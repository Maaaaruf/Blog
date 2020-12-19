using Blog.Framework.Entities;
using Blog.Framework.UnitOfWorks.Articles;
using Blog.Framework.UnitOfWorks.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        public IArticleUnitOfWork _articleUnitOfWork { get; set; }

        public CategoryService(IArticleUnitOfWork articleUnitOfWork)
        {
            _articleUnitOfWork = articleUnitOfWork;
        }


        //summary
        // Get a list of all category from DB
        //summary
        public IList<Category> GetAll()
        {
            var categories = _articleUnitOfWork.CategoryRepository.GetAll();
            return categories;
        }


        //summary
        // Create a Category
        //summary
        public void Create(Category category)
        {
            _articleUnitOfWork.BeginTransaction();
            

            try
            {
                _articleUnitOfWork.CategoryRepository.Add(category);
                _articleUnitOfWork.Commit();
            } catch ( Exception e)
            {
                _articleUnitOfWork.Rollback();
            }
        }

        public void Update(Category category)
        {
            _articleUnitOfWork.BeginTransaction();
            try
            {
                _articleUnitOfWork.CategoryRepository.Edit(category);
                _articleUnitOfWork.Commit();
            }
            catch (Exception)
            {
                _articleUnitOfWork.Rollback();
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category category)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            _articleUnitOfWork.BeginTransaction();

            try
            {
                _articleUnitOfWork.CategoryRepository.Remove(id);
                _articleUnitOfWork.Commit();
            }
            catch (Exception)
            {
                _articleUnitOfWork.Rollback();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            Category category = _articleUnitOfWork.CategoryRepository.GetById(id);
            return category;
        }
    }
}
