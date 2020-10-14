using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Services
{
    public interface ICategoryService
    {
        IList<Category> GetAll();
        Category GetById(int id);
        void Create(Category article);
        void Update(Category article);
        void Delete(int id);
    }
}
