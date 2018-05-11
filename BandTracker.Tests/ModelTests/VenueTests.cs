using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandTracker.Models;
using System.Collections.Generic;
using System;

namespace BandTracker.Tests
{
    [TestClass]
    public class VenueTests : IDisposable
    {

      public void Dispose()
      {
        Venue.DeleteAll();
        // Band.DeleteAll();
      }

        [TestMethod]
        public void GetAll_DbStartsEmpty_0()
        {

          int result = Venue.GetAll().Count;

          Assert.AreEqual(0, result);
        }
    }
}
