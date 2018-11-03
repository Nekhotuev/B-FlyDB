using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public class Departure
    {
        [ForeignKey("Flight")]
        public Guid DepartureId { get; set; }
        public Flight Flight { get; set; }
        public Gate Gate { get; set; }
        public Terminal Terminal { get; set; }
        public Airport Airport { get; set; }
    }
}