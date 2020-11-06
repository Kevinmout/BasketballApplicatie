using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLogic
{
    public class Rating
    {
        public string Name { get; }
        private List<Player> BestPlayers { get;}

        public List<Player> GetPlayers()
        {
            return BestPlayers;
        }
        public Rating()
        {
            Name = "Best starting 5 of all-time";
            BestPlayers = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            BestPlayers.Add(player);
        }
    }
}
