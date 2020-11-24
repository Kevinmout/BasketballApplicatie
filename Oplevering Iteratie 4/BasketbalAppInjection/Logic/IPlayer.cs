using APPBasketbal.Models;
using System.Collections.Generic;

namespace Logic
{
    public interface IPlayer
    {
        IEnumerable<Player> GetPlayers();
    }
}
