using Blog.Data.BaseUnitOfWork;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.UnitOfWorks.Category
{
    public class CategoryUnitOfWork : UnitOfWork, ICategoryUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public CategoryUnitOfWork(InHibernetFrameworkSession session,
            ICategoryRepository categoryRepository) 
            : base(session)
        {
            CategoryRepository = categoryRepository;
        }

        
    }
}
