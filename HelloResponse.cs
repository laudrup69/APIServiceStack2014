using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace APIServiceStack2014
{
    /// <summary>
    /// Clase response DTO
    /// </summary>
    public class HelloResponse
    {
        public ResponseStatus ResponseStatus { get; set; }

        public string Result { get; set; }
    }
}