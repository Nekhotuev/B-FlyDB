﻿using System;

namespace B_FlyDB.Model
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}