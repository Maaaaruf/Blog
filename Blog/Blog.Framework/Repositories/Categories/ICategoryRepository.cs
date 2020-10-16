using Blog.Data.BaseRepository;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Repositories.Categories
{
    public interface ICategoryRepository : IRepository<Category, InHibernetFrameworkSession>
    {

    }
}
