using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.DataAnnotations;
using APIServiceStack2014.DTO.Response;

namespace APIServiceStack2014.DTO.Request
{
    [Route("Miembro")]
    [Route("Miembro/{Id}")]
    public class Miembro : IReturn<MiembroResponse>
    {
        [Alias("Id")]
        public long? Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Apellidos { get; set; }
    }
}

