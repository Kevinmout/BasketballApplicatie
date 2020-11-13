using System;
using System.Collections.Generic;

namespace ApplicatieBasketbal.Models.DBModels
{
    public partial class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
