using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using System.Collections.Generic;

namespace Logic
{
    public interface IPlayerDal
    {
        PlayerDto GetById(int id);
        List<PlayerDto> GetData();
        void Create(PlayerDto player);
        void Delete(int id);
        void Edit(PlayerDto player);
    }
}
