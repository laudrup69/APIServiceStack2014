using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using ServiceStack;
using ServiceStack.Text;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace APIServiceStack2014
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Se le dice a service stack el nombre del servicio web y donde encontrar los servicos.
        /// </summary>
        public AppHost()
            : base("Hello Web Service", typeof(HelloService).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
            // register user-defined REST-ful urls (Optional)
            Routes
                .Add<Hello>("/hello")
                .Add<Hello>("/hello/{Name}");

            //JSON
            JsConfig.EmitCamelCaseNames = true;
            JsConfig.IncludeNullValues = false;
            JsConfig.DateHandler = DateHandler.ISO8601;
            JsConfig.EscapeUnicode = true;


            //container.Register<IDbConnectionFactory>(c =>
            //    new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["ManHouse"].ConnectionString, SqliteDialect.Provider));
            //container.RegisterAutoWired<Repository>().ReusedWithin(ReuseScope.None);
            var dbfactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["ManHouse"].ConnectionString, SqliteDialect.Provider);
            container.Register<IDbConnectionFactory>(dbfactory);
        }
    }
}