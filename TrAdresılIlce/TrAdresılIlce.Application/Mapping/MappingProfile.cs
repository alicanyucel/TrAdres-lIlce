using AutoMapper;
using TrAdresılIlce.Application.Features.Countries.SetCoutries;
using TrAdresılIlce.Domain.Entities;

namespace TrAdresılIlce.Application.Mapping;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Country, SetCountryCommand>().ReverseMap();    
    }
}
