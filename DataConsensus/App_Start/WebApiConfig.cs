﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json.Serialization;

namespace DataConsensus.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)

        {

            var cors = new EnableCorsAttribute("*", "*", "*");//origins,headers,methods   
            configuration.EnableCors(cors);
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
              new { id = RouteParameter.Optional });
            var jsonFormatter = configuration.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            configuration.Formatters.Remove(configuration.Formatters.XmlFormatter);
            jsonFormatter.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;


        }
    }
}