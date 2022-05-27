using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.HotelManagement
{
    public class RoomBooking
    {
        public string ReservationNumber { get; set; }
        public DateTime StartDate { get; set; }

        public int DurationInDays { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int GuestID { get; set; }
      //  public TYPE Type { get; set; }  

        //private Date startDate;
        //private int durationInDays;
        //private BookingStatus status;
        //private Date checkin;
        //private Date checkout;

        //private int guestID;
        // To DO
        //private Room room;
        //private Invoice invoice;
        //private List<Notification> notifications;

        public static RoomBooking FetchDetails(String reservationNumber)
        {
            return null;
        }
    }
}
