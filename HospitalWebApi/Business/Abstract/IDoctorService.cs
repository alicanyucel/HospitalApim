using HospitalWebApi.Dtos;
using HospitalWebApi.Models;
using System.Linq.Expressions;

namespace HospitalWebApi.Business.Abstract
{
    public interface IDoctorService
    {
        IList<Doctor> GetDoctors();
        Doctor GetDoctorById(int id);
        Doctor GetDoctorByName(string name);
        void Add(Doctor doctor);
        void Update(Doctor doctor);
        void Delete(Doctor doctor);
       


    }
}
