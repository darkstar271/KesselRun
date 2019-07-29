using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KesselRun.Business
{
    public class BettingDetails
    {   // Sets up the Properties for "END" and sets it with the value TRUE, this is part of the EndGame() method
        public static bool End { get; set; } = true;
        // AllBusted is a List to hold 4 Boolen values, all are set to "True" and  will be tested with the CheckDead method
        // if all of the values change to false then it's "End of Game"
        public List<bool> AllBusted = new List<bool> { true, true, true, true };
        // so when each player runs out of money , there value is changed to false, each player has the same order as there place in the Factory Class.

        public bool CheckDead(List<bool> AllBusted)
        {
            //this checks for True/False, if any values are still true, if all values are false, then it changes "End" to false
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
