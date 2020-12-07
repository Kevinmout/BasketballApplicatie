using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using System.Collections.Generic;

namespace Logic
{
    public interface IPlayerDal
    {
        PlayerListDto GetPlayerList();
    }
}
