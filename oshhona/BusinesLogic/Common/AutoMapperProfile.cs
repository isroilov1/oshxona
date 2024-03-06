using AutoMapper;

namespace oshhona.BusinesLogic.Common;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<FoodTypes, FoodTypeDto>()
            .ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImageUrl))
            .ReverseMap();
    }
}
