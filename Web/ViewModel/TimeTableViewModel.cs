using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class TimeTableViewModel
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd-hh-mm")]
        public DateTime DepartureTime { get; set; }

        [DataType(DataType.DateTime)]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd-hh-mm")]
        public DateTime ArrivalTime { get; set; }

        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } 
    }
}