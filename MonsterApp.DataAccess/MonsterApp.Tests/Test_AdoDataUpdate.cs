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
      
      
      [Fact]
      public void Test_UpdateGender()
      {
         var data = new AdoData();
         var actual = data.UpdateGender(gender);
         Assert.True(actual);
      }
      [Fact]
      public void Test_UpdateMonsterType()
      {
         var data = new AdoData();
         var actual = data.UpdateMonsterType(type);
         Assert.True(actual);
      }
      [Fact]
      public void test_UpdateTitle()
      {
         var data = new AdoData();
         var actual = data.UpdateTitle(title);
         Assert.True(actual);
      }
   }
}
