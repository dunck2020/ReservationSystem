using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class GuestServiceMenu : Form
    {
        public GuestServiceMenu()
        {
            InitializeComponent();
        }

        #region ACTIVE CONTROLS

        //opens form for guest reservation
        private void Btn_ReservationAccess_Click(object sender, EventArgs e)
        {
            ReservationScreen reservationScreen = new ReservationScreen();
            reservationScreen.ShowDialog();
        }

        //explanation about app and creator
        private void Btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is designed to allow users to create a new guest reservation, check in/search current guest " +
                "reservations, remove or cancel reservations, check out guests currently checked in.  Guest reservations are available based " +
                "off room numbers at this time.  This app was created by John Dunckel Nov 19th, 2020 Latest update December 3rd, 2020. " +
                "Thank you for trying my app! ");
        }

        //exits the application
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //link to check local weather for user
        private void Lnk_WeatherCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://weather.com/weather/today/l/6601a5980fbedad7c12362bd61a9ad4bc3d833d0bedf6ef00d94a2695d6b510d");
            lnk_WeatherCheck.LinkVisited = true;
        }

        //opens form for guest check in
        private void Btn_CheckIn_Click(object sender, EventArgs e)
        {
            CheckInScreen checkInScreen = new CheckInScreen();
            checkInScreen.ShowDialog();
        }

        //opens form for guest check out
        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            CheckOutScreen checkOutScreen = new CheckOutScreen();
            checkOutScreen.ShowDialog();
        }

        //opens form for amenities - currently in development
        private void Btn_Amenities_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section is currently in development.");
        }

        #endregion


    }
}
