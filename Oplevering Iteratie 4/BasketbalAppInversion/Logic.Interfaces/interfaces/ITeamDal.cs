using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interface.interfaces
{
    public interface ITeamDal
    {
        List<TeamDto> GetData();
        List<PlayerDto> GetById(int id);
        TeamDto GetTeamById(int id);
        void Create(TeamDto teamDto);
        void Delete(int id);
        void Edit(TeamDto teamDto);
    }
}
