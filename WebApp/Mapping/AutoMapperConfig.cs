using AutoMapper;
using Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<LendBookViewModel, Book>().ReverseMap()
                .ForMember(dest => dest.BookOwner, opt => opt.MapFrom(src => src.BookOwner))
                .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.BookId))
                .ForMember(dest => dest.ReturnDate, opt => opt.MapFrom(src => src.ReturnDate));
        }
    }
}
