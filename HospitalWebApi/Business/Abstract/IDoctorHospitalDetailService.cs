using HospitalWebApi.Models;

namespace HospitalWebApi.Business.Abstract
{
    public interface IDoctorHospitalDetailService
    {
        IList<DoctorHospital> GetDoctorHospitals();
        DoctorHospital GetDoctorHospitalById(int id);
        void Add(DoctorHospital drhospital);
        void Update(DoctorHospital drhospital);
        void Delete(DoctorHospital drhospital);
      
       
    }
}
