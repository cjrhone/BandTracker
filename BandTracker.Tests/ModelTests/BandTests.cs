using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandTracker.Models;
using System.Collections.Generic;
using System;

namespace BandTracker.Tests
{
    [TestClass]
    public class BandTests : IDisposable
    {

      public void Dispose()
      {
        Band.DeleteAll();
        // Venue.DeleteAll();
      }

        [TestMethod]
        public void GetAll_DbStartsEmpty_0()
        {

          int result = Band.GetAll().Count;

          Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfNamesAreTheSame_Band()
        {
          Band firstBand = new Band("RipShredders");
          Band secondBand = new Band("RipShredders");


          Assert.AreEqual(firstBand, secondBand);
        }
    }
}
