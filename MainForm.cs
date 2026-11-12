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
    public partial class MainForm : Form
    {
        BookingManager manager = new BookingManager();

        public MainForm()
        {
            InitializeComponent();
        }
     
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            manager.BookingAdded += Manager_BookingAdded;

            RefreshGrid();
        }
        private void Manager_BookingAdded( object sender, BookingEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
        private void RefreshGrid()
        {
            dgvBookings.DataSource = null;
            dgvBookings.DataSource =
                manager.Bookings;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {

            AddBookingForm form = new AddBookingForm(manager);

            form.ShowDialog();

            RefreshGrid();
        }

        private void btnRemoveBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow != null)
            {
                EquipmentBooking booking =
                    (EquipmentBooking)
                    dgvBookings.CurrentRow.DataBoundItem;

                manager.RemoveBooking(
                    booking);

                RefreshGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
