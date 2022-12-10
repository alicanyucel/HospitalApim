using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Dal.Abstract;
using HospitalWebApi.Models;
namespace HospitalWebApi.Business.Concrete
{
    public class HospitalManager : IHospitalService
    {
        private readonly IHospitalDal _hospitalDal;
        public HospitalManager(IHospitalDal hospitalDal)
        {
            _hospitalDal = hospitalDal;
        }

        public void Add(Hospital hospital)
        {
            _hospitalDal.Add(hospital);           
        }

        public void Delete(Hospital hospital)
        {
            _hospitalDal.Delete(hospital);
        }

        public Hospital GetHospitalById(int id)
        {
            return _hospitalDal.Get(h => h.Id == id);
        }

        public IList<Hospital> GetHospitals()
        {
            return _hospitalDal.GetAll();
        }

        public void Update(Hospital hospital)
        {
            _hospitalDal.Update(hospital);
        }
    }
}
