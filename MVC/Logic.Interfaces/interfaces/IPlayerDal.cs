using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using System.Collections.Generic;

namespace Logic
{
    public interface IPlayerDal
    {
        
        List<PlayerDto> GetData();




        //CRUD
        void Create(PlayerDto player);
        void CreateInfo(PlayerDto player);
        PlayerDto GetById(int id);
        void Delete(int id);
        void Edit(PlayerDto player);

    }
}
