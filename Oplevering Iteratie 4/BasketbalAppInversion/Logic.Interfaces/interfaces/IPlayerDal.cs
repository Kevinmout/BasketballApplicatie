using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using System.Collections.Generic;

namespace Logic
{
    public interface IPlayerDal
    {
        
        List<PlayerDto> GetData();
        List<PlayerDto> GetDataNotInTeam(int id);

        //CRUD
        void Create(PlayerDto player);
        PlayerDto GetById(int id);
        void Delete(int id);
        void Edit(PlayerDto player);

    }
}
