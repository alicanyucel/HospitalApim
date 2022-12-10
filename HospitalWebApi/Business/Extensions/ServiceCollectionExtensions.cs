using HospitalWebApi.Business.Abstract;
using HospitalWebApi.Business.Concrete;
using HospitalWebApi.Dal.Abstract;
using HospitalWebApi.Dal.Concrete.EntityFrameWork;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalWebApi.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
         
            serviceCollection.AddScoped<IDoctorService, DoctorManager>();
            serviceCollection.AddScoped<IDoctorDal, EfDoctorDal>();
            serviceCollection.AddScoped<IHospitalService, HospitalManager>();
            serviceCollection.AddScoped<IHospitalDal, EfHospitalDal>();
            serviceCollection.AddScoped<IDoctorHospitalDetailService, DoctorHospitalManager>();
            serviceCollection.AddScoped<IDrHpDal, EfDrHpDal>();
            return serviceCollection;
            
        }
    }
}