using AutoMapper;
using HospitalWebApi.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorHospitalControler : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDoctorHospitalDetailService _service;
    }
}
