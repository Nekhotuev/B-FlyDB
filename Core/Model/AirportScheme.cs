using System;

namespace Core.Model
{
    public class AirportScheme
    {
        public Guid Id { get; set; }
        public Airport Airport { get; set; }
        public Terminal Terminal { get; set; }
        public Gate Gate { get; set; }
    }
}