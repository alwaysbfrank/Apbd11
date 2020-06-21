using Apbd11.Models;
using Microsoft.EntityFrameworkCore;

namespace Apbd11.Daos
{
    public class MedicineDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        
        protected MedicineDbContext()
        {
        }

        public MedicineDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}