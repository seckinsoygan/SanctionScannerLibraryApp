using AutoMapper;
using Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<LendBookViewModel, Book>().ReverseMap();
        }
    }
}
