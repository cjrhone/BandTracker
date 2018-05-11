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

        [TestMethod]
        public void Equals_ReturnsTrueIfNamesAreTheSame_Venue()
        {
          Venue firstVenue = new Venue("Key Arena");
          Venue secondVenue = new Venue("Key Arena");


          Assert.AreEqual(firstVenue, secondVenue);
        }

        [TestMethod]
        public void Save_SavesToDatabase_VenueList()
        {
          Venue testVenue = new Venue("Tacoma Dome");

          testVenue.Save();
          List<Venue> result = Venue.GetAll();
          List<Venue> testList = new List<Venue>{testVenue};
          Console.WriteLine("result " + result.Count);
          Console.WriteLine("testList " + testList.Count);


          CollectionAssert.AreEqual(testList, result);
        }
    }
}
