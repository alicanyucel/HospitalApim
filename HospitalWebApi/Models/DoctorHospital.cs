using HospitalWebApi.GenericRepositoryPattern;
using HospitalWebApi.Models.Abstract;

namespace HospitalWebApi.Models
{
    public class DoctorHospital:EntityBase,IEntity
    {
        public Doctor Doctor { get; set; }
        public Hospital Hospital { get; set; }
    }
}
