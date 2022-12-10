using HospitalWebApi.GenericRepositoryPattern;
using HospitalWebApi.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace HospitalWebApi.Models
{
    #region doktor 
    public class Doctor:EntityBase,IEntity
    {
        [Required(ErrorMessage = "tc no boş geçilemez.")]
        [MinLength(11)] // tc no 11 hane olmalı ve zorunludur.
        public string TcNo { get; set; } // tcno ile matematiksel işlem yapmayacam
        // ayrıca 000 ile başlayan tclerde mevcut string tanımlanmalı.
        public string Name { get; set; }
        public string LastName { get; set; }
        // aşağıdaki şeyi kapsullemek için private verdin oop gereği
        private ICollection<DoctorHospital> DoctorHospitals { get; set; }

    }
    #endregion
}
