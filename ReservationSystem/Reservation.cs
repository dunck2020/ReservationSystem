using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReservationSystem
{
    public class Reservation
    {
        #region ENUM

        public enum RoomType
        {
            VictorianSuite,
            CharlesManor,
            HauntedRoom,
            ADAAccess
        }

        #endregion

        #region CONSTANTS

        const double STATE_TAX = .06;
        const int VICTORIAN_ROOM_RATE = 800;
        const int CHARLES_ROOM_RATE = 300;
        const int HAUNTED_ROOM_RATE = 500;
        const int ADA_ROOM_RATE = 300;
        const string DATAPATH = @"ReservationData/ReservationData.txt";
        const string FILE_ERROR_MESSAGE = "Error with guest file.";

        #endregion

        #region FIELDS

        private string _firstName;
        private string _lastName;
        private string _checkInDate;
        private bool _isPaid;
        private RoomType _roomChoice;
        private decimal _lengthOfStay;
        private decimal _numberOfAdults;
        private decimal _numberOfChildren;
        private int _roomNumber;
        private double _roomCharges;

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }

        public bool IsPaid
        {
            get { return _isPaid; }
            set { _isPaid = value; }
        }

        public RoomType RoomChoice
        {
            get { return _roomChoice; }
            set { _roomChoice = value; }
        }

        public decimal LengthOfStay
        {
            get { return _lengthOfStay; }
            set { _lengthOfStay = value; }
        }

        public decimal NumberOfAdults
        {
            get { return _numberOfAdults; }
            set { _numberOfAdults = value; }
        }

        public decimal NumberOfChildren
        {
            get { return _numberOfChildren; }
            set { _numberOfChildren = value; }
        }
        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }
        public double RoomCharges
        {
            get { return _roomCharges; }
            set { _roomCharges = value; }
        }

        #endregion

        #region METHODS

        //class method to calculate room charges
        public double RoomCharge()
        {
            double roomCharge;
            RoomCharges *= (double)LengthOfStay;
            roomCharge = RoomCharges * STATE_TAX + RoomCharges;
            return roomCharge; 
        }

        //class method for assignment of room value
        public void RoomTypeAndRoomChargeAssignment(RoomType room)
        {
            RoomChoice = room;
            switch (RoomChoice)
            {
                case RoomType.VictorianSuite:
                    RoomCharges = VICTORIAN_ROOM_RATE;
                    break;
                case RoomType.CharlesManor:
                    RoomCharges = CHARLES_ROOM_RATE;
                    break;
                case RoomType.HauntedRoom:
                    RoomCharges = HAUNTED_ROOM_RATE;
                    break;
                case RoomType.ADAAccess:
                    RoomCharges = ADA_ROOM_RATE;
                    break;
            }

        }

        //saves data to specified reservation file
        public void SaveReservationData(Reservation guestReservation)
        {

            string fileString = guestReservation.RoomNumber + " " +
                                guestReservation.LastName + " " +
                                guestReservation.FirstName + " __" + "\n";

            //  *******  for use in further application upgrades  *********  //

            //guestReservation.CheckInDate + " " +
            //guestReservation.RoomCharge() + " " +
            //guestReservation.IsPaid + " " +
            //guestReservation.RoomChoice + " " +
            //guestReservation.NumberOfAdults + " " +
            //guestReservation.NumberOfChildren + " " +
            //guestReservation.LengthOfStay + "\n";

            try
            {
                File.AppendAllText(DATAPATH, fileString);
            }
            catch (Exception)
            {
                MessageBox.Show(FILE_ERROR_MESSAGE);
            }
            
        }

        #endregion

    }
}
