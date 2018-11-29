using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class ServiceClassViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}