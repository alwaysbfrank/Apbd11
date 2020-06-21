using System;
using System.Collections.Generic;
using Apbd11.Models;
using Microsoft.EntityFrameworkCore;

namespace Apbd11.Daos
{
    public static class ModelBuilderSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var medicament = Medicament();
            var prescriptionMedicament = PrescriptionMedicament();
            var prescription = Prescription();
            var patient = Patient();
            var doctor = Doctor();
            prescription.IdDoctor = doctor.Id;
            prescription.IdPatient = patient.Id;
            prescriptionMedicament.IdPrescription = prescription.Id;
            prescriptionMedicament.IdMedicament = medicament.Id;

            modelBuilder.Entity<Medicament>().HasData(medicament);
            modelBuilder.Entity<Doctor>().HasData(doctor);
            modelBuilder.Entity<Patient>().HasData(patient);
            modelBuilder.Entity<Prescription>().HasData(prescription);
            modelBuilder.Entity<PrescriptionMedicament>().HasData(prescriptionMedicament);
        }

        private static Medicament Medicament()
        {
            return new Medicament
            {
                Name = "Prozac",
                Description = "Good stuff",
                Type = "antidepressant",
                Id = 1
            };
        }

        private static PrescriptionMedicament PrescriptionMedicament()
        {
            return new PrescriptionMedicament
            {
                Dose = 1,
                Details = "Don't share with children"
            };
        }

        private static Prescription Prescription()
        {
            return new Prescription
            {
                Date = new DateTime(1990, 01, 01),
                DueDate = new DateTime(2000, 01, 01),
                Id = 1
            };
        }

        private static Patient Patient()
        {
            return new Patient
            {
                FirstName = "Adam",
                LastName = "Mickiewicz",
                BirthDate = new DateTime(1798, 12, 24),
                Id = 1
            };
        }

        private static Doctor Doctor()
        {
            return new Doctor
            {
                FirstName = "Artur",
                LastName = "Partyka",
                Email = "artur@danone.pl",
                Id = 1
            };
        }
    }
}