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
    public class HospitalController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHospitalService _hospitalService;
        public HospitalController(IMapper mapper, IHospitalService hospitalService)
        {
            _mapper = mapper;
            _hospitalService = hospitalService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            // getbyname eklenecek
            var hpall = _hospitalService.GetHospitals().ToList();
            var maphp = _mapper.Map<List<HospitalDto>>(hpall);

            if (maphp == null)
            {
                return BadRequest("hastaneler listelenemedi");
            }
            return Ok(maphp);
        }
        [HttpGet("{id}")]
        public IActionResult GetHospitalById(int id)
        {
            var hpall = _hospitalService.GetHospitalById(id);
            var hospital = _mapper.Map<HospitalDto>(hpall);
            return Ok(hospital);
        }
        [HttpPost]
        public IActionResult Post(Hospital hospital)
        {
            // sadece doktorhospitalcontroler kaldı
            _hospitalService.Add(hospital);
            return Ok("hastane eklendi");
        }

    }
}
