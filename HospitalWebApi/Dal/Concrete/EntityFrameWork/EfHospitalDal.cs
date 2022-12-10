using HospitalWebApi.Dal.Abstract;
using HospitalWebApi.GenericRepositoryPattern;
using HospitalWebApi.Models;

namespace HospitalWebApi.Dal.Concrete.EntityFrameWork
{
    public class EfHospitalDal : EfEntityRepositoryBase<Hospital, HospitalContext>, IHospitalDal
    {

    }
}