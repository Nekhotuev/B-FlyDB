using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class CityViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Length must be less than 20")]
        [RegularExpression(@"[A-Za-z]", ErrorMessage = "Must contain only chars")]
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}