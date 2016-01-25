using Castle.Core.Logging;
using System;
using System.Web.Mvc;

namespace Rf.Web.Configuration
{
    public class ExceptionFilters : HandleErrorAttribute
    {
        private ILogger _logger;

        public ExceptionFilters(ILogger logger)
        {
            _logger = logger;
        }

        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is Exception)
            {
                _logger.Error(filterContext.Exception.Message, filterContext.Exception);
            }

            base.OnException(filterContext);
        }
    }
}