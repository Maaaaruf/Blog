using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services.Categories
{
    public interface ICategoryService
    {
        public IList<Category> GetAll();
        public void Create(Category article);
        public void Update(Category article);
        public void Update(int id);
        public void Remove(Category article);
        public void Remove(int id);
        Category GetById(int id);
    }
}
