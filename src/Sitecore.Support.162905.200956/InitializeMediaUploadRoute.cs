using Sitecore.Configuration;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sitecore.Support.Mvc.Pipelines.Initialize
{
    class InitializeMediaUploadRoute
    {
        public virtual void Process(PipelineArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            this.RegisterRoutes(RouteTable.Routes, args);
        }

        protected virtual void RegisterRoutes(RouteCollection routes, PipelineArgs args)
        {
            routes.MapRoute(
             "Sitecore.Support.162905.200956.Speak.Commands",
             "sitecore/shell/api/sitecore/Media/{action}",
             new { controller = "Media", action = "Upload", id = UrlParameter.Optional },
             new[] { "Sitecore.Support.Controllers" }
        );

        }
    }
}
