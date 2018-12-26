using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class GateViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Length must be less than 5")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Must contain only chars and numbers")]
        public string Name { get; set; }
        public virtual ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}