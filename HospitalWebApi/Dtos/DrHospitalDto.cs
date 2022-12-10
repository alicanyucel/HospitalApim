using HospitalWebApi.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HospitalWebApi.Dtos
{
    public class DrHospitalDto:EntityBase

    {
        [Required]
        public string DoctorId { get; set; }
        public string HospitalId { get; set; }
        public string Hname { get; set; }
        public string DName { get; set; }

    }
}
