using Autofac;
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
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkSession>()
                .InstancePerLifetimeScope();
        }
    }
}
