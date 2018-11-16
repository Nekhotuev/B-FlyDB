﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace Core.Model
{
    public class FlightViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal TicketPrice { get; set; }
        public int MaxDiscount { get; set; }
        public int SaleStartDay { get; set; }
        public int SaleEndDay { get; set; }
        public int DistanceInMile { get; set; }
        public DateTime TimeOfFlight { get; set; }
        public int LuggageAmount { get; set; }
        public int LuggageMaxWeight { get; set; }
        public int HandLuggageAmount { get; set; }
        public int HandLuggageMaxWeight { get; set; }

        public AirportScheme ArrivalAirportScheme { get; set; }
        public AirportScheme DepartureAirportScheme { get; set; }
        public ICollection<TimeTable> TimeTables { get; set; }
        public Plane Plane { get; set; }
    }
}