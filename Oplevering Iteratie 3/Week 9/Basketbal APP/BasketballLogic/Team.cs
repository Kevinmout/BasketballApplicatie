using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLogic
{
    public class Team
    {
        public string Name { get; }

        private List<Player> players { get; }
        public List<Player> GetPlayers()
        {
            return players;
        }
        public Team()
        {
            Name = "My Team";
            players = new List<Player>();
        }




        /// <summary>
        /// This is to add a player to your team
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player)
        {
            if (!(players.Contains(player)))
            {
                players.Add(player);
            }
        }
    }
}
