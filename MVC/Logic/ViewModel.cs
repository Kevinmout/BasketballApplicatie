using APPBasketbal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class ViewModel
    {
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Team> Teams { get; set; }
    }
}
