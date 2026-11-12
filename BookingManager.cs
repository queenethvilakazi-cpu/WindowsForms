using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class BookingManager
    {
        public List<EquipmentBooking> Bookings = new List<EquipmentBooking>();

        public delegate void BookingAddedHandler( object sender, BookingEventArgs e);

        public event BookingAddedHandler BookingAdded;

        public string BookingOK()
        {
            return "Booking OK";
        }

        public string BookingNotAllowed()
        {
            return "Booking Not Allowed";
        }

        public void AddBooking(
            EquipmentBooking booking)
        {
            Bookings.Add(booking);

            BookingAdded?.Invoke(this, new BookingEventArgs("Booking Added Successfully"));
        }

        public void RemoveBooking(
            EquipmentBooking booking)
        {
            Bookings.Remove(booking);
        }
    }
}
