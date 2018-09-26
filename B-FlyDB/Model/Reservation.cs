using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class Reservation
    {
        public Reservation()
        {
            
        }
        public int Row { get; set; }
        public char Columnn { get; set; }
        public ServiceClass ServiceClass { get; set; }
        
    }
}