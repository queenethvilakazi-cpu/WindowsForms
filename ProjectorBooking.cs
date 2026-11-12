using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class ProjectorBooking : EquipmentBooking
    {
        public override string GetBookingType()
        {
            return "Projector Booking";
        }
    }
}
