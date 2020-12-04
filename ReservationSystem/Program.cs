using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    static class Program
    {
        //********************************************************************************************//
        //*                                                                                          *//
        //* Title: Charleston Manor Reservation Application                                          *//
        //* Application Type: framework - WinForm                                                    *//
        //* Description: Basic application to allow check in of guests, search current guests,       *//
        //* check out guests, create new reservation, all stored in a text files.                    *//
        //* Author: Dunckel, John                                                                    *//
        //* Date Created: 11/19/20                                                                   *//
        //* Last Modified: 12/03/20                                                                  *//
        //*                                                                                          *//
        //********************************************************************************************//

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuestServiceMenu());

        }
    }

}
