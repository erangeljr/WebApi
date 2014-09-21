using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using WebApi.Common.Routing;
using WebApi.Web.Common;

namespace WebApi.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var contstraintResolver = new DefaultInlineConstraintResolver();
            contstraintResolver.ConstraintMap.Add("apiVersionContraint", typeof(ApiVersionConstraint));
            

            // Web API routes
            config.MapHttpAttributeRoutes(contstraintResolver);
            config.Services.Replace(typeof(IHttpControllerSelector), new NamespaceHttpControllerSelector(config));

      }
    }
}
