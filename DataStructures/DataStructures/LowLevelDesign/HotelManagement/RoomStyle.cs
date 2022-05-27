using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.HotelManagement
{
    public enum RoomStyle
    {
        Standard, Deluxe, FamilySuite, BusinessSuite
    }

    public enum RoomStatus
    {
        Available, Reserved, Occupied, NotAvailable, BeingServiced, Other
    }

    public enum BookingStatus
    {
        Requested, Pending, Confirmed, CheckedIn, CheckedOut, Cancelled, Abandoned
    }

    public enum AccountStatus
    {
        Active, Closed, Canceled, Blacklisted, Blocked
    }

    public enum AccountType
    {
        Member, Guest, Manager, Receptionist
    }

    public enum PaymentStatus
    {
        Unpaid, Pending, Completed, Filled, Declined, Cancelled, Abandoned, Settling, Settled, Refunded
    }

    public class Address
    {
        private String streetAddress;
        private String city;
        private String state;
        private String zipCode;
        private String country;
    }
}
