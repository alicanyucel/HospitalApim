using HospitalWebApi.Models;

namespace HospitalWebApi.Business.Abstract
{
    public interface IHospitalService
    {
        IList<Hospital> GetHospitals();
        Hospital GetHospitalById(int id);
        void Add(Hospital hospital);
        void Update(Hospital hospital);
        void Delete(Hospital hospital);
    }
}
