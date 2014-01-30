using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace APIServiceStack2014
{
    [Route("/Hello")]
    [Route("/Hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }
}