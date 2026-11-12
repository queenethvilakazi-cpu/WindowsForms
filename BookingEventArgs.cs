using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class BookingEventArgs : EventArgs
    {
        public string Message { get; set; }

        public BookingEventArgs(string message)
        {
            Message = message;
        }
    }
}
