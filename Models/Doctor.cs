using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apbd11.Models
{
    [Table("Doctors")]
    public class Doctor
    {
        [Column("IdDoctor")]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}