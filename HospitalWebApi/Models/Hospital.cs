
using HospitalWebApi.GenericRepositoryPattern;
using HospitalWebApi.Models.Abstract;

namespace HospitalWebApi.Models
{
    #region Hospital Class
    public class Hospital:EntityBase,IEntity
    {
      
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
        private ICollection<DoctorHospital> DoctorHospitals { get; set; }
      
    }
    #endregion 
}
