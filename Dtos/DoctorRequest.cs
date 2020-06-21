using System.ComponentModel.DataAnnotations;

namespace Apbd11.Dtos
{
    public class DoctorRequest
    {
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
    }
}