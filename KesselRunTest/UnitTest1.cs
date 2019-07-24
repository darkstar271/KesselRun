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
        {
            List<bool> AllBusted = new List<bool> { true, true, true, true };
            var Actual = testBettingDetails.CheckDead(AllBusted);


            Assert.IsFalse(Actual);




        }

        [TestMethod]
        public void GameEndTest2()
        {
            List<bool> AllBusted = new List<bool> { false, false, false, false };
            var Actual = testBettingDetails.CheckDead(AllBusted);


            Assert.IsTrue(Actual);




        }




    }
}
