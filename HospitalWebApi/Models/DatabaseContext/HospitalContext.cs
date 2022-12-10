using Microsoft.EntityFrameworkCore;

namespace HospitalWebApi.Models
{
    #region context
    // identity api kullandık user ve role bir de string değer alacak.
    //code first ayağa kaldıracağız.
    public class HospitalContext : DbContext
    {
        
        public HospitalContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ROTCU0Q;Initial Catalog=HospitalDb;Integrated Security = True");
        }

        // best practise gereği tablo adları çoğul olmalı
        public DbSet<DoctorHospital> Hospitals { get; set; } 
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorHospital> DoctorsAndHospitals { get; set; }
        
    }
    #endregion
}
