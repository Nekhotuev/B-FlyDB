using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class FlightViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [DataType(DataType.Currency)]
        public decimal TicketPrice { get; set; }
        public int MaxDiscount { get; set; }
        [DataType(DataType.Date)]
        public int SaleStartDay { get; set; }
        [DataType(DataType.Date)]
        public int SaleEndDay { get; set; }
        public int DistanceInMile { get; set; }
        [DataType(DataType.Time)]
        public DateTime TimeOfFlight { get; set; }
        public int LuggageAmount { get; set; }
        public int LuggageMaxWeight { get; set; }
        public int HandLuggageAmount { get; set; }
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