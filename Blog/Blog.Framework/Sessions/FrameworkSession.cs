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
    public class FrameworkSession<TEntity, TOverride>
    {
        private string _connectionStringName;
        public FrameworkSession(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
            Session = CreateSessionFactory(_connectionStringName).OpenSession();
        }

        private ISessionFactory _sessionFactory;
        public ISession Session { get; set; }

        private ISessionFactory CreateSessionFactory(string connectionStringName)
        {
            if (_sessionFactory != null)
            {
                return _sessionFactory;
            }

            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey(connectionStringName)))
                .Mappings(x => x.AutoMappings.Add(
                    AutoMap.AssemblyOf<Entity>(new AutomappingConfiguration()).UseOverridesFromAssemblyOf<TOverride>()))
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
                .BuildSessionFactory();
            return _sessionFactory;
            
        }
    }
}