using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Apbd11.Migrations;

namespace Apbd11.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        [ForeignKey("Patients")]
        public int IdPatient { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("Doctors")]
        public int IdDoctor { get; set; }
        public Doctor Doctor { get; set; }
        public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    }
}