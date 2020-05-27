using AutoMapper;
using AdvertApi.Models;

namespace AdvertApi.Services
{
    public class AdvertProfile:Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertDbModel, AdvertModel>().ReverseMap();
        }

    }
}
