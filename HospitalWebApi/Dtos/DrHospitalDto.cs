using HospitalWebApi.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HospitalWebApi.Dtos
{
    public class DrHospitalDto:EntityBase

    {
        [Required]
        public string DrTcNo { get; set; }
        public string DrName { get; set; }
        public string HospitalName { get; set; }

    }
}
