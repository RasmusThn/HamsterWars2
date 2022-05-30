using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace HamsterWars2
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hamster, HamsterDto>();
            CreateMap<Match, MatchDto>();
            CreateMap<HamsterForCreationDto, Hamster>();
            CreateMap<MatchForCreationDto, Match>();
            CreateMap<HamsterForUpdateDto, Hamster>();
        }
    }
}
