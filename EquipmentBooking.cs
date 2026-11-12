using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public abstract class EquipmentBooking
    {
        public int BookingID { get; set; }

        public string EquipmentName { get; set; }

        public string EquipmentType { get; set; }

        public string Venue { get; set; }

        public DateTime BookingDate { get; set; }

        public int MaximumUsers { get; set; }

        public string BookingStatus { get; set; }

        public abstract string GetBookingType();
    }
}
