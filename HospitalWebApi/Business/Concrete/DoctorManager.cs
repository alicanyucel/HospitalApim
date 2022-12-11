using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Dal.Abstract;
using HospitalWebApi.Dtos;
using HospitalWebApi.Models;
using System.Linq.Expressions;

namespace HospitalWebApi.Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorDal _doctorDal;
        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public void Add(Doctor doctor)
        {
          _doctorDal.Add(doctor);

        }

        public void Delete(Doctor doctor)
        {
            _doctorDal.Delete(doctor);
        }

        public List<Doctor> GetDoctorByHospital(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctorById(int id)
        {
            return _doctorDal.Get(d => d.Id == id);
        }
        
        
        public Doctor GetDoctorByName(string name)
        {
            return _doctorDal.Get(d=>d.Name==name);
        }

        public IList<Doctor> GetDoctors()
        {
            return _doctorDal.GetAll();
        }

        

        public void Update(Doctor doctor)
        {
            _doctorDal.Update(doctor);
        }
    }
}
