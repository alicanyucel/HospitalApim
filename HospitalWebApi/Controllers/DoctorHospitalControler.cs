using AutoMapper;
using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Dtos;
using HospitalWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorHospitalControler : ControllerBase
    {
        private readonly IDoctorService _drservice;
        private readonly IHospitalService _hpservice;
        private readonly IMapper _mapper;
        private readonly IDoctorHospitalDetailService _drhpservice;
        public DoctorHospitalControler(IMapper mapper,IDoctorHospitalDetailService drhpservice,IDoctorService doctorService,IHospitalService hospitalService)
        {
            _drservice = doctorService;
            _hpservice = hospitalService;
            _mapper = mapper;
            _drhpservice = drhpservice;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           var result= _drhpservice.GetDoctorHospitals().ToList();
            var drhpmap = _mapper.Map<List<DrHospitalDto>>(result);
            if(drhpmap==null)
            {
                return BadRequest("hata");
            }
            return Ok(drhpmap);
        }
        [HttpPost("{tc}")]
        public IActionResult GetByDoctorTc(string tc)
        {
            List<Doctor> doctor = _drservice.GetDoctors().ToList();
            List<Doctor> item = new List<Doctor>();
            item = doctor;
            int i = 0;
            for (; i < item.Count; i++)
            {


                if (item[i].TcNo == tc)
                {

                    List<Doctor> bulunan = new List<Doctor>();
                    bulunan.Add(item[i]);
                    return Ok(bulunan);

                }
                else if (item[i].TcNo != tc)
                {
                    i++;
                    List<Doctor> bulunan = new List<Doctor>();
                    bulunan.Add(item[i]);
                    return Ok(bulunan);
                }

                else
                    return BadRequest("hata");
            }
            return Ok();
        }
       
    }
}
