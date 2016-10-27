using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
   public partial class AdoDataTests
   {
      private Gender gender;
      private MonsterType type;
      private Title;
      public AdoDataTests()
      {
         gender = new Gender() { GenderName = "Test Gender" };
         type = 
      }
      [Fact]
      public void Test_InsertGender()
      {
         var data = new AdoData();
         var actual = data.insertGender(gender);
         Assert.True(actual);
      }

   }
}
