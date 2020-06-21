using System;
using System.Collections;
using System.Collections.Generic;

namespace Apbd11.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    }
}