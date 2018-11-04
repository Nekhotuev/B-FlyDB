using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public class Arrival
    {
        [ForeignKey("Flight")]
        public Guid ArrivalId { get; set; }
        public Flight Flight { get; set; }
        public AirportScheme AirportScheme { get; set; }
    }
}