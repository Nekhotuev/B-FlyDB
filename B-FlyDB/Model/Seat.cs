using System;

namespace B_FlyDB.Model
{
    public class Seat
    {
        public Guid Id { get; set; }
        public int Row { get; set; }
        public char Columnn { get; set; }        
    }
}