using AutoMapper;
using Commander.Dtos;
using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Profiles
{
    //the main use is to create the automapper from command to commandreaddto
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //creating map from command to commandreaddto
            CreateMap<Command, CommandReadDto>();

            //creating map from commandcreatedto to command
            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>();

            //for patch request
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
