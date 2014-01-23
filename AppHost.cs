using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

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
            //throw new NotImplementedException();
        }
    }
}