using AutoMapper;
using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Dtos;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorHospitalControler : ControllerBase
    {
        //on yüz angular tarafı yazılacak.
        
        private readonly IDoctorService _drservice;
    
        private readonly IMapper _mapper;
        private readonly IDoctorHospitalDetailService _drhpservice;
        public DoctorHospitalControler(IMapper mapper, IDoctorHospitalDetailService drhpservice, IDoctorService doctorService)
        {
            
            _drservice = doctorService;
            
            _mapper = mapper;
            _drhpservice = drhpservice;
        }
        
        [HttpGet("{tc}")]
        public IActionResult GetByDoctorTc(string tc)
        {
            List<Doctor> doctor = _drservice.GetDoctors().ToList();
            List<Doctor> item = new List<Doctor>();
            item = doctor;
            int i = 0;
            for (; i < item.Count; i++)
            {

                if (item[i].TcNo != tc)
                {


                }
                else if (item[i].TcNo == tc)
                {

                    List<Doctor> bulunan = new List<Doctor>();
                    bulunan.Add(item[i]);
                    return Ok(bulunan);

                }
               


            }
            return Ok();
        }

    }
}
