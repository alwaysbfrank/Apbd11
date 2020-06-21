using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apbd11.Models
{
    public class Medicament
    {
        [Column("IdMedicament")]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }

        public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    }
}