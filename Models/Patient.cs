using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apbd11.Models
{
    [Table("Patients")]
    public class Patient
    {
        [Column("IdPatient")] 
        public int Id { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}