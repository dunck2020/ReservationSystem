using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReservationSystem
{
    public partial class ReservationScreen : Form
    {
        Reservation guestReservation = new Reservation();
        
        #region CONSTANTS

        const string VICTORIAN_DESCRIPTION = "$800 per night, includes breakfast, free WiFi, 1 bedroom w/king bed, " +
                                            "2 baths, whirlpool bath in master, murphy bed, sleeper sofa, balcony view of garden.";

        const string CHARLES_MANOR_DESCRIPTION = "$300 per night, includes breakfast, free Wifi, 1 king bed," +
                                               "1 bath, sleeper sofa, mini-fridge, sleeps 4.";

        const string HAUNTED_STUDIO = "$500 per night, isolated top floor, king bed and murphy bed, balcony view of garden," +
                                     "breakfast included, mini-fridge, Wifi, sleeps 4.";

        const string ADA_ROOM = "ADA access lower floor, $300 per night, includes breakfast, free Wifi, 1 king bed," +
                               "1 bath, sleeper sofa, mini-fridge, sleeps 4.";

        const string DATAPATH_RESERVATIONS = @"ReservationData/ReservationData.txt";

        const string FILE_ERROR_MESSAGE = "Error with guest file.";

        const string PLEASE_CHOOSE_NEW_ROOM = "Please Choose a different type of room.";

        const string NO_ROOMS_AVAILABLE = "Sorry no rooms of that type are available.";

        #endregion

        public ReservationScreen()
        {
            InitializeComponent();
            SetDefaultValuesOnForm();
        }

        #region ACTIVE FORM CONTROLS

        /// <summary>
        /// The following radio buttons are to select room type on the form
        /// when each radio button is selected a decription of the room will
        /// show in a message box and charges will be assesed in the Reservation class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Victorian_Enter(object sender, EventArgs e)
        {
            btn_Victorian.Checked = true;
            MessageBox.Show(VICTORIAN_DESCRIPTION);        
            guestReservation.RoomTypeAndRoomChargeAssignment(Reservation.RoomType.VictorianSuite);
        }
        private void Btn_CharlesManor_Enter(object sender, EventArgs e)
        {
            btn_CharlesManor.Checked = true;
            MessageBox.Show(CHARLES_MANOR_DESCRIPTION);
            guestReservation.RoomTypeAndRoomChargeAssignment(Reservation.RoomType.CharlesManor);
        }
        private void Btn_Haunted_Enter(object sender, EventArgs e)
        {
            btn_Haunted.Checked = true;
            MessageBox.Show(HAUNTED_STUDIO);
            guestReservation.RoomTypeAndRoomChargeAssignment(Reservation.RoomType.HauntedRoom);
        }
        private void Btn_ADARoom_Enter(object sender, EventArgs e)
        {
            btn_ADARoom.Checked = true;
            MessageBox.Show(ADA_ROOM);
            guestReservation.RoomTypeAndRoomChargeAssignment(Reservation.RoomType.ADAAccess);
        }

        /// <summary>
        /// calls roomnumber method and display method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Process_Click(object sender, EventArgs e)
        {
            bool isRoomAssigned = false;
            //adds entered information to reservation object
            AddGuestInformationFromForm();

            //assigns available room to reservation
            guestReservation.RoomNumber = AssignRoomNumberRangeFromTypeOfRoom(guestReservation.RoomChoice, ref isRoomAssigned);

            //displays message if rooms not available
            if (isRoomAssigned)
            {
                DisplayReservationInformation(guestReservation);
            }
            else
            {
                MessageBox.Show(PLEASE_CHOOSE_NEW_ROOM);
            }
            
        }

        /// <summary>
        /// processes reservation information to ReservationData.txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Payment_Click(object sender, EventArgs e)
        {
            this.Close();
            //
            //payment form is a work in progress
            //
            // guestReservation.IsPaid = true;

            //writes reservation data to file
            guestReservation.SaveReservationData(guestReservation);

            //prompt user to check customer in now 

            DialogResult result;
            string confirm = "Guest Reservation has been saved!";
            string message = "Check in now?";
            result = MessageBox.Show(message, confirm, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                //if yes user is taken to check in screen
                CheckInScreen checkInScreen = new CheckInScreen();
                checkInScreen.ShowDialog();
            }
            else
            {
                //if no user is taken to refreshed reservation screen
                ReservationScreen reservationScreen = new ReservationScreen();
                reservationScreen.ShowDialog();
            }

        }

        /// <summary>
        /// exit button to leave reservation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// when room selected Process button is visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomSelector_Enter(object sender, EventArgs e)
        {
            btn_Process.Visible = true;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Displays message box for conformation
        /// </summary>
        /// <param name="guestReservation"></param>
        private void DisplayReservationInformation(Reservation guestReservation)
        {
            DialogResult result;
            string confirm = "Verfiy with customer:";
            string message = "Guest: " + guestReservation.FirstName + " " + guestReservation.LastName + "\n" +
                                "Length of Stay: " + guestReservation.LengthOfStay + " night(s)\n" +
                                "Room Type: " + guestReservation.RoomChoice + "\n" +
                                "Check in Date: " + guestReservation.CheckInDate + "\n" +
                                "Total Charges: " + guestReservation.RoomCharge().ToString("c2") + " Tax included";

            result = MessageBox.Show(message, confirm, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                btn_Payment.Visible = true;
            }
        }

        /// <summary>
        /// Methods to assign room number based off roomtype selected
        /// </summary>
        /// <param name="roomChoice"></param>
        /// <returns>roomNumber</returns>
        private int AssignRoomNumberRangeFromTypeOfRoom(Reservation.RoomType roomChoice, ref bool isRoomAssigned)
        {
            int roomNumber;
            switch (roomChoice)
            {
                case Reservation.RoomType.VictorianSuite:
                    //total of 25 Victorian suites to be assigned 201-225
                    roomNumber = RoomNumberGenerator(201, 225, ref isRoomAssigned);
                    break;

                case Reservation.RoomType.HauntedRoom:
                    //total of 10 haunted rooms to be assigned 301-310
                    roomNumber = RoomNumberGenerator(301, 310, ref isRoomAssigned);
                    break;

                case Reservation.RoomType.ADAAccess:
                    //total of 19 ada access rooms 151-169
                    roomNumber = RoomNumberGenerator(151, 169, ref isRoomAssigned);
                    break;

                case Reservation.RoomType.CharlesManor:
                    //total of 50 charles manor rooms 101-150
                    roomNumber = RoomNumberGenerator(101, 150, ref isRoomAssigned);
                    break;

                default:
                    roomNumber = 0;
                    break;
            }
            return roomNumber;
        }

        /// <summary>
        /// generates room number from available rooms with given parameters
        /// </summary>
        /// <param name="roomNumLowLimit"></param>
        /// <param name="roomNumHighlimit"></param>
        /// <returns></returns>
        private int RoomNumberGenerator(int roomNumLowLimit, int roomNumHighlimit, ref bool isRoomAssigned)
        {
            int assignedRoomNumber = roomNumLowLimit;
            //load file into string array
            string[] roomNumberArray = ReadGuestFile(DATAPATH_RESERVATIONS);

            //create a list for holding room numbers only
            List<string> roomNumberOnly = ConvertArrayToRoomNumberOnlyList(roomNumberArray);

            //convert string room number list to integer array to compare
            int[] roomArray = Array.ConvertAll(roomNumberOnly.ToArray(), int.Parse);

            //send variables as reference variables for assignment
            RoomNumberAssignment(ref assignedRoomNumber, ref roomArray, ref isRoomAssigned, ref roomNumHighlimit);

            //displays message of room number or no rooms available
            DisplayRoomAssignedOrNotAvailable(isRoomAssigned, assignedRoomNumber, roomNumHighlimit);

            return assignedRoomNumber;
        }

        /// <summary>
        /// converts array to list with only room numbers
        /// </summary>
        /// <param name="roomNumberArray"></param>
        /// <returns></returns>
        private List<string> ConvertArrayToRoomNumberOnlyList(string[] roomNumberArray)
        {
            List<string> roomNumberOnly = new List<string>();

            //load room numbers in list from array
            for (int x = 0; x < roomNumberArray.Length; x++)
            {
                roomNumberOnly.Add(roomNumberArray[x].Split(' ')[0]);
            }
            return roomNumberOnly;
        }

        /// <summary>
        /// assigns room number within limit range
        /// </summary>
        /// <param name="assignedRoomNumber"></param>
        /// <param name="roomArray"></param>
        /// <param name="roomAssigned"></param>
        /// <param name="roomNumHighlimit"></param>
        private void RoomNumberAssignment(ref int assignedRoomNumber, ref int[] roomArray, ref bool isRoomAssigned, ref int roomNumHighlimit)
        {
            //loop will determine if a room number is available
            //assigmed room variable starts at low limit increments by 1

            while ((assignedRoomNumber <= roomNumHighlimit) && !isRoomAssigned)
            {
                if (roomArray.Contains(assignedRoomNumber))
                {
                    assignedRoomNumber++;
                }
                else
                {
                    isRoomAssigned = true;
                }
            }
        }

        /// <summary>
        /// message user of room availability
        /// </summary>
        /// <param name="roomAssigned"></param>
        /// <param name="assignedRoomNumber"></param>
        /// <param name="roomNumHighlimit"></param>
        private void DisplayRoomAssignedOrNotAvailable(bool roomAssigned, int assignedRoomNumber, int roomNumHighlimit)
        {
            if (roomAssigned)
            {
                MessageBox.Show($"Room Number {assignedRoomNumber} is available.");
            }
            else if (assignedRoomNumber > roomNumHighlimit)
            {
                MessageBox.Show(NO_ROOMS_AVAILABLE);
            }
        }

        /// <summary>
        /// adds information from text boxes and numeric selectors to object
        /// </summary>
        private void AddGuestInformationFromForm()
        {
            guestReservation.FirstName = txt_FirstName.Text;
            guestReservation.LastName = txt_LastName.Text;
            guestReservation.LengthOfStay = num_LengthOfStay.Value;
            guestReservation.NumberOfAdults = num_NumberOfAdults.Value;
            guestReservation.NumberOfChildren = num_NumberOfChildren.Value;
            guestReservation.CheckInDate = dte_CheckInDate.Text;
        }

        /// <summary>
        /// Method to set default values
        /// </summary>
        private void SetDefaultValuesOnForm()
        {
            num_LengthOfStay.Value = 1;
            num_NumberOfAdults.Value = 1;
            dte_CheckInDate.MinDate = DateTime.Now;
            btn_Victorian.Checked = false;
            
        }

        /// <summary>
        /// reads file into list and returns array
        /// </summary>
        /// <returns></returns>
        private string[] ReadGuestFile(string DATAPATH)
        {
            //read file to list from given directory
            List<string> fileData = new List<string>();
            try
            {
                fileData = File.ReadAllLines(DATAPATH).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(FILE_ERROR_MESSAGE);
            }

            string[] roomNumberArray = fileData.ToArray();
            return roomNumberArray;
        }

        #endregion

    }
}
