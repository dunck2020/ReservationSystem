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
    public partial class CheckInScreen : Form
    {
        #region CONSTANTS

        //constant for data directory
        const string DATAPATH_RESERVATION = @"ReservationData/ReservationData.txt";
        const string DATAPATH_CHECKEDIN = @"ReservationData/CheckedIn.txt";
        const string FILE_ERROR_MESSAGE = "Error with guest file.";
        const string CUSTOMER_CHECKED_IN = "Customer has checked in already.";
        const string NO_CANCEL_IF_CHECKED_IN = "Customer has checked in, please proceed to the check out option to check out a guest.";
        const string MESSAGE = "Verification";
        const string CONFIRM_CANCEL = "Do you wish to cancel?";
        const string CONFIRM_CHECK_IN = "Do you wish to check-in?";

        #endregion

        public CheckInScreen()
        {
            InitializeComponent();
            FillListBox();
        }

        #region ACTIVE CONTROLS

        private void Btn_ExitCheckIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (lst_CustomerSearch.SelectedItem != null)
            {
                string[] confirmNotCheckedIn = lst_CustomerSearch.SelectedItem.ToString().Split();
                if (confirmNotCheckedIn[3] != "***Checked-In***")
                {
                    bool cancelReservation = true;
                    VerfiyWithUserToContinue(MESSAGE, CONFIRM_CANCEL, cancelReservation);
                }
                else
                {
                    MessageBox.Show(NO_CANCEL_IF_CHECKED_IN);
                }
            }
        }

        private void Btn_CheckIn_Click(object sender, EventArgs e)
        {
            if (lst_CustomerSearch.SelectedItem != null)
            {
                string[] confirmNotCheckedIn = lst_CustomerSearch.SelectedItem.ToString().Split();
                if (confirmNotCheckedIn[3] != "***Checked-In***")
                {
                    bool cancelReservation = false;
                    VerfiyWithUserToContinue(MESSAGE, CONFIRM_CHECK_IN, cancelReservation);
                }
                else
                {
                    MessageBox.Show(CUSTOMER_CHECKED_IN);
                }

            }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// fill list box to view current reservations
        /// </summary>
        private void FillListBox()
        {
            //list for storing only room and name for list box
            List<string> reservationList = new List<string>();

            //fill array with current reservations
            string[] reservationListArray = ReadGuestFile(DATAPATH_RESERVATION);

            //edits string for viewing in list box
            for (int x = 0; x < reservationListArray.Length; x++)
            {
                string roomNumberGuestName = ConvertStringToRoomAndName(reservationListArray, ref x);
                //populate list with edited reservation text
                reservationList.Add(roomNumberGuestName);
            }

            //set list box to sorted by room number and fill
            lst_CustomerSearch.Sorted = true;
            lst_CustomerSearch.DataSource = reservationList;

        }

        /// <summary>
        /// searches reservation file for guest info
        /// </summary>
        /// <param name="guestFile"></param>
        /// <param name="cancel"></param>
        private void SearchFileForGuestReservation(string guestFile, bool cancel)
        {
            //fill array from reservation file
            string[] reservationListArray = ReadGuestFile(DATAPATH_RESERVATION);

            string roomNumberGuestName;

            for (int x = 0; x < reservationListArray.Length; x++)
            {
                roomNumberGuestName = ConvertStringToRoomAndName(reservationListArray, ref x);

                if (roomNumberGuestName == guestFile && !cancel)
                {
                    UpdateGuestCheckInFile(roomNumberGuestName);
                    UpdateGuestAsCheckedIn(ref reservationListArray, ref x, guestFile);
                    FillListBox();
                }

                else if ((roomNumberGuestName == guestFile) && cancel)
                {
                    RemoveGuestReservationFromFile(ref reservationListArray, ref x);
                    FillListBox();
                }
            }
        }

        /// <summary>
        /// updates file and displays in listbox
        /// </summary>
        /// <param name="reservationListArray"></param>
        /// <param name="x"></param>
        /// <param name="guestFile"></param>
        private void UpdateGuestAsCheckedIn(ref string[] reservationListArray, ref int x, string guestFile)
        {
            //list to store resevation info from array
            List<string> reservationFileListEdit = new List<string>(reservationListArray);

            //removes from current list
            reservationFileListEdit.RemoveAt(x);

            //update string as checked in
            string[] updatedGuestFile = guestFile.Split(' ');
            guestFile = updatedGuestFile[0] + " " + updatedGuestFile[1] + " " + updatedGuestFile[2] + " ***Checked-In***";

            //adds updated guest file
            reservationFileListEdit.Add(guestFile);

            //write new data to file
            WriteGuestFile(DATAPATH_RESERVATION, reservationFileListEdit);

        }

        /// <summary>
        /// removes guest file form ReservationData text file
        /// </summary>
        /// <param name="reservationListArray"></param>
        /// <param name="x"></param>
        private void RemoveGuestReservationFromFile(ref string[] reservationListArray, ref int x)
        {
            //remove from list
            List<string> reservationFileListEdit = new List<string>(reservationListArray);
            reservationFileListEdit.RemoveAt(x);

            //update reservation file
            WriteGuestFile(DATAPATH_RESERVATION, reservationFileListEdit);

            //message user guest revervation canceled
            MessageBox.Show("Guest Reservation Canceled");
            x = reservationListArray.Length;
        }

        /// <summary>
        /// saves guest file to CheckedIn text file
        /// </summary>
        /// <param name="roomNumberGuestName"></param>
        private void UpdateGuestCheckInFile(string roomNumberGuestName)
        {
            MessageBox.Show("Guest Checked In");
            try
            {
                File.AppendAllText(DATAPATH_CHECKEDIN, roomNumberGuestName + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show(FILE_ERROR_MESSAGE);
            }
        }

        /// <summary>
        /// converts file string to room and name only
        /// </summary>
        /// <param name="reservationListArray"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        private string ConvertStringToRoomAndName(string[] reservationListArray, ref int x)
        {
            //array to split reverservation array item and fill list
            string[] textEdit = reservationListArray[x].Split(' ');

            //string for comparing guestfile
            string roomNumberGuestName = textEdit[0] + " " + textEdit[1] + " " + textEdit[2] + " " + textEdit[3];

            return roomNumberGuestName;
        }

        /// <summary>
        /// writes guest infor to new file
        /// </summary>
        /// <param name="DATAPATH"></param>
        /// <param name="fileEdit"></param>
        private void WriteGuestFile(string DATAPATH, List<string> fileEdit)
        {
            try
            {
                File.WriteAllLines(DATAPATH, fileEdit);
            }
            catch
            {
                MessageBox.Show(FILE_ERROR_MESSAGE);
            }
        }

        /// <summary>
        /// reads file into list and returns array
        /// </summary>
        /// <returns></returns>
        private string[] ReadGuestFile(string dataPath)
        {
            List<string> fileData = new List<string>();
            try
            {
                fileData = File.ReadAllLines(dataPath).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(FILE_ERROR_MESSAGE);
            }

            string[] roomNumberArray = fileData.ToArray();
            return roomNumberArray;
        }

        /// <summary>
        /// confirms with message box if user wants to proceed
        /// </summary>
        /// <param name="message"></param>
        /// <param name="confirm"></param>
        private void VerfiyWithUserToContinue(string message, string confirm, bool cancelReservation)
        {
            DialogResult result;
            result = MessageBox.Show(confirm, message, MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string reservationToCancel = lst_CustomerSearch.SelectedItem.ToString();

                SearchFileForGuestReservation(reservationToCancel, cancelReservation);
            }
        }

        #endregion
    }
}
