using Logic.Interface.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace APPBasketbal.Models
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        
        public Player(int id, string firstname)
        {
            Id = id;
            FirstName = firstname;
        }
        public Player(PlayerDto playerDto):this(playerDto.Id,playerDto.FirstName)
        {
            
        }

    }
}
