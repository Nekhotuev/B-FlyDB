﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B_FlyDB.Model
{
    public class ServiceClass
    {
        [Key, ForeignKey("Reservation")]
        public Guid ServiceClassId { get; set; }
        public string Name { get; set; }
        public Reservation Reservation { get; set; }
    }
}