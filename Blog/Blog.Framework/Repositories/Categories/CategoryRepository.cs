using Blog.Data.BaseRepository;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Entities;
using Blog.Framework.Repositories.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Repositories.Categories
{
    public class CategoryRepository : Repository<Category, InHibernetFrameworkSession>, ICategoryRepository
    {
        public CategoryRepository(InHibernetFrameworkSession sessionFactory) : base(sessionFactory)
        {
        }
    }
}
