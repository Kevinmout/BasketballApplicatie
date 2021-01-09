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
        PlayerDto GetById(int id);
    }
}
