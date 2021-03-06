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

namespace APIServiceStack2014.POCO
{
	[Alias("Orders")]
    public partial class OrderPOCO : IPOCO, IHasId<long> 
    {
        [Alias("Id")]
        public long? Id { get; set;}
        [StringLength(8000)]
        public string CustomerId { get; set;}
        [Required]
        public long EmployeeId { get; set;}
        [StringLength(8000)]
        public string OrderDate { get; set;}
        [StringLength(8000)]
        public string RequiredDate { get; set;}
        [StringLength(8000)]
        public string ShippedDate { get; set;}
        public long? ShipVia { get; set;}
        [Required]
        public decimal Freight { get; set;}
        [StringLength(8000)]
        public string ShipName { get; set;}
        [StringLength(8000)]
        public string ShipAddress { get; set;}
        [StringLength(8000)]
        public string ShipCity { get; set;}
        [StringLength(8000)]
        public string ShipRegion { get; set;}
        [StringLength(8000)]
        public string ShipPostalCode { get; set;}
        [StringLength(8000)]
        public string ShipCountry { get; set;}
        public DateTime? LastUpdated { get; set;}
    }
}
#pragma warning restore 1591
