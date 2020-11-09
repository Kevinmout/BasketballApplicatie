using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesBasketball.Models
{
    public class AddressModel
    {
        public string City { get; set; }
        public string State { get; set; }
        public string zipCode { get; set; }
        public string StreetAddress { get; set; }
    }
}
