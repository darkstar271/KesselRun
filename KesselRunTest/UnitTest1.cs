using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KesselRun;
using KesselRun.Business;

namespace KesselRunTest
{
    [TestClass]
    public class UnitTest1
    {
        BettingDetails testBettingDetails = new BettingDetails();
        [TestMethod]
        public void GameEndTest()
        {public static List<bool> AllBusted = new List<bool> { true, true, true, true };
        var Actual = testBettingDetails.CheckDead();
        Assert.IsFalse();




        }

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
