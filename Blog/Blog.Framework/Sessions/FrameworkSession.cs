using Blog.Data;
using Blog.Data.nHibernetConfigurations;
using Blog.Framework.Entities;
using Blog.Framework.Entities.Overrides;
using Blog.Framework.Sessions.Configurations;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Data;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Sessions
{
    public class FrameworkSession : InHibernetFrameworkSession
    {
        private string _connectionStringName;
        public ISessionFactory SessionFactory { get; set; }
        public ISession Session { get; set; }

        public FrameworkSession(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
             Session = CreateSessionFactory(_connectionStringName).OpenSession();
             SessionFactory = CreateSessionFactory(_connectionStringName);
        }

        private ISessionFactory CreateSessionFactory(string connectionStringName)
        {
            if (SessionFactory != null)
            {
                return SessionFactory;
            }

            SessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey(connectionStringName)))
                .Mappings(x => x.AutoMappings.Add(
                    AutoMap.AssemblyOf<Article>(new AutomappingConfiguration()).UseOverridesFromAssemblyOf<ArticleOverride>()))
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
                .BuildSessionFactory();
            return SessionFactory;

        }
    }
}