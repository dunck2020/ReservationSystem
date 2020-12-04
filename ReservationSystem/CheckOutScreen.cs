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
    public partial class CheckOutScreen : Form
    {
        #region CONSTANTS

        //constant for data directory
        const string DATAPATH_CHECKEDIN = @"ReservationData/CheckedIn.txt";
        const string DATAPATH_RESERVATIONS = @"ReservationData/ReservationData.txt";
        const string FILE_ERROR_MESSAGE = "Error with guest file.";

        #endregion

        public CheckOutScreen()
        {
            InitializeComponent();
            FillListBox();
        }

        #region ACTIVE CONTROLS

        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (lst_CustomerSearch.SelectedItem != null)
            {
                //uses text from list box for file removal
                string guestToCheckOut = lst_CustomerSearch.SelectedItem.ToString();
                SearchFileAndRemoveGuestReservation(guestToCheckOut);
            }

        }
        private void Btn_ExitCheckOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// method to fill list box with current guests
        /// </summary>
        private void FillListBox()
        {
            //list for active(current) guests
            List<string> activeGuestList = FillArrayWithStringEdit();

            //populate list box with edited string
            lst_CustomerSearch.Sorted = true;
            lst_CustomerSearch.DataSource = activeGuestList;

        }

        /// <summary>
        /// reads file to array and splits string for list
        /// </summary>
        /// <returns></returns>
        private List<string> FillArrayWithStringEdit()
        {
            //read file into array for active guests
            string[] activeGuestArray = ReadGuestFile(DATAPATH_CHECKEDIN);

            List<string> activeGuestList = new List<string>();

            //add guest info in edited text string
            for (int x = 0; x < activeGuestArray.Length; x++)
            {
                //split file string to room and name
                string[] textEdit = activeGuestArray[x].Split(' ');
                string newText = textEdit[0] + " " + textEdit[1] + " " + textEdit[2];
                activeGuestList.Add(newText);

            }
            return activeGuestList; 
        }

        /// <summary>
        /// method to fill arrays with both files and find guest to check out
        /// </summary>
        /// <param name="guestFile"></param>
        private void SearchFileAndRemoveGuestReservation(string guestFile)
        {
            //read both files into arrays
            string[] activeGuestArray = ReadGuestFile(DATAPATH_CHECKEDIN);
            string[] reservationArray = ReadGuestFile(DATAPATH_RESERVATIONS);

            //send data to method for reoval
            RemoveGuestFromFile(guestFile, activeGuestArray, DATAPATH_CHECKEDIN);
            RemoveGuestFromFile(guestFile, reservationArray, DATAPATH_RESERVATIONS);

            //fill list box with new information
            FillListBox();

            //let user know guest removed
            MessageBox.Show("Guest has been checked out.  Thank you for staying at the Charleston.");
        }

        /// <summary>
        /// method to remove guest info from both reservation file and checkedin file
        /// </summary>
        /// <param name="guestFile"></param>
        /// <param name="activeGuestArray"></param>
        /// <param name="DATAPATHCHECKEDIN"></param>
        private void RemoveGuestFromFile(string guestFile, string[] guestArray, string DATAPATH)
        {

            for (int x = 0; x < guestArray.Length; x++)
            {
                //string array to split text into room num and guest name for search
                string[] textEdit = guestArray[x].Split(' ');
                string roomNumberGuestName = textEdit[0] + " " + textEdit[1] + " " + textEdit[2];

                if (roomNumberGuestName == guestFile)
                {
                    //load array data into list for removal of guest
                    List<string> fileEdit = new List<string>(guestArray);
                    fileEdit.RemoveAt(x);

                    //write new data to file
                    WriteGuestFile(DATAPATH, fileEdit);

                    //variable set to max to exit loop
                    x = guestArray.Length;
                }

            }
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

        #endregion

    }
}
