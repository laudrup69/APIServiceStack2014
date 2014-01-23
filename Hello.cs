using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace APIServiceStack2014
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }
}