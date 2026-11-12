using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AddBookingForm : Form
    {
        private BookingManager manager;
        public AddBookingForm(BookingManager manager)
        {
            InitializeComponent();
            this.manager = manager;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookingID.Text == "")
            {
                MessageBox.Show(
                    "Booking ID Required");

                return;
            }

            if (txtPurpose.Text == "")
            {
                MessageBox.Show(
                    "Purpose Required");

                return;
            }

            int maxUsers;

            if (!int.TryParse(
                nudMaxUsers.Value.ToString(),
                out maxUsers))
            {
                MessageBox.Show(
                    "Invalid Users");

                return;
            }

            if (maxUsers <= 0)
            {
                MessageBox.Show(
                    "Maximum Users must be greater than 0");

                return;
            }

            foreach (var booking in manager.Bookings)
            {
                if (booking.BookingID ==
                    Convert.ToInt32(
                    txtBookingID.Text))
                {
                    MessageBox.Show(
                        "Duplicate Booking ID");

                    return;
                }
            }

            BookingManager temp =
                new BookingManager();

            BookingStatusDelegate del;

            if (maxUsers > 0)
            {
                del = temp.BookingOK;
            }
            else
            {
                del = temp.BookingNotAllowed;
            }

            EquipmentBooking newBooking;

            if (cboEquipment.Text.Contains("Camera"))
            {
                newBooking =
                    new CameraBooking();
            }
            else
            {
                newBooking =
                    new ProjectorBooking();
            }

            newBooking.BookingID =
                Convert.ToInt32(
                txtBookingID.Text);

            newBooking.EquipmentName =
                cboEquipment.Text;

            newBooking.EquipmentType =
                cboCategory.Text;

            newBooking.Venue =
                cboLocation.Text;

            newBooking.BookingDate =
                dtpBookingDate.Value;

            newBooking.MaximumUsers =
                maxUsers;

            newBooking.BookingStatus =
                del();

            manager.AddBooking(
                newBooking);

            this.Close();
        
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
