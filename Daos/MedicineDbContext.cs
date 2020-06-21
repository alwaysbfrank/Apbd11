using Apbd11.Models;
using Microsoft.EntityFrameworkCore;

namespace Apbd11.Daos
{
    public class MedicineDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
        
        protected MedicineDbContext()
        {
        }

        public MedicineDbContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PrescriptionMedicament>().HasKey(table => new {table.IdMedicament, table.IdPrescription});
            builder.Seed();
        }
    }
}