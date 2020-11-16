using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Please enter for the event")]
        [StringLength(50, MinimumLength =3)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter a description for the event")]
        [StringLength(500)]
        public string Description { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
