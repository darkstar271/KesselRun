using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KesselRun.Business
{
    public class BettingDetails
    {
        public static bool End { get; set; } = true;
        // this uses a List to hold 4 Boolen values, all are set to "True" and  will be tested with the CheckDead method
        // if all of the values change to false then it's "End of Game"
        public static List<bool> AllBusted = new List<bool> { true, true, true, true };





        public bool CheckDead()
        {

            //this checks for True/False, if any values are still true, if all values are false, it then runs a method 
            if (!AllBusted.Contains(true))
            {
                End = false;
                //everyone is dead
                return true;

            }

            return false;
        }


    }
}
