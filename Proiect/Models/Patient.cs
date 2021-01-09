using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Patient
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "The format of the name must be 'Lastname Firstname'")]
        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }

        [StringLength(1)]
        [RegularExpression(@"^[A-Z]$", ErrorMessage = "The letter must be capital")]
        public string Gender { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
