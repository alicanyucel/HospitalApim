using HospitalWebApi.Models.Abstract;

namespace HospitalWebApi.Dtos
{
    public class HospitalDto:EntityBase
    {
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
    }
}
