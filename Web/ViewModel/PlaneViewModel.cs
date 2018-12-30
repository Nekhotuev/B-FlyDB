using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class PlaneViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        [RegularExpression(@"^[A-Za-z0-9]*", ErrorMessage = "Must contain only chars and numbers")]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Length must be less than 20")]
        [RegularExpression(@"^[A-Za-z0-9]*", ErrorMessage = "Must contain only chars and numbers")]
        public string PlaneModel { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Length must be less than 20")]
        [RegularExpression(@"^[A-Za-z0-9]*", ErrorMessage = "Must contain only chars and numbers")]
        public string PlaneModification { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Out of range 0-1000")]
        public int FirstBCSeatRow { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Out of range 0-1000")]
        public int LastBCSeatRow { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Length must be less than 2")]
        [RegularExpression(@"^[A-Za-z]*", ErrorMessage = "Must contain only chars")]
        public string FirstBCSeat { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Length must be less than 2")]
        [RegularExpression(@"^[A-Za-z]*", ErrorMessage = "Must contain only chars")]
        public string LastBCSeat { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Out of range 0-1000")]
        public int FirstECSeatRow { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Out of range 0-1000")]
        public int LastECSeatRow { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Length must be less than 2")]
        [RegularExpression(@"^[A-Za-z]*", ErrorMessage = "Must contain only chars")]
        public string FirstECSeat { set; get; }

        [Required]
        [StringLength(2, ErrorMessage = "Length must be less than 2")]
        [RegularExpression(@"^[A-Za-z]*", ErrorMessage = "Must contain only chars")]
        public string LastECSeat { get; set; }

        [Required]
        [Range(0, 10000, ErrorMessage = "Out of range 0-10000")]
        public double FuelConsumptionPerKm { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}