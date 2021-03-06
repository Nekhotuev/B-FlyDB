﻿using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class AirportSchemeViewModel
    {
        public int Id { get; set; }
        public int AirportId { get; set; }
        public virtual Airport Airport { get; set; }
        public int TerminalId { get; set; }
        public virtual Terminal Terminal { get; set; }
        public int GateId { get; set; }
        public virtual Gate Gate { get; set; }
        public virtual ICollection<Flight> ArrivalFlights { get; set; }
        public virtual ICollection<Flight> DepartureFlights { get; set; }
    }
}