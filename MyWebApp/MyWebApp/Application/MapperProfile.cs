using AutoMapper;
using MyLibrary;
using MyWebApp.Models;

namespace MyWebApp.Application
{
    public class MapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<MyValueObject, HomeViewModel>();
        }
    }
}