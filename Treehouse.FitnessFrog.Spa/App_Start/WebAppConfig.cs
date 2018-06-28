using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Treehouse.FitnessFrog.Spa
{
    public static class WebAppConfig 
    {
        public static void Register(HttpConfiguration config)
        {
            var jsonSerializeSetting = config.Formatters.JsonFormatter.SerializerSettings;
            jsonSerializeSetting.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            jsonSerializeSetting.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }

    }
}