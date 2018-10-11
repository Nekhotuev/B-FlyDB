using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B_FlyDB.Model
{
    public class ServiceClass
    {
        public ServiceClass()
        {
            Reservations = new HashSet<Reservation>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}