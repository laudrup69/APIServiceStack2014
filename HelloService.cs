using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace APIServiceStack2014
{
    public class HelloService : Service
    {
        /// <summary>
        /// Implementación del servicio Hello
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public object Get(Hello request)
        {
            String resultado = String.Empty;

            resultado = request.Name;

            return new HelloResponse { Result = "Hoooolaaaa, " + resultado };
        }
    }
}