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

namespace Blog.Data.Configurations
{
    public class ConnectionHelper<Entity, Override>
    {
        protected ISessionFactory _sessionFactory;

        protected ISessionFactory GetSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.FromConnectionStringWithKey("UnitOfWorkExample")))
                .Mappings(x => x.AutoMappings.Add(
                    AutoMap.AssemblyOf<Entity>(new AutomappingConfiguration()).UseOverridesFromAssemblyOf<Override>()))
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
                .BuildSessionFactory();
        }
    }
}
