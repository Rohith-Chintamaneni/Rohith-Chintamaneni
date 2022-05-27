using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.HotelManagement
{
    public class Guest : Person
    { 
        public int TotalRoomsCheckedIn { get; set; }
    //private int totalRoomsCheckedIn;

        public List<RoomBooking> GetBookings()
        {
            return null;
        }
    }
}
