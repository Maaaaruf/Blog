using Autofac;
using Blog.Web.Areas.User.Models.Articles;
using Blog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleModel>()
                .InstancePerLifetimeScope();
        }

    }
}