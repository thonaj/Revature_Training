using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterApp.DataAccess;

namespace MonsterApp.Tests
{
   [TestClass]
   class AdoDataMsTests
   {
      private DataAccess.Models.Gender gender;
      [TestInitialize]
      public void initialize()
      {
         gender = new DataAccess.Models.Gender() { GenderName = "new gender", Active = true };
      }
      [TestCleanup]
      public void cleanup()
      {
         GC.Collect();
      }
      [TestMethod]
      public void test_insertGender()
      {
         var data = new AdoData();
         var actual = data.insertGender(gender);
         Assert.IsTrue(actual);
      }
   }
}
