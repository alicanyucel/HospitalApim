using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Dal.Abstract;
using HospitalWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Business.Concrete
{
    public class DoctorHospitalManager:IDoctorHospitalDetailService
    {
       
        private readonly IDrHpDal _drhpDal;
        public DoctorHospitalManager(IDrHpDal drhpDal)
        {
            
            _drhpDal = drhpDal;
        }

        public void Add(DoctorHospital drhospital)
        {
            _drhpDal.Add(drhospital);
        }

        public void Delete(DoctorHospital drhospital)
        {
            _drhpDal.Delete(drhospital);
        }

        public List<Doctor> GetDoctorByHospital(int id)
        {
            throw new NotImplementedException();
        }

        public DoctorHospital GetDoctorHospitalById(int id)
        {
            return _drhpDal.Get(dh => dh.Id == id);
        }

        public IList<DoctorHospital> GetDoctorHospitals()
        {
            return _drhpDal.GetAll();
        }

        public List<Doctor> GetdrByHospital(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DoctorHospital drhospital)
        {
            _drhpDal.Update(drhospital);
        }
    }
}
