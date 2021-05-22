using AutoMapper;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Models;

namespace DeskSimAPI.Profiles
{
    public class CreatureProfile : Profile
    {
        public CreatureProfile()
        {
            CreateMap<Creature,CreatureCreateDto>();
            CreateMap<CreatureCreateDto,Creature>();
        }
        
    }
}