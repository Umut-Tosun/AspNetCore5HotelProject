using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
          
            CreateMap<CreateUserDto, Service>().ReverseMap();
            CreateMap<ResultUserDto, Service>().ReverseMap();
            CreateMap<UpdateUserDto, Service>().ReverseMap();

            CreateMap<CreateUserDto,AppUser>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();
          

        }
    }
}
