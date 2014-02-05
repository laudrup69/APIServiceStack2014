// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace ManHouse
{
	[Alias("OrderDetails")]
    public partial class OrderDetail : IHasId<string> 
    {
        [Alias("Id")]
        [StringLength(8000)]
        public string Id { get; set;}
        [Required]
        public long OrderId { get; set;}
        [Required]
        public long ProductId { get; set;}
        [Required]
        public decimal UnitPrice { get; set;}
        [Required]
        public long Quantity { get; set;}
        [Required]
        public double Discount { get; set;}
        public DateTime? LastUpdated { get; set;}
    }
}
#pragma warning restore 1591