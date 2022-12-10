using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Dal.Abstract;
using HospitalWebApi.Models;

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

        public DoctorHospital GetDoctorHospitalById(int id)
        {
            return _drhpDal.Get(dh => dh.Id == id);
        }

        public IList<DoctorHospital> GetDoctorHospitals()
        {
            return _drhpDal.GetAll();
        }

        public void Update(DoctorHospital drhospital)
        {
            _drhpDal.Update(drhospital);
        }
    }
}
