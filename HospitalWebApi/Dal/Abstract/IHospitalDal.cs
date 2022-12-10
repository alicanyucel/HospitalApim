using HospitalWebApi.GenericRepositoryPattern;
using HospitalWebApi.Models;

namespace HospitalWebApi.Dal.Abstract
{
    public interface IHospitalDal:IEntityRepository<Hospital>
    {
    }
}
