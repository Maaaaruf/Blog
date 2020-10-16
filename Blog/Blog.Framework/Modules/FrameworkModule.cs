using Autofac;
using Blog.Data;
using Blog.Framework.Entities;
using Blog.Framework.Entities.Overrides;
using Blog.Framework.Repositories;
using Blog.Framework.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Framework.Modules
{
    public class FrameworkModule : Module
    {
        private string _connectionStringName;

        public FrameworkModule(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
        }


        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<SessionStructure<Article, ArticleOverride>>()
            //    .WithParameter("connectionStringName", _connectionStringName)
            //    .InstancePerLifetimeScope();

            builder.RegisterType<FrameworkSession>().As<IDataSession>()
                .WithParameter("connectionStringName", _connectionStringName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ArticleRepository>().As<IArticleRepository>()
                .InstancePerLifetimeScope();
        }
    }
}
