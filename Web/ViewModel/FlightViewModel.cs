using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Core.Model;

namespace Web.ViewModel
{
    public class FlightViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }

        [Required]
        [Range(0, 1000000, ErrorMessage = "Out of range 0-1 000 000")]
        [DataType(DataType.Currency)]
        public decimal TicketPrice { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Out of range 0-100")]
        public int MaxDiscount { get; set; }

        [Required]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd")]
        [DataType(DataType.Date)]
        public int SaleStartDay { get; set; }

        [Required]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd")]
        [DataType(DataType.Date)]
        public int SaleEndDay { get; set; }

        [Required]
        [Range(0,200000, ErrorMessage = "Out of range 0-200000")]
        public int DistanceInMile { get; set; }

        [Required]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd-hh-mm")]
        [DataType(DataType.Time)]
        public DateTime TimeOfFlight { get; set; }

        [Required]
        [Range(0, 400, ErrorMessage = "Out of range 1-400")]
        public int LuggageAmount { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Out of range 1-100")]
        public int LuggageMaxWeight { get; set; }

        [Required]
        [Range(0, 400, ErrorMessage = "Out of range 1-400")]
        public int HandLuggageAmount { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Out of range 1-100")]
        public int HandLuggageMaxWeight { get; set; }

        public int ArrivalAirportSchemeId { get; set; }
        public virtual AirportScheme ArrivalAirportScheme { get; set; }
        public int DepartureAirportSchemeId { get; set; }
        public virtual AirportScheme DepartureAirportScheme { get; set; }
        public virtual ICollection<TimeTable> TimeTables { get; set; }
        public int PlaneId { get; set; }
        public virtual Plane Plane { get; set; }
    }
}