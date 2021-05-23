using AutoMapper;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Models;

namespace DeskSimAPI.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game,GameCreateDto>();
            CreateMap<GameCreateDto,Game>();
        }
        
    }
}