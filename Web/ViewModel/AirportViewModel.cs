using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class AirportViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Value must be entered")]
        [StringLength(20, ErrorMessage = "Length must be less than 20")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Must contain only chars and numbers")]
        public string Name { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Length must be less than 6")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Must contain only chars and numbers")]
        public string Code { get; set; }

        public virtual City City { get; set; }
        public virtual IEnumerable<AirportScheme> AirportSchemes { get; set; }
        public virtual IEnumerable<City> Cities { get; set; }
        public int CityId { get; set; }
    }
}