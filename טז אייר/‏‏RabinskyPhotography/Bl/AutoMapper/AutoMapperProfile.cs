using AutoMapper;

namespace Bl.AutoMapper
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Dal.Do.Customer, BLAllCustomer>().ReverseMap();
            CreateMap<Dal.Do.Customer, BLCustomer>().ReverseMap();
            CreateMap<Dal.Do.Photographer, BLPhotographer>().ReverseMap();
            CreateMap<Dal.Do.Price, BLPrice>().ReverseMap();
        }
    }
}
