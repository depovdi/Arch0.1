using Castle.Core.Logging;
using Castle.Windsor;
using Rf.Web.Configuration;
using System.Web;
using System.Web.Mvc;

namespace Rf.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, IWindsorContainer container)
        {
            filters.Add(new ExceptionFilters(container.Kernel.Resolve<ILogger>()));
        }
    }
}