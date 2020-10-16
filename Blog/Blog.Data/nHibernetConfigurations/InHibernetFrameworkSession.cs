using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.nHibernetConfigurations
{
    public interface InHibernetFrameworkSession
    {
        public ISession Session { get; set; }
    }
}
