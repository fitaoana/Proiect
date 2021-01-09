using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Specialization
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Specialization Name")]
        public string Name { set; get; }

        [StringLength(1000)]
        public string Description { set; get; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
