using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Doctor
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "The format of the name should be 'Firstname Lastname'")]
        [Display(Name = "Doctor Name")]
        public string DoctorName { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        public int SpecializationID { get; set; }
        public Specialization Specialization { get; set; }
    }
}
