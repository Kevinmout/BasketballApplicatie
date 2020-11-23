using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Logic.Interface.DTOs
{
    [DataContract]
    public class PlayerCollectionDto
    {
        [DataMember]
        public List<PlayerDto> Players { get; set; }
    }
}
