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
    public class DoctorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDoctorService _doctorservice;
        public DoctorController(IDoctorService doctorService,IMapper mapper)
        {
            _mapper = mapper;
            _doctorservice = doctorService;
        }
        [HttpPost("{name}")]
        public IActionResult GetByNameDoctor(string name)
        {

            List<Doctor> doctor = _doctorservice.GetDoctors().ToList();
            List<Doctor> item = new List<Doctor>();
            item = doctor;
            int i = 0;
            for (; i < item.Count; i++)
            {


                if (item[i].Name == name )
                {

                    List<Doctor> bulunan = new List<Doctor>();
                    bulunan.Add(item[i]);
                    return Ok(bulunan);

                }
                else if (item[i].Name!=name)
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
        [HttpGet]
        public IActionResult GetAll()
        {
            //

            // getbyname eklenecek
            var drall = _doctorservice.GetDoctors().ToList();
            var mapdr = _mapper.Map<List<DoctorDto>>(drall);
          
            if (mapdr == null)
            {
                return BadRequest("doktorlar listelenemedi");
            }
            return Ok(mapdr);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            var result = _doctorservice.GetDoctorById(id);
            var mapdr = _mapper.Map <DoctorDto > (result);
            if (mapdr == null)
                return BadRequest("hata");
            else
                return Ok(mapdr);
        }
        [HttpPost]
        public IActionResult Post(Doctor doctor)
        {
          
           _doctorservice.Add(doctor);
            return Ok("doktor eklendi");
        }
    }
}
