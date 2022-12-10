using HospitalWebApi.Models.Abstract;

namespace HospitalWebApi.Dtos
{
    public class DoctorDto:EntityBase
    {
        public string Name { get; set; }
        public string TcNo { get; set; }

    }
}
