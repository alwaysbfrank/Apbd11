using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apbd11.Models
{
    [Table("Prescriptions_Medicaments")]
    public class PrescriptionMedicament
    {
        [ForeignKey("Medicaments")]
        public int IdMedicament { get; set; }

        public Medicament Medicament { get; set; }
        [ForeignKey("Prescriptions")]
        public int IdPrescription { get; set; }

        public Prescription Prescription { get; set; }
        public int? Dose { get; set; }
        [MaxLength(100)]
        public string Details { get; set; }
    }
}