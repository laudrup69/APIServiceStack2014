using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.DataAnnotations;
using APIServiceStack2014.DTO.Response;

namespace APIServiceStack2014.DTO.Request
{
    [Route("Miembros/{Id}", "GET")]
    public class Miembro : IReturn<MiembroResponse>
    {
        public long? Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
    }
}

