using Blog.Framework.Entities;
using Blog.Framework.Entities.Overrides;
using Blog.Framework.Sessions.Configurations;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Sessions
{
    public class FrameworkSession
    {
        public FrameworkSession()
        {
            Session = _sessionFactory.OpenSession();
        }

        private static readonly ISessionFactory _sessionFactory;
        public ISession Session { get; set; }

        static FrameworkSession()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey("DefaultConnection")))
                .Mappings(x => x.AutoMappings.Add(
                    AutoMap.AssemblyOf<Article>(new AutomappingConfiguration()).UseOverridesFromAssemblyOf<ArticleOverride>()))
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
                .BuildSessionFactory();
        }
    }
}