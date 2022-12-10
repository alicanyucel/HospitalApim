using AutoMapper;
using HospitalWebApi.Dtos;
using HospitalWebApi.Models;

namespace HospitalWebApi.Mapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Doctor, DoctorDto>().ReverseMap();
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<DoctorHospital, DrHospitalDto>().ReverseMap();
            
           


        }
    }
}
