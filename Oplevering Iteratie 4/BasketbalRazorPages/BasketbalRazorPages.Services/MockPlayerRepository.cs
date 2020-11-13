using BasketbalRazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketbalRazorPages.Services
{
    public class MockPlayerRepository : IPlayerRepository
    {
        private List<Player> _players;
        public MockPlayerRepository()
        {
            _players = new List<Player>()
            {
                new Player() {FirstName ="LeBron",LastName="James",ActiveTeam = "Lakers" },
                new Player() {FirstName ="Stephen",LastName="Curry",ActiveTeam = "Warriors" },
                new Player() {FirstName ="Kyrie",LastName="Irving",ActiveTeam = "Nets" }
            };
        }
        public IEnumerable<Player> GetPlayers()
        {
            return _players;
        }
    }
}
