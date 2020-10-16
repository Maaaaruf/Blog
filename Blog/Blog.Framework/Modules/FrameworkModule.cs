using Autofac;
using Blog.Data;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Entities;
using Blog.Framework.Entities.Overrides;
using Blog.Framework.Repositories;
using Blog.Framework.Repositories.Articles;
using Blog.Framework.Services.Articles;
using Blog.Framework.Sessions;
using Blog.Framework.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Framework.Modules
{
    public class FrameworkModule : Module
    {
        //protected override void Load(ContainerBuilder builder)
        //{
        //    builder.RegisterType<FrameworkSession>()
        //        .InstancePerLifetimeScope();
        //}



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

            //summary
            //Binding for nHibernate data class "FrameworkSession"
            //summary
            builder.RegisterType<FrameworkSession>().As<InHibernetFrameworkSession>()
                .WithParameter("connectionStringName", _connectionStringName)
                .SingleInstance();

            //summary
            //Bindings for Article
            //summary
            builder.RegisterType<ArticleUnitOfWork>().As<IArticleUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ArticleRepository>().As<IArticleRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ArticleService>().As<IArticleService>()
                .InstancePerLifetimeScope();

        }
    }
}
